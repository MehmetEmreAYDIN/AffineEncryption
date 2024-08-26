char[] alphabet = "ABCÇDEFGĞHIİJKLMNOÖPRSŞTUÜVYZ".ToCharArray();    //Enter the letters of the alphabet in this field.
char[] plainText = "AçıkMetin".ToUpper().ToCharArray();   //Enter the plain text in this field.
int a = 2; int b = 3;   //Enter the key parameters a and b in the respective fields.

string cipherText = string.Empty;
for (int i = 0; i < plainText.Length; i++)
{
    int ndx = (Array.IndexOf(alphabet, plainText[i]) * a + b) % alphabet.Length;
    cipherText += alphabet[ndx];
}
Console.WriteLine(cipherText);
