Imports System.Xml.Schema

Module binary
    'Logan Handley
    '12/07/23
    'binary-decimal converter
    Sub main()
        Dim input As String
        Do
            Console.Write("Enter b to convert to binary (base 2), d to convert to base 10, q to quit -> ")
            input = Console.ReadLine().ToUpper
            If input = "B" Then
                Console.WriteLine()
                dtb()
            ElseIf input = "D" Then
                Console.WriteLine()
                btd()
            ElseIf input = "Q" Then
                Console.WriteLine()
                Console.WriteLine("Come again soon!")
            Else
                Console.WriteLine("That's... That's not an option. What does that even mean?" & vbNewLine)
            End If
        Loop While input <> "Q"


        Console.ReadKey()
    End Sub
    Sub dtb()
        Dim str As String
        Dim input As String
        Dim valid As Boolean
        Dim num As Integer
        Dim binstr As String = ""
        Console.WriteLine("Decimal to binary it is!")
        Console.Write("Please enter the number you want to convert to binary -> ")
        input = Console.ReadLine()
        valid = Integer.TryParse(input, num)
        If valid = True Then
            Do
                str = num Mod 2
                binstr = str & binstr
                num = Math.Floor(num / 2)
            Loop While num > 0
            Console.WriteLine($"{input} converted to binary is {binstr}." & vbNewLine)
        Else
            Console.WriteLine("That's not a number, silly!")
        End If
    End Sub
    Sub btd()
        Dim total As Integer
        Dim input As String
        Dim num As String
        Dim decstr As String = ""
        Console.WriteLine("Alright, binary to decimal we go!")
        Console.Write("Please enter the binary you want to convert to a decimal -> ")
        input = Console.ReadLine()
        isValidBinary(input)
        If isValidBinary(input) = True Then
            num = StrReverse(input)
            For i As Integer = 0 To num.Length - 1
                Dim bit As Integer
                Integer.TryParse(num(i), bit)
                total += bit * 2 ^ i
            Next
            Console.WriteLine($"{input} converted to decimal is {total}." & vbNewLine)
        Else
            Console.WriteLine("That's not binary, silly!" & vbNewLine)
        End If
    End Sub
    ''' <summary>
    ''' accepts a string and checks it to make sure it contains only 1s and 0s.
    ''' </summary>
    ''' <param name="str"></param>
    ''' <returns></returns>
    Function isValidBinary(str As String) As Boolean
        Dim valid As Boolean = True
        For i As Integer = 0 To str.Length - 1
            If str(i) <> "0" AndAlso str(i) <> "1" Then
                valid = False
            End If
        Next
        Return valid
    End Function
End Module
