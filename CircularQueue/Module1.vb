Module Module1

    Sub Main()

        Dim queue As New CircularQueue
        Dim UserInput As String
        Dim item As String

        Do
            Console.WriteLine("    Enqueue")
            Console.WriteLine("    Dequeue")
            Console.WriteLine("    eXit")
            Console.Write("Enter letter: ")
            UserInput = Console.ReadLine.ToUpper

            Select Case UserInput
                Case "E"
                    Console.Write("Enter string: ")
                    item = Console.ReadLine.Trim
                    If item <> "" Then
                        If queue.Enqueue(item) Then
                            Console.WriteLine("{0} added to the queue", item)
                        End If
                    End If
                Case "D"
                    item = queue.Dequeue()
                    If item <> "" Then
                        Console.WriteLine("Taken {0} off the head of the queue", item)
                    End If
            End Select



        Loop Until UserInput = "X"




    End Sub

End Module
