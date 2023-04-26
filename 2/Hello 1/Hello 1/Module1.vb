Option Explicit On
Module Module1
    Sub Main()
        Dim myname As String
        Console.Write("Enter Name :") : myname = Console.ReadLine()
        Console.ForegroundColor = ConsoleColor.Yellow
        Console.WriteLine("Hello {0}", myname)
        Console.ReadKey()
    End Sub
End Module