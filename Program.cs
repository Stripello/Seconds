using Seconds;

var amountOfSeconds = AskNumber.Ask();
if (amountOfSeconds == null)
{
    return;
}
uint secondsInMinute = 60;
uint secondsInHour = 60 * secondsInMinute;

var hoursLeft = amountOfSeconds / secondsInHour;
var minutesLeft = (amountOfSeconds - hoursLeft * secondsInHour) / secondsInMinute;
var secondsLeft = amountOfSeconds - hoursLeft * secondsInHour - minutesLeft * secondsInMinute;

Console.WriteLine($"{hoursLeft} hours from begin of the day.");
Console.WriteLine($"{minutesLeft} minutes from begin of the hour");
Console.WriteLine($"{secondsLeft} seconds from begin of the minute");