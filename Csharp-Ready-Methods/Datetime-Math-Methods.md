# Datetime & Math Methods

```csharp
    DateTime dob = new DateTime(1974, 7, 10, 7, 10, 24);  
    Console.WriteLine("Day:{0}", dob.Day);  
    Console.WriteLine("Month:{0}", dob.Month);  
    Console.WriteLine("Year:{0}", dob.Year);  
    Console.WriteLine("Hour:{0}", dob.Hour);  
    Console.WriteLine("Minute:{0}", dob.Minute);  
    Console.WriteLine("Second:{0}", dob.Second);  
    Console.WriteLine("Millisecond:{0}", dob.Millisecond);  
    
    Console.WriteLine("Day of Week:{0}", dob.DayOfWeek);  
    Console.WriteLine("Day of Year: {0}", dob.DayOfYear);  
    Console.WriteLine("Time of Day:{0}", dob.TimeOfDay);  
    Console.WriteLine("Tick:{0}", dob.Ticks);  
    Console.WriteLine("Kind:{0}", dob.Kind);

    DateTime aDay = DateTime.Now;  
    TimeSpan aMonth = new System.TimeSpan(30, 0, 0, 0);  
    DateTime aDayAfterAMonth = aDay.Add(aMonth);  
    DateTime aDayBeforeAMonth = aDay.Subtract(aMonth);  
    Console.WriteLine("{0:dddd}", aDayAfterAMonth);  
    Console.WriteLine("{0:dddd}", aDayBeforeAMonth);   

    // Add Years and Days  
    aDay.AddYears(2);            
    aDay.AddDays(12);  
    // Add Hours, Minutes, Seconds, Milliseconds, and Ticks  
    aDay.AddHours(4.25);  
    aDay.AddMinutes(15);  
    aDay.AddSeconds(45);             
    aDay.AddMilliseconds(200);  
    aDay.AddTicks(5000);  

    DateTime dob = new DateTime(2000, 10, 20, 12, 15, 45);  
    DateTime subDate = new DateTime(2000, 2, 6, 13, 5, 15);  
    
    // TimeSpan with 10 days, 2 hrs, 30 mins, 45 seconds, and 100 milliseconds  
    TimeSpan ts = new TimeSpan(10, 2, 30, 45, 100);  
    
    // Subtract a DateTime  
    TimeSpan diff1 = dob.Subtract(subDate);  
    Console.WriteLine(diff1.ToString());  
    
    // Subtract a TimeSpan  
    DateTime diff2 = dob.Subtract(ts);  
    Console.WriteLine(diff2.ToString());  
    
    // Subtract 10 Days  
    DateTime daysSubtracted = new DateTime(dob.Year, dob.Month, dob.Day - 10);  
    Console.WriteLine(daysSubtracted.ToString());  
    
    // Subtract hours, minutes, and seconds  
    DateTime hms = new DateTime(dob.Year, dob.Month, dob.Day, dob.Hour - 1, dob.Minute - 15, dob.Second - 15);  
    Console.WriteLine(hms.ToString()); 

    DateTime firstDate = new DateTime(2002, 10, 22);  
    DateTime secondDate = new DateTime(2009, 8, 11);  
    int result = DateTime.Compare(firstDate, secondDate);  
    
    if (result < 0)  
        Console.WriteLine("First date is earlier");  
    else if (result == 0)  
        Console.WriteLine("Both dates are same");  
    else  
        Console.WriteLine("First date is later");   

    DateTime firstDate = new DateTime(2002, 10, 22);  
    DateTime secondDate = new DateTime(2009, 8, 11);  
    int compareResult = firstDate.CompareTo(secondDate);  
    if (compareResult < 0)  
        Console.WriteLine("First date is earlier");  
    else if (compareResult == 0)  
        Console.WriteLine("Both dates are same");  
    else  
        Console.WriteLine("First date is later");
     
```