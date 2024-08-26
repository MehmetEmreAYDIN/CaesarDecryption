char[] alphabet = "ABCÇDEFGĞHIİJKLMNOÖPRSŞTUÜVYZ".ToCharArray();    //Enter the letters of the alphabet in this field.
char[] cipherText = "ŞifreliMetin".ToUpper().ToCharArray();    // Enter the plain text in this field.
int key = 3;    //Enter the key in this field.

string plainText = string.Empty;
for (int i = 0; i < cipherText.Length; i++)
{
    int ndx = (Array.IndexOf(alphabet, cipherText[i]) - key);
    while (ndx < 0) ndx += alphabet.Length;
    plainText += alphabet[ndx];
}
Console.WriteLine(plainText);
