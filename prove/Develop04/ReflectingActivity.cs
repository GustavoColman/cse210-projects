using System;
using System.Threading;

class ReflectionActivity : MindfulnessActivity
{
    private string[] prompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private string[] reflectionQuestions = {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
    };

    public ReflectionActivity() : base("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
    }

    protected override void PerformActivity()
    {
        Random random = new Random();

        foreach (var prompt in prompts)
        {
            Console.WriteLine(prompt);
            Thread.Sleep(2000);
            foreach (var question in reflectionQuestions)
            {
                Console.WriteLine(question);
                Thread.Sleep(2000);
            }
        }

        base.PerformActivity();
    }
}