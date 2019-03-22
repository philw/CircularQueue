Public Class CircularQueue

    Private Const MAX_SIZE = 3
    Private items(MAX_SIZE - 1) As String
    Private head As Integer = 0
    Private tail As Integer = -1
    Private size As Integer = 0

    Public Function Enqueue(newItem As String) As Boolean

        If size < MAX_SIZE Then
            tail = (tail + 1) Mod MAX_SIZE
            items(tail) = newItem
            size += 1
            Return True
        Else
            Console.WriteLine("ERROR: Queue is full")
            Return False
        End If

    End Function

    Public Function Dequeue() As String

        Dim item As String = ""

        If size > 0 Then
            item = items(head)
            head = (head + 1) Mod MAX_SIZE
            size -= 1
        Else
            Console.WriteLine("ERROR: Queue is empty")
        End If
        Return item

    End Function



End Class
