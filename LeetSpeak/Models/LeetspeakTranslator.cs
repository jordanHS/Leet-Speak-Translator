namespace LeetSpeak.Models
{
  public class LeetSpeakTranslator
  {
    public LeetSpeakTranslator()
    {

    }

    public string Translate(string text)
    {
      char[] arr = text.ToCharArray();
      for(int i = 0; i < arr.Length; i++)
      {
        switch(arr[i])
        {
          case 'e':
            arr[i] = '3';
            break;
          case 'o':
            arr[i] = '0';
            break;
          case 'I':
            arr[i] = '1';
            break;
          case 't':
            arr[i] = '7';
            break;
          case 's':
            if(i != 0)
              arr[i] = 'z';
            break;
        }
      }
      string output = string.Join("", arr);
      return output;
    }
  }
}
