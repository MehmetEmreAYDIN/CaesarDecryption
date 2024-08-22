char[] alphabet = "ABCÇDEFGĞHIİJKLMNOÖPRSŞTUÜVYZ".ToCharArray();    //Enter letters of the alphabet in this field
char[] cipherText = "ŞifreliMetin".ToCharArray();  //Enter cipher text in this field
int key = 3;    //enter the key in this field
string plainText = string.Empty;

for (int i = 0; i < cipherText.Length; i++)
{
    int ndx = (Array.IndexOf(alphabet, char.ToUpper(cipherText[i])) - key);
    while (ndx < 0) ndx += alphabet.Length;
    plainText += alphabet[ndx];
}
Console.WriteLine(plainText);
