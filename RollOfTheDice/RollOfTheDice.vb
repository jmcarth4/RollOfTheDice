'Jessica McArthur
'RCET0265
'Spring 2020
'Roll of the Dice
'https://github.com/jmcarth4/RollOfTheDice

Option Explicit On
Option Strict On

Module RollOfTheDice
    Dim arrayLength As Integer = 13
    Dim temp As String

    Sub Main()
        Dim randomNumbers(12) As Integer
        Dim currentNumber As Integer
        Dim seperator As String = " |"
        Dim columnLength As Integer = 6
        Dim lineSeperator As String = "-"
        Dim lineLength As Integer = columnLength * (UBound(randomNumbers) - 1)

        'count random numbers of range of two dice. (2 to 12)
        For i = 1 To 1000
            currentNumber = RandomNumberInRange()
            randomNumbers(currentNumber) += 1
        Next

        'display Random number count(s)
        'header
        For i = LBound(randomNumbers) + 2 To UBound(randomNumbers)
            temp = CStr(i) & seperator
            temp = temp.PadLeft(columnLength)
            Console.Write(temp)
        Next
        Console.WriteLine()

        'separator
        Console.WriteLine(StrDup(lineLength, lineSeperator))

        'display contents of randomNumbers() array
        For i = LBound(randomNumbers) + 2 To UBound(randomNumbers)
            temp = CStr(randomNumbers(i)) & seperator
            temp = temp.PadLeft(columnLength)
            Console.Write(temp)
        Next
        Console.WriteLine()

        'separator
        Console.WriteLine(StrDup(lineLength, lineSeperator))

        'show display
        Console.ReadLine()
    End Sub

    ' Function GetRandomInteger() As Integer
    Function RandomNumberInRange(Optional max% = 10%, Optional min% = 0%) As Integer
        Dim _max% = max - min
        If _max < 0 Then
            Throw New System.ArgumentException("Maximum number must be greater than minimum number")
        End If
        Randomize(DateTime.Now.Millisecond)
        Return CInt(System.Math.Floor(Rnd() * (_max + 1))) + min
    End Function

End Module
