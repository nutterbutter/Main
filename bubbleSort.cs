using System;
			
public class bubbleSort
{
    public static void Main()
    {
        int[] bubble = new int[] {18, 15, 8, 7, 20};
        Console.WriteLine("The original [{0}]", string.Join(", ", bubble));    
        BubbleSort(bubble);
        Console.WriteLine("\n The bubble sort [{0}]", string.Join(", ", bubble));
        Console.Write("The bubble sort ");
        Console.WriteLine(string.Join(" ", bubble));
    }
    
    public static int[] BubbleSort(int[] _bubble)
    {
        for(int index = 1; index < _bubble.Length; index++)
        {
           Console.Out.Write(" index --" + _bubble[index] + "--");
            
            for(int i = 0; i < _bubble.Length - index; i++)
            {
                Console.Out.Write(" i-" + _bubble[i]+ ",");
                
                if(_bubble[i] > _bubble[i+1])
                {
                    int temp;
                    Console.Out.Write(" < if" );                    
                    temp = _bubble[i];
                    _bubble[i] = _bubble[i+1];
                    _bubble[i+1] = temp;
                    Console.Out.Write(" > " );
                }
            }
        }
    return _bubble;
    }
}