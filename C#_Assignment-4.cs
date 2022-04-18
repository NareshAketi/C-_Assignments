using System;
using System.Collections;
using System.Threading.Tasks;

 namespace UserException
    {
        class customException
        {
            public static void Main()

            {
                Pushpop PP = new Pushpop();

                PP.Push(55);
                PP.Push(25);
                PP.Push(30);
                PP.Push(40);
                PP.Push(50);
                PP.print();
                Console.WriteLine("Element removed from the stack:" + PP.Pop());
                Console.WriteLine("Element removed from the stack:" + PP.Pop());

                Console.WriteLine("Element removed from the stack:" + PP.Pop());
                Console.WriteLine("Element removed from the stack:" + PP.Pop());
                Console.WriteLine("Element removed from the stack:" + PP.Pop());
                Console.WriteLine("Element removed from the stack:" + PP.Pop());
                Console.WriteLine("Element removed from the stack:" + PP.Pop());

                


            }
        }


        public class Push_pop
        {



            int[] arr = new int[5];

            int top = 0;

            public void Push(int data)

            {

                try
                {
                    if (top == 5)
                    {
                        throw new StackException(" User defined Stack Exception : over flow Exception");
                        return;
                    }


                    else
                    {
                        arr[top] = data;
                        top++;
                    }

                }
                catch (Exception e)
                {

                }
            }

            public void print()
            {

                for (int i = top - 1; i >= 0; i--)
                {
                    Console.WriteLine(arr[i]);
                }
            }
            public int Pop()
            {
                if (top <= 0)
                {
                    throw new StackException("user Defined Stack Exception : Under flow");
                    return 0;
                }
                else
                {
                    int temp = arr[top - 1];
                    top--;

                    return temp;
                }
            }
        }

        class StackException : Exception
        {
            public StackException(String message) : base(message)
            {
                Console.WriteLine(message);
            }

        }


    }