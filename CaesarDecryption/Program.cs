char[] alphabet = "ABCÇDEFGĞHIİJKLMNOÖPRSŞTUÜVYZ".ToCharArray();    //Enter the letters of the alphabet into this field.
char[] cipherText = "ŞifreliMetin".ToUpper().ToCharArray();    // Enter the plain text into this field.
int key = 3;    //Enter the key into this field.
string plainText = string.Empty;

for (int i = 0; i < cipherText.Length; i++)
{
    int ndx = (Array.IndexOf(alphabet, cipherText[i]) - key);
    while (ndx < 0) ndx += alphabet.Length;
    plainText += alphabet[ndx];
}
Console.WriteLine(plainText);
