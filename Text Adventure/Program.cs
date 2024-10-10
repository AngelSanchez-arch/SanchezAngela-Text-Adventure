using System.ComponentModel.Design;
using System.Net.Security;
using System.Numerics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.X86;

namespace Text_Adventure
{
    internal class Program
    {
       

    
            static void Main(string[] args)
        {
            bool FLIRTY;
            int LovePoints = 0;
            // /r means to go back some rooms
            Console.WriteLine("Hello, To Find your crush!");
            Console.WriteLine("I'm your host, Viola");
            Console.WriteLine("You'll pick between 2 Contestants");
            Console.WriteLine("Amelia  | Bass ");
            //to upper uppercases all lettters
            string input = Console.ReadLine();

            if (input.ToUpper() == "AMELIA")
            {
                Console.WriteLine("You choose amelia");
                Console.WriteLine("Amelia, Please stand up");
                Console.WriteLine("Hello! im Amelia. I use she/her pronouns, and i like small and cute things like Hello kitty! Nice to meet you!");
                Console.WriteLine("How will you introduce your self? friendly or filrty");
                input = Console.ReadLine();
                if (input.ToUpper() == "FRIENDLY")
                {

                    Console.WriteLine("You say that you love small and cute things. She emmits a aura of positivity.");
                    Console.WriteLine("Ooh you have good taste");
                    Console.WriteLine("She is slightly untrusting. okay then");
                    FLIRTY = false;
                    LovePoints -= 1;
                }
                else if (input.ToUpper() == "FILRTY")
                {
                    Console.WriteLine("You Introduce your self with a bow. You add a flirty comment. You say she's a real sweetie pie as you touch her hand");
                    Console.WriteLine("Oh a cute one! she moves closer.");
                    Console.WriteLine("You've earned a love point. Add these up for a special ending");
                    FLIRTY = true;
                    LovePoints += 1;
                }
                Console.WriteLine("Oooookay then?");
                Console.WriteLine("Lets play a game of 3 questions then!.You can choose between 2 questions per round! There are 3 rounds in total!");
                Console.WriteLine("Here are your first questions.");
                Console.WriteLine("You could ask if she'd eat a metric ton of bannanas over the course of a month and they're peels for one million dollers.");
                Console.WriteLine("Or you could ask if she'd ask out 100 guys over a month for 100,000 dollers");
                Console.WriteLine("What will you pick?!");
                Console.WriteLine("Bannanas or boys?");
                input = Console.ReadLine();
                if (input.ToUpper() == "BANNANAS")
                {
                    Console.WriteLine("You ask if she'd eat a metric ton of bannanas over the course of a month and they're peels for one million dollers.");
                    Console.WriteLine("Ugh(is that a reference to the song ugh?) I Love bananas but would hate to eat there peels. but then again one million could buy me all the pink i want.");
                }
                if (input.ToUpper() == "BOYS")
                {
                    Console.WriteLine("You ask if she'd ask out 100 guys for 100,000 dollers");
                    Console.WriteLine("tsk tsk tsk, I love dating and asking people out. I love the high class guys especially.");
                    Console.WriteLine("A very strange aura emmits from her, but you like it");
                    FLIRTY = true;
                    LovePoints += 1;
                }
                Console.WriteLine("30 Minitues of convorsation(and ads)go by");
                Console.WriteLine("Welcome back");
                Console.WriteLine("Onto The next round!");
                Console.WriteLine("The next question starts now.");
                Console.WriteLine("Our first contestant, i have a question for you, Do you love my love by Kuba oms or we are number one by Lazy Town more?");
                Console.WriteLine("MY LOVE| WE ARE NUMBER ONE");
                Console.ReadLine();



                if (input.ToUpper() == "MY LOVE")
                {
                    Console.WriteLine("You say that you like your love better wink wink.");
                    Console.WriteLine("You've earned another Flirty point!");
                    FLIRTY = true;
                    LovePoints += 1;
                }
                if (input.ToUpper() == "WE ARE NUMBER ONE")
                {
                    Console.WriteLine("tsktsk your cringe. Carisma -1");
                    FLIRTY = false;
                    LovePoints -= 1;
                }
                Console.WriteLine("Last question. Will you ask her on a date?");
                Console.WriteLine("YES| NO");
                input = Console.ReadLine();


                if (input.ToUpper() == "YES")
                {
                    Console.WriteLine("You want to wait a bit.Shes clearly very nervous");
                    Console.WriteLine("Wahhhh(She fake cries offscreen you run after her");
                    Console.WriteLine("Wahhhh(She fake cries offscreen)");
                    Console.WriteLine("You Ask whats wrong The truth is That i am not who i present as. I may be a girl but i don't like pink or dating 100 guys\".");
                    Console.WriteLine("I thought if i were to present as a girly girl i would get a date. But i did not play the game of faces well huh.");
                    Console.WriteLine("You tell her if she acts like her self she'll find the one");
                    Console.WriteLine("Thanks so much She says( She has left");
                    Console.WriteLine("The End Hey!?!?!? WHER ARER YOU GOING!?!???!?!?");
                }
                else if (input.ToUpper() == "NO")
                {
                    Console.WriteLine("You want to wait a bit.Shes clearly very nervous");
                    Console.WriteLine("Wahhhh(She fake cries offscreen you run after her");
                    Console.WriteLine("Wahhhh(She fake cries offscreen)");
                    Console.WriteLine("You Ask whats wrong The truth is That i am not who i present as. I may be a girl but i don't like pink or dating 100 guys\".");
                    Console.WriteLine("I thought if i were to present as a girly girl i would get a date. But i did not play the game of faces well huh.");
                    Console.WriteLine("You tell her if she acts like her self she'll find the one");
                    Console.WriteLine("Thanks so much She says( She has left");
                    Console.WriteLine("The End Hey!?!?!? WHER ARER YOU GOING!?!???!?!?");
                }
                //if (LovePoints < 3)
                {
                    Console.WriteLine("You want to wait a bit.Shes clearly very nervous");
                    Console.WriteLine("Wahhhh(She fake cries offscreen you run after her");
                    Console.WriteLine("Wahhhh(She fake cries offscreen)");
                    Console.WriteLine("You Ask whats wrong The truth is That i am not who i present as. I may be a girl but i don't like pink or dating 100 guys\".");
                    Console.WriteLine("I thought if i were to present as a girly girl i would get a date. But i did not play the game of faces well huh.");
                    Console.WriteLine("You tell her if she acts like her self she'll find the one");
                    Console.WriteLine("Thanks so much She says( She has left");
                    Console.WriteLine("The End Hey!?!?!? WHER ARER YOU GOING!?!???!?!?");
                }


                if (LovePoints == 3 && input == "YES")
                {
                    Console.WriteLine("Ummm....Sure?! Ugh! The anxitey builds..... She leaves the screen.");
                    Console.WriteLine("Ummmm. What to do? Ohhh We'll be right back after some ads");
                    Console.WriteLine("You run after her to calm her down You Ask whats wrong");
                    Console.WriteLine("The truth is That i am not who i present as. I may be a girl but i don't like pink or dating 100 guys I really just like Rock music and cosplaying as anime characters");
                    Console.WriteLine("I was so afrid to not be liked that i pretended to be vannila flavor when im really dark chocolete[You tell her faking it isn't worth it as you would be more distant anyway.");
                    Console.WriteLine("Your heart is beating fast");
                    Console.WriteLine("Hey would you like to kiss she asks.");
                    Console.WriteLine("You say yes as you 2 kiss.You suggest you 2 leave.");
                    Console.WriteLine("that sounds great!!!! The end Hey where are you too going!?!??!");
                    Console.WriteLine(" Hey where are you too going!?!??!");
                }


            }
            else if (input.ToUpper() == "Bass")
            {
                Console.WriteLine("Bass please step up to the stage");
                Console.WriteLine("Bass will you introduce yourself?");
                Console.WriteLine("hI i Am bass. (Very nonchalantly) i like video games, eatting snacks and making art");
                Console.WriteLine("(He seems to care very little about presentation with his cheeto covered shirt.)");
                Console.WriteLine("In this game you'll have the chance to ask the contestent 3 questions.");
                Console.WriteLine("You can ask what are ther favorite games or have they ever evan been on a date(Now he's rubbing off on me!?)");
                Console.WriteLine("DATE|Games");
                input = Console.ReadLine();
                if (input.ToUpper() == "DATE") ;
                {

                }                
                    Console.WriteLine("you ask if they ever evan been on a date.(Why is this happening to you as well?)");
                    Console.WriteLine("Nope. I only came here cuz my mom encoraged me to get out of my shell.");
            
                
                
                else if (input.ToUpper() == "DATE") ;
                {

                }




            }
           // else if (input() == ("Meadow)
           // {
           //   Console.WriteLine("Meadow Pleas staand up");
           // }
        }


        //static void 
        // void is a funtion
        //Exicutes lines of code top to bottom
    }
}
