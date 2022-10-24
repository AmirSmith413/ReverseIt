//Mini Challenge # 7
//Finished on 8/13/22
//Peer Reviewed by:Christian Pineda


//int will equal zero so it can be anything
int randomNum = 0;
string decision;
bool playagain = true;

while(playagain == true)
{
Console.WriteLine("Please enter a number.");
//put any random number here
randomNum = Convert.ToInt32(Console.ReadLine());
do
{
    Console.WriteLine(randomNum);
    randomNum--;
}
while(randomNum >= 1);

//the sequence of numbers will count down here
Console.WriteLine(randomNum);
Console.WriteLine("Would you like to try again?Type Y to try again or N to end.");
 decision = Console.ReadLine().ToUpper();
 //if the user wanted to try again, pressing "Y" will send them to the beginning
 if(decision == "Y")
    {
      playagain = true;
    }
    else if(decision == "N")
    {
      //if the user wanted to stop pressing "N" will end the program
      playagain = false;
    }
    else
    {
        Console.WriteLine("Please pick a valid option.");
    }   
}  


