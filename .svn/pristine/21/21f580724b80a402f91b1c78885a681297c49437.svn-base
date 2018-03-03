Public Class GlobalFunctions


    Public Shared Sub SetLiquidusLine(ByVal level As Double)
        frmMain.ProfileChart.Series("Liquidus").Points.Clear()
        frmMain.ProfileChart.Series("Liquidus").Points.AddXY(0, level)
        frmMain.ProfileChart.Series("Liquidus").Points.AddXY(GlobalParameters.MaxTimePoints, level)
        ' Set the working liquidus level
        GlobalParameters.LiquidusTemp = level
    End Sub


    Public Shared Sub SetTCNames()
        Select Case GlobalParameters.OvenType
            Case "T-962"
                GlobalParameters.TC1Name = "Air(L)"
                GlobalParameters.TC2Name = "Air(R)"
                GlobalParameters.TC3Name = "Tray(L)"
                GlobalParameters.TC4Name = "Tray(R)"
            Case "T-962A"
                GlobalParameters.TC1Name = "Air(R)"
                GlobalParameters.TC2Name = "Air(F)"
                GlobalParameters.TC3Name = "Tray(1)"
                GlobalParameters.TC4Name = "Tray(2)"
        End Select
    End Sub


    ' The ExamineBit function will return True or False depending on the value of the 0 based, nth bit (MyBit)
    ' of an integer (MyByte).
    Public Shared Function ExamineBit(ByVal MyByte, ByVal MyBit) As Boolean
        MyBit = MyBit + 1      ' Convert 1 based to zero based
        Dim BitMask As Int16
        BitMask = 2 ^ (MyBit - 1)
        ExamineBit = ((MyByte And BitMask) > 0)
    End Function

    ' The SetBit Sub will set the 0 based, nth bit (MyBit) of an integer (MyByte).
    Public Shared Sub SetBit(ByRef MyByte, ByVal MyBit)
        MyBit = MyBit + 1       ' Convert 1 based to zero based
        Dim BitMask As Int16
        BitMask = 2 ^ (MyBit - 1)
        MyByte = MyByte Or BitMask
    End Sub

    ' The ClearBit Sub clears the 0 based, nth bit (MyBit) of an integer (MyByte).
    Public Shared Sub ClrBit(ByRef MyByte, ByVal MyBit)
        Dim BitMask As Int16
        MyBit = MyBit + 1       ' Convert 1 based to zero based
        ' Create a bitmask with the 2 to the nth power bit set:
        BitMask = 2 ^ (MyBit - 1)
        ' Clear the nth Bit:
        MyByte = MyByte And Not BitMask
    End Sub

    ' The ToggleBit Sub will change the state of the 0 based, nth bit (MyBit) of an integer (MyByte).
    Public Shared Sub ToggleBit(ByRef MyByte, ByVal MyBit)
        MyBit = MyBit + 1       ' Convert 1 based to zero based
        Dim BitMask As Int16
        BitMask = 2 ^ (MyBit - 1)
        MyByte = MyByte Xor BitMask
    End Sub

    ' Convert bytes to characters
    Public Shared Function ByteToHexChar(ByVal b As Byte) As String
        Dim strHexValue
        If (b < &H10) Then
            strHexValue = "0" & Hex(b)
        Else
            strHexValue = Hex(b)
        End If
        Return strHexValue
    End Function

    ' Convert Chars to bytes
    Public Shared Function ConvertHexStringToByte(ByVal s As String) As Byte
        Dim b As Byte
        Dim i As Integer
        Select Case s.Substring(0, 1)
            Case "0"
                i = i + 0
            Case "1"
                i = i + 1
            Case "2"
                i = i + 2
            Case "3"
                i = i + 3
            Case "4"
                i = i + 4
            Case "5"
                i = i + 5
            Case "6"
                i = i + 6
            Case "7"
                i = i + 7
            Case "8"
                i = i + 8
            Case "9"
                i = i + 9
            Case "A"
                i = i + 10
            Case "B"
                i = i + 11
            Case "C"
                i = i + 12
            Case "D"
                i = i + 13
            Case "E"
                i = i + 14
            Case "F"
                i = i + 15
            Case Else
                i = 0
        End Select

        i = i * 16

        Select Case s.Substring(1, 1)
            Case "0"
                i = i + 0
            Case "1"
                i = i + 1
            Case "2"
                i = i + 2
            Case "3"
                i = i + 3
            Case "4"
                i = i + 4
            Case "5"
                i = i + 5
            Case "6"
                i = i + 6
            Case "7"
                i = i + 7
            Case "8"
                i = i + 8
            Case "9"
                i = i + 9
            Case "A"
                i = i + 10
            Case "B"
                i = i + 11
            Case "C"
                i = i + 12
            Case "D"
                i = i + 13
            Case "E"
                i = i + 14
            Case "F"
                i = i + 15
            Case Else
                i = 0
        End Select

        b = Convert.ToByte(i)
        Return b
    End Function


    ' Convert a Character Array to a String
    Public Shared Function ConvertCharArrayToString(ByVal myArray() As Char, ByVal NumChars As Integer) As String
        Dim myString As New String(myArray)
        myString = myString.Substring(0, NumChars)
        Return myString
    End Function

End Class
