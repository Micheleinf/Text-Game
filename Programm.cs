/File: History of Time / Program.cs
//Author: Michele Biondi
//Date: Last Updatet on December 10, 2019
//Description: A Text Game

//Discliamer:::::::::::::::::::::::::::::::::::::::::::::: This is a old Programm, so dont mind the goto commands::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::

using System;

namespace The_History_of_Time
{
    class Program
    {
        static void Main(string[] args)
        {


            string name, start, choice, twochoice, threechoice, fourchoice, fivechoice, choosemars;
            int health = 100;

            Console.WriteLine("LOADING THE HISTORY OF TIME GAME");
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("Starting Game Process");
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("Warning Explicit Content");
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("Made by Michele");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Downloading Dinosaurs");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Downloading non relevant graphics");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Starting Loading actuall game");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Game Loaded");
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("FOR THE BEST GAME EXPERIENCE TYPE EVERYTHING SMALL AND READ CAREFULLY !!! Made by Michele");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Welcome to the History of Time, enter Player name:   ");
            Console.ForegroundColor = ConsoleColor.Red;
            name = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Welcome " + name + " to the History of Time");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("-------------------------------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Blue;


        Started:

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("I WISH YOU GOOD LUCK, type [start] and press Enter too begin, if you dont know how to play type in [how] !");
            Console.ForegroundColor = ConsoleColor.Red;
            start = Console.ReadLine();

            if (start == "how")
            {

                Console.WriteLine("LOADING......");
                System.Threading.Thread.Sleep(2500);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("This is an adventure game");
                Console.WriteLine("you are in several situations and have to choose what you do.");
                Console.WriteLine("depending on what you choose, you get points or you lose or you die,you start with 100 points! the goal is to survive to the end");
                Console.WriteLine("By choosing a direction type the (number) and then enter. If something else is giving alway choose something in [] and then enter ");
                Console.WriteLine("There will be Minigames, in does just read carefully and do what its demanded");
                Console.WriteLine("If you play it clean, you will have a nice experience, (dont mind the faults in Writing) HAVE FUN !");
                Console.WriteLine("When you are ready type [start] and press enter");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.ReadLine();
                goto Started;



            }

            



            if (start == "start")
                    {
                        Console.WriteLine("LOADING......");
                        System.Threading.Thread.Sleep(2200);
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Mister XZ put you in a time machine.");
                        Console.WriteLine("Now you are travelling back in time when there were still dinosaurs.");
                        Console.WriteLine("When you arrive you see a Dinosaurs, running at you what do you do ?");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("1: Run away");
                        Console.WriteLine("2: Attack him");
                        Console.WriteLine("3: Try to hide");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        choice = Console.ReadLine();


                        if (choice == "1")
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            health = health - 30;
                            Console.WriteLine("You could escape by running away, put you hurt yourselve, that costed you probably points!");
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Youre Health is on " + health + " !");

                            Console.WriteLine("type next and and press enter");
                            Console.ReadLine();

                            goto next1;


                        }
                        else if (choice == "2")
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("You are really dumb ! Atacking a dinosaur ? are you mad ?");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("YOU DIED");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("LOADING......");
                            System.Threading.Thread.Sleep(4000);
                            Console.Clear();

                            goto Started;

                        }
                        else if (choice == "3")
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            health = health + 10;
                            Console.WriteLine("You are smart, you hide beside a rock and luckely the dinosaur didnt find you !");
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Youre Health is on " + health + " !");
                            Console.WriteLine("type next and press enter");
                            Console.ReadLine();

                            goto next1;




                        }

                    next1:

                        Console.WriteLine("NEXT CHOICE LOADING......");
                        System.Threading.Thread.Sleep(2200);
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("You succesfully exscaped.");
                        Console.WriteLine("But you are hungry now, so you are searching.");
                        Console.WriteLine("You found three delicious meals what do take ?");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("1: raw steak (probably from a T-REX)");
                        Console.WriteLine("2: Black Insects");
                        Console.WriteLine("3: nothing, because everything is disgusting");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        twochoice = Console.ReadLine();

                        if (twochoice == "1")
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            health = health - 30;
                            Console.WriteLine("Youre stomache is full, but you feel sick");
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Youre Health is on " + health + " !");

                            Console.WriteLine("type next and and press enter");
                            Console.ReadLine();

                            goto next2;


                        }
                        else if (twochoice == "2")
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            health = health + 10;
                            Console.WriteLine("It wasnt realy good, but the insect gives you alot of protein, good choice!");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Youre Health is on " + health + " !");
                            Console.WriteLine("type next and press enter enter");
                            Console.ReadLine();

                            goto next2;

                        }
                        else if (twochoice == "3")
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;

                            Console.WriteLine("Thas was dumb you have no more energie because you didnt eat");
                            Console.ForegroundColor = ConsoleColor.Blue;

                            Console.WriteLine("YOU DIED");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("LOADING......");
                            System.Threading.Thread.Sleep(5000);
                            Console.Clear();

                            goto Started;

                        }

                    next2:

                        Console.WriteLine("NEXT CHOICE LOADING......");
                        System.Threading.Thread.Sleep(2200);
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Its getting dark.");
                        Console.WriteLine("You are very tired and searching where you can sleep.");
                        Console.WriteLine("You find three possible places where to you stay ?");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("1: sleeping outside");
                        Console.WriteLine("2: in a cave");
                        Console.WriteLine("3: climb on a tree and sleep up there");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        threechoice = Console.ReadLine();

                        if (threechoice == "1")
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            health = health - 10;
                            Console.WriteLine("Youre were lucky that no dinosaur find you, but you couldt fully sleep right");
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Youre Health is on " + health + " !");

                            Console.WriteLine("type next and and press enter");
                            Console.ReadLine();

                            goto next4;


                        }
                        else if (threechoice == "2")
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            health = health + 10;
                            Console.WriteLine("It was warm and secured good choice, you slept really good!");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Youre Health is on " + health + " !");
                            Console.WriteLine("type next and press enter");
                            Console.ReadLine();

                            goto next4;

                        }






                    next4:

                        Console.WriteLine("NEXT CHOICE LOADING......");
                        System.Threading.Thread.Sleep(2200);
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("You wake up.");
                        Console.WriteLine("you want to go back home.");
                        Console.WriteLine("You have to find the time machine! where to you search ?");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("1: behind the hills");
                        Console.WriteLine("2: in the lake");
                        Console.WriteLine("3: in the sea");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        fourchoice = Console.ReadLine();

                        if (fourchoice == "1")
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            health = health + 5;
                            Console.WriteLine("You go to the hills and see.....");
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Youre Health is on " + health + " !");

                            Console.WriteLine("type next and and press enter");
                            Console.ReadLine();

                            goto minigame1;


                        }
                        else if (fourchoice == "2")
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            health = health + 10;
                            Console.WriteLine("You go to the lake its beatiful, you couldt resit and you go into the Water, but then you see....");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Youre Health is on " + health + " !");
                            Console.WriteLine("type next and press enter");
                            Console.ReadLine();

                            goto minigame1;

                        }
                        else if (fourchoice == "3")
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;

                            Console.WriteLine("You go to the sea and water dinosaurs attacked you, unlucky");
                            Console.ForegroundColor = ConsoleColor.Blue;

                            Console.WriteLine("YOU DIED");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("LOADING......");
                            System.Threading.Thread.Sleep(5000);
                            Console.Clear();

                            goto Started;




                        }

                    minigame1:

                        string inputPlayer, inputCPU, anser, ansser;
                        int randomInt;

                        bool playAgain = true;

                        Console.WriteLine("LOADING MINIGAME ONE AND POSSIBLE CHECKPOINT......");
                        System.Threading.Thread.Sleep(6000);
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("OH you found Mister XZ and he challenge you to a game against his Computer Console   ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Mister XZ:");

                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine(" OH Hi " + name + " are you good at Rock Paper Scisscors?      ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        anser = Console.ReadLine();

                        if (anser == "yes")
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Dou you think you can beat my CPU, and get 3 points before him ?   ");
                            Console.ForegroundColor = ConsoleColor.Red;
                            ansser = Console.ReadLine();

                            if (ansser == "yes")
                            {
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.WriteLine("Lets go\n\n");
                                Console.Clear();
                                playAgain = true;




                            }


                            else if (ansser == "no")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Learn to get better an then Comeback");
                                goto Started;

                            }


                        }
                        else if (anser == "no")
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("you are scared go Learn to get good an then Comeback you died because you were to scared haaaaaaaaaaaa!");
                            goto Started;


                        }




                    while (playAgain)
                    {

                    int scorePlayer = 0;
                    int scoreCPU = 0;


                    while (scorePlayer < 3 && scoreCPU < 3)
                    {

                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("Choose between Rock, Paper and Scissors:    ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        inputPlayer = Console.ReadLine();
                        inputPlayer = inputPlayer.ToUpper();

                        Random rnd = new Random();

                        randomInt = rnd.Next(1, 4);

                        switch (randomInt)
                        {
                            case 1:
                                inputCPU = "ROCK";
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("Console chose ROCK");
                                if (inputPlayer == "ROCK")
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("DRAW!!\n\n");
                                }
                                else if (inputPlayer == "PAPER")
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("PLAYER WINS!!\n\n");
                                    scorePlayer++;
                                }
                                else if (inputPlayer == "SCISSORS")
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("CONSOLE WINS!!\n\n");
                                    scoreCPU++;
                                }
                                break;
                            case 2:
                                inputCPU = "PAPER";
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("Computer chose PAPER");
                                if (inputPlayer == "PAPER")
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("DRAW!!\n\n");
                                }
                                else if (inputPlayer == "ROCK")
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("CPU WINS!!\n\n");
                                    scoreCPU++;
                                }
                                else if (inputPlayer == "SCISSORS")
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("PLAYER WINS!!\n\n");
                                    scorePlayer++;
                                }
                                break;
                            case 3:
                                inputCPU = "SCISSORS";
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("Computer chose SCISSORS");
                                if (inputPlayer == "SCISSORS")
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("DRAW!!\n\n");
                                }
                                else if (inputPlayer == "ROCK")
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("PLAYER WINS!!\n\n");
                                    scorePlayer++;
                                }
                                else if (inputPlayer == "PAPER")
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("CPU WINS!!\n\n");
                                    scoreCPU++;
                                }
                                break;
                            default:
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Invalid entry!");
                                break;
                        }

                        Console.WriteLine("\n\nSCORES:\tPLAYER:\t{0}\tCPU:\t{1}", scorePlayer, scoreCPU);

                    }

                    if (scorePlayer == 3)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Player WON!");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Mister XZ");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("You did it, you Beat me, i let you go and give you the time Machine and a checkpoint, have fun, type next and enter");
                        Console.ReadLine();
                        goto next5;

                    }
                    else if (scoreCPU == 3)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        health = health - 30;
                        Console.WriteLine("CPU WON!");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Mister XZ");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("You lost HAHAHAHAHAHAH but iam nice im giving you the time machine but i take away 30 Points");

                        Console.Clear();

                        goto next5;
                    }

                next5:
                playAgain = false;

                    Console.Clear();
                    Console.WriteLine("LOADING CHAPTER 2......");
                    System.Threading.Thread.Sleep(3000);
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("You Successfully gained a Checkpoint.");
                    Console.WriteLine("And you beat Mister XZ Console Very Good !!!!.");
                    Console.WriteLine("Know you have the time machine, unfortunaliety you cant go home because of a bug! So were are we going ? ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("1: Mars / Difficulty Level 2, if successfully completet +50 Health");
                    Console.WriteLine("2: Time of the Romans / Difficulty Level 1, if successfully completet 20 Health ");
                    Console.WriteLine("3: Middleage / Difficulty Level 3, if successfully completet +80 Health  ");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    fivechoice = Console.ReadLine();



                if (fivechoice == "1")
                {
                                Console.Clear();
                                Console.WriteLine("LOADING CHAPTER MARS......");
                                System.Threading.Thread.Sleep(2200);
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                health = health + 0;
                                Console.WriteLine("So you teleported on Mars");
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.WriteLine("Just quick, check ! youre Health is on " + health + " !");

                                Console.WriteLine("You are hearing some strange noises coming towards you what are you going [wait] or [hide]");
                                Console.ForegroundColor = ConsoleColor.Red;
                                choosemars = Console.ReadLine();


                                  

                if (fivechoice == "2")

                {
                            
                                    Console.Clear();
                                     Console.WriteLine("LOADING CHAPTER ROMANS......");
                                    System.Threading.Thread.Sleep(2200);
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    health = health + 0;
                                    Console.WriteLine("So you teleported to the Romans");
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Console.WriteLine("Just quick, check ! youre Health is on " + health + " !");

                                    Console.WriteLine("You are hearing some strange noises coming towards you what are you going [wait] or [hide]");
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    choosemars = Console.ReadLine();

                                    if (choosemars == "wait")
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Wait......");
                                        System.Threading.Thread.Sleep(2200);
                                        Console.Clear();
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        health = health + 0;
                                        Console.WriteLine("So you wait, the noise comes nearer");
                                        Console.WriteLine("Its the romans with theyre horses ");
                                        Console.WriteLine("They say you should take the Romans Number Quiz and if you do everything right, they will say weres the USB Stick for Downloading :Earth: on the time maching!");
                                        Console.ForegroundColor = ConsoleColor.Blue;
                                        Console.WriteLine("Youre health is on " + health + " !");

                                        Console.WriteLine("Type go if you are Ready to take the Romans Number Quiz");
                                        Console.ReadLine();





                                    }
                                    else if (choosemars == "hide")
                                    {
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        health = health - 20;
                                        Console.WriteLine("You hide, and a Roman kills you accidentally!!");
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Youre Health is on " + health + " !");
                                        Console.WriteLine("Luckely you got a Checkpoint");
                                        Console.WriteLine("type in [go to checkpoint]");

                                        Console.ReadLine();

                                        goto next5;

                                    }

                if (fivechoice == "3")
                {
                                Console.Clear();
                                        Console.WriteLine("LOADING CHAPTER MIDDLEAGE......");
                                        System.Threading.Thread.Sleep(2200);
                                        Console.Clear();
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        health = health + 0;
                                        Console.WriteLine("So you teleported to the Middleage");
                                        Console.ForegroundColor = ConsoleColor.Blue;
                                        Console.WriteLine("Just quick, check ! youre Health is on " + health + " !");

                                        Console.WriteLine("And you are hearing some strange noises coming towards you what are you going [wait] or [hide]");
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        choosemars = Console.ReadLine();

                                        if (choosemars == "wait")
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Wait......");
                                            System.Threading.Thread.Sleep(2200);
                                            Console.Clear();
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            health = health + 0;
                                            Console.WriteLine("So you wait, the noise comes nearer");
                                            Console.WriteLine("Its the the people from the Middleage with theyre horses ");
                                            Console.WriteLine("They say you should take the Middleage Quiz and if you do everything right, they will say weres the USB Stick for Downloading :Earth: on the time maching!");
                                            Console.ForegroundColor = ConsoleColor.Blue;
                                            Console.WriteLine("Youre health is on " + health + " !");

                                            Console.WriteLine("Type go if you are Ready to take the Middleage Quiz");
                                            Console.ReadLine();





                                        }
                                        else if (choosemars == "hide")
                                        {
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            health = health - 20;
                                            Console.WriteLine("You hide, and a boy from the Middle age kills you accidentally!!");
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("Youre Health is on " + health + " !");
                                            Console.WriteLine("Luckely you got a Checkpoint");
                                            Console.WriteLine("type in [go to checkpoint]");

                                            Console.ReadLine();

                                            goto next5;







                                        }
                                    }
                                }
                            }



















                        }
                    }
                }
            }
        }
    

    
