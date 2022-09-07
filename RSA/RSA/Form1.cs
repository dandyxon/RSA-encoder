using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;

namespace RSA
{
	public partial class Form1 : Form
	{

		char[] alph = new char[] { '#', 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И',
								   'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 'Т', 'У', 
			                       'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ь', 'Ы', 'Ъ', 'Э', 'Ю', 
								   'Я', ' ', '1', '2', '3', '4', '5', '6', '7', '8', '9', 
								   '0', 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 
								   'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у',
								   'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'э', 'ю', 'я', 'a', 'b',
								   'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 
								   'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 
							       'y', 'z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 
								   'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T',
								   'U', 'V', 'W', 'X', 'Y', 'Z', '.', ',', '!', '?', '(',
								   ')', 'ы', 'ь', 'ъ'};
		public Form1()
		{
			InitializeComponent();
		}	

		private bool IsTheNumberSimple(long n)
		{
			if (n < 2)
				return false;

			if (n == 2)
				return true;

			for (long i = 2; i < n; i++)
				if (n % i == 0)
					return false;

			return true;
		}
		private bool CoprimeNumbers(long x, long y)
		{
			while (x != y)
			{
				if (x > y)
					x = x - y;
				else
					y = y - x;
			}
			if (x == 1)
				return true;
			else
				return false;
		}
		private bool IsNumber(string text)
		{
			bool f = true;
			try
			{
				Convert.ToInt32(text);
				Convert.ToInt32(text);
			}
			catch
			{
				f = false;
			}

			return f;
		}
		private void Encrypt_button_Click(object sender, EventArgs e)
		{
			if(IsNumber(textBox_p.Text) && IsNumber(textBox_q.Text))
			{
				long p = Convert.ToInt32(textBox_p.Text);
				long q = Convert.ToInt32(textBox_q.Text);

				if (IsTheNumberSimple(p) && IsTheNumberSimple(q))
				{
					long n = p * q;
					long f = (p - 1) * (q - 1);
					long exp = Calculate_exp(f);
					long d = Calculate_d(exp, f);

					textBox_n1.Text = n.ToString();
					textBox_n2.Text = n.ToString();
					textBox_e.Text = exp.ToString();
					textBox_d.Text = d.ToString();

					string str = "";
					StreamReader sr = new StreamReader("Message.txt");

					while (!sr.EndOfStream)
					{
						str += sr.ReadLine();
					}
					sr.Close();

					List<string> res = RSA_coder(str, exp, n);

					StreamWriter sw = new StreamWriter("Encrypted_message.txt");
					foreach (string item in res)
						sw.WriteLine(item);
					sw.Close();

					Process.Start("Encrypted_message.txt");
				}
				else
					MessageBox.Show("Enter prime numbers p and q");
			}
			else
				MessageBox.Show("Enter prime numbers p and q");
		}
		private void Dencrypt_button_Click(object sender, EventArgs e)
		{
			if (textBox_d.Text.Length > 0 && textBox_n2.Text.Length > 0)
			{
				long d = Convert.ToInt64(textBox_d.Text);
				long n = Convert.ToInt64(textBox_n2.Text);

				List<string> message = new List<string>();
				StreamReader sr = new StreamReader("Encrypted_message.txt");

				while (!sr.EndOfStream)
				{
					message.Add(sr.ReadLine());
				}
				sr.Close();

				string res = RSA_decoder(message, d, n);
				StreamWriter sw = new StreamWriter("Decrypted_message.txt");
				sw.WriteLine(res);
				sw.Close();

				Process.Start("Decrypted_message.txt");
			}
			else
				MessageBox.Show("Enter private key");

		}
		private List<string> RSA_coder(string str, long exp, long n)
		{
			List<string> result = new List<string>();

			BigInteger block;

			for (int i = 0; i < str.Length; i++)
			{
				int index = Array.IndexOf(alph, str[i]);

				block = new BigInteger(index);
				block = BigInteger.Pow(block, (int)exp);

				BigInteger n_ = new BigInteger((int)n);

				block = block % n_;

				result.Add(block.ToString());
			}

			return result;
		}
		private string RSA_decoder(List<string> cipher, long d, long n)
		{
			string result = "";

			BigInteger block;

			foreach (string item in cipher)
			{
				block = new BigInteger(Convert.ToDouble(item));
				block = BigInteger.Pow(block, (int)d);

				BigInteger n_ = new BigInteger((int)n);

				block = block % n_;

				int index = Convert.ToInt32(block.ToString());
				if (index != -1)
					result += alph[index].ToString();
				else
					continue;
			}

			return result;
		}
		private long Calculate_exp(long f)
		{	
			List<long> array_e = new List<long>();
			Random rnd = new Random();

			for(long i = 2; i < f; i++)
			{
				if (IsTheNumberSimple(i) && CoprimeNumbers(i, f))
					array_e.Add(i);
			}
			long e = array_e[rnd.Next(array_e.Count)];
			return e;
		}
		private long Calculate_d(long exp, long f)
		{
			long d = 0;
			while (true)
			{
				if ((d * exp) % f == 1)
					break;
				else
					d++;
			}
			return d;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Process.Start("Message.txt");
		}

		private void Gen_primes_button_Click(object sender, EventArgs e)
		{
			Random rnd = new Random();
			textBox_p.Text = Er_cieve(rnd.Next(101, 400)).ToString();
			textBox_q.Text = Er_cieve(rnd.Next(101, 400)).ToString();
		}

		private void info_button_Click(object sender, EventArgs e)
		{
			MessageBox.Show("	В данном приложении реализована возможность шифрования и дешифрования данных при помощи криптосистемы RSA. " +
				"Нажмите на кнопку 'Enter message' и введите сообщение, которое вы хотите зашифровать. " +
				"Затем нажмите на кнопку 'Encrypt message', чтобы зашифровать данные. " +
				"Чтобы расшифровать сообщение нажмите кнопку 'Decrypt message'.");
		}

		private void button1_Click(object sender, EventArgs e)
		{
			File.WriteAllText("Message.txt", String.Empty);
			File.WriteAllText("Encrypted_message.txt", String.Empty);
			File.WriteAllText("Decrypted_message.txt", String.Empty);
			textBox_e.Clear();
			textBox_n1.Clear();
			textBox_d.Clear();
			textBox_n2.Clear();
			textBox_p.Clear();
			textBox_q.Clear();
		}

		private int Er_cieve(int predel)
		{
			Random rnd = new Random();
			List<int> cieve = new List<int>();
			int[] mass = new int[predel];

			for (int i = 0; i <= predel - 1; i++)
				mass[i] = i;

			int m = 2;
			while (m < predel)
			{
				if(mass[m] != 0)
				{
					int j = m * 2;
					while (j <= predel - 1)
					{
						mass[j] = 0;
						j = j + m;
					}
				}
				m += 1;
			}

			for(int i = 0; i < mass.Length; i++)
			{
				if (mass[i] != 0 && mass[i] > 100)
					cieve.Add(mass[i]);
			}

			return cieve[rnd.Next(cieve.Count)];
		}
	}
}
