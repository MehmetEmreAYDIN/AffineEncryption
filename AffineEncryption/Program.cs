char[] alphabet = "ABCÇDEFGĞHIİJKLMNOÖPRSŞTUÜVYZ".ToCharArray();    //Enter the letters of the alphabet into this field.
char[] plainText = "ŞifreliMetin".ToUpper().ToCharArray();   // Enter the plain text into this field.
int a = 2; int b = 3;   //Enter the key parameters a and b into the respective fields.
string cipherText = string.Empty;

for (int i = 0; i < plainText.Length; i++)
{
    int ndx = (Array.IndexOf(alphabet, plainText[i]) * a + b) % alphabet.Length;
    cipherText += alphabet[ndx];
}
Console.WriteLine(cipherText);
