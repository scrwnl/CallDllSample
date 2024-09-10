using System.Runtime.InteropServices;

[DllImport("libc")]
static extern int puts(string s);

puts("こんにちは世界");
