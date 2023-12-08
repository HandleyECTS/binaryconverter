Module Module1
    'write a program that prompts the user to enter b to convert a decimal number to binary and
    'd to convert a binary number to a decimal, q to quit
    'b d and q in any case should be supported
    'if the user chooses to convert to binary, make sure a valid integer is given
    'do not try to convert words
    'if invalid input is given, report the error and prompt again
    '{decimal num} converted to decimal is : {binary str}
    'if the user chooses to convert to decimal from binary, make sure the string given
    'contains only 0s and 1s. if it contains anything else, report the error and prompt again
    'when a valid string is given print out the conversion as
    '{binary str} converted to decimal is : {decimal num}
    'do not have any subs or functions with more than 25 lines
    Sub Main()
        Dim input As String
        Do
            Dim valid As Boolean
            Dim num As Integer
            Console.Write("Please enter a number, and I'll tell you if it's even or odd! Input Q to quit -> ")
            input = Console.ReadLine()
            valid = Integer.TryParse(input, num)

            If valid Then
                'determine if the num is even or odd
                If num Mod 2 = 0 Then
                    Console.WriteLine("It's even!")
                Else
                    Console.WriteLine("That's odd.")
                End If
            ElseIf input.ToUpper = "Q" Then
                Console.WriteLine("Come again soon!")
            Else
                Console.WriteLine("That's not a number, silly!")
            End If
        Loop While Input.toUpper() <> "Q"
        Console.WriteLine()
        StringWalkin("hola")

        Console.ReadKey()
    End Sub

    Sub StringWalkin(somestr As String)
        'assumes the string is at least 3 characters long
        Console.WriteLine($"Original String -> {somestr}")
        Console.WriteLine($"The first character in the string -> {somestr(0)}")
        Console.WriteLine($"The second character in the string -> {somestr(1)}")
        Console.WriteLine($"The third character in the string -> {somestr(2)}")

        For i As Integer = 0 To somestr.Length - 1
            Console.WriteLine(somestr(i))
        Next


    End Sub
End Module
