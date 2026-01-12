using System.Net.Mail;

int nilai;
string nama;

Console.WriteLine("Aplikasi Nilai Siswa");

Console.Write("Input nama: ");
nama = Console.ReadLine();

Console.Write("Input nilai: ");
nilai = int.Parse(Console.ReadLine());

if (nilai >= 75)
    Console.WriteLine("SELAMAT ANDA LULUS");
else
    Console.WriteLine("MAAF ANDA BELUM LULUS");