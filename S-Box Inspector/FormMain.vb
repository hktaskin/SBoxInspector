Public Class FormMain

    Public SBoxName As String = ""
    Public GeneralLog As String = ""

    Private Sub FormMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim i, j As Integer

        For i = 1 To 32
            ComboBox_DES.Items.Add("DES S-Box " & i)
        Next
        ComboBox_DES.SelectedIndex = 0

        For i = 0 To 7
            ComboBox_Serpent.Items.Add("Serpent S-Box " & i)
        Next
        ComboBox_Serpent.SelectedIndex = 0

        For i = 0 To 1
            For j = 0 To 3
                ComboBox_TwoFish.Items.Add("TwoFish S-Box " & ((2 * i) ^ 2) + j + 1 & " (q" & i & ",t" & j & ")")
            Next

        Next
        ComboBox_TwoFish.SelectedIndex = 0

        'TextBox_Info.Text = "Please select an encryption type and an S-Box..."
        Label_Status.Text = "Ready          Halil Kemal TAŞKIN, METU IAM"
        Label_LCFInfo.Text = ""
        Label_LATMax.Text = ""
        Label_XORMax.Text = ""
        TextBox_SpecialSBox.Clear()

    End Sub

    Private Sub FormMain_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        'Dim UstBosluk As Integer = 100

        'DataGridView_LAT.Location = New System.Drawing.Point(10, UstBosluk)
        'DataGridView_LAT.Size = New System.Drawing.Size((Me.Width / 2) - 30, Me.Height - UstBosluk - 60)
        'DataGridView_XOR.Location = New System.Drawing.Point(10 + DataGridView_LAT.Width + 10, UstBosluk)
        'DataGridView_XOR.Size = New System.Drawing.Size((Me.Width / 2) - 10, Me.Height - UstBosluk - 60)

        'Button_DES.Text = DataGridView_LAT.Height & "-" & DataGridView_LAT.Width

        'Me.Text = Me.Width & "-" & Me.Height
    End Sub

    Private Sub Button_Compute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Compute.Click

        Dim TempSBox(15), i, j As Integer
        Dim InputSize As Integer = 4
        Dim CompLen As Integer = (2 ^ InputSize) - 1


        If RadioButton_DES.Checked Then

            For i = 0 To CompLen
                TempSBox(i) = DES(ComboBox_DES.SelectedIndex, i)
            Next
            SBoxName = ComboBox_DES.SelectedItem

        ElseIf RadioButton_Serpent.Checked Then

            For i = 0 To CompLen
                TempSBox(i) = Serpent(ComboBox_Serpent.SelectedIndex, i)
            Next
            SBoxName = ComboBox_Serpent.SelectedItem


        ElseIf RadioButton_TwoFish.Checked Then

            For i = 0 To CompLen
                TempSBox(i) = TwoFish(ComboBox_TwoFish.SelectedIndex, i)
            Next
            SBoxName = ComboBox_TwoFish.SelectedItem


        ElseIf RadioButton_Special.Checked Then

            Dim Values(15) As String
            Dim OrgText As String = TextBox_SpecialSBox.Text
            Dim TempChar As String = ""
            Dim Elements(15) As Integer

            If Not IsNumeric(Mid(TextBox_SpecialSBox.Text, 1, 1)) Then
                MsgBox("Text must start with a numeric character.", MsgBoxStyle.Exclamation, Me.Text)
                Exit Sub
            End If

            i = 1 : j = 0
            While i < OrgText.Length + 1

                TempChar = Mid(OrgText, i, 1)
                If IsNumeric(TempChar) Then
                    If j > 15 Then
                        MsgBox("There are more then 16 elements in the text." & vbCrLf & "Only first 16 elements are processed.", MsgBoxStyle.Exclamation, Me.Text)
                        Exit While
                    End If
                    Values(j) = Values(j) & TempChar
                Else
                    While (Not IsNumeric(TempChar)) And (i < OrgText.Length + 1)
                        i = i + 1
                        TempChar = Mid(OrgText, i, 1)
                    End While
                    j = j + 1
                    GoTo devam
                End If
                i = i + 1
devam:
            End While

            For i = 0 To Elements.Length - 1
                Elements(i) = Val(Values(i)) Mod 16
            Next

            If MsgBox("Recognized S-Box is {" & ArrayToString(Elements, ",") & "}" & vbCrLf & "Is it correct?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.No Then
                MsgBox("Please write more carefully and try again.", MsgBoxStyle.Exclamation, Me.Text)
                Exit Sub
            End If

            TempSBox = Elements
            SBoxName = "Special S-Box"

        Else
            Exit Sub
        End If

        GeneralLog = ""
        GeneralLog = GeneralLog & CreateLC(TempSBox, SBoxName, InputSize)
        GeneralLog = GeneralLog & CreateLAT(TempSBox, SBoxName, InputSize)
        GeneralLog = GeneralLog & CreateXORtable(TempSBox, SBoxName, InputSize)
        GeneralLog = GeneralLog & "Created with " & Me.Text

        Label_Status.Text = "Ready, Last computed: " & SBoxName & " {" & ArrayToString(TempSBox, ",") & "}"
        Button_Save.Enabled = True

    End Sub

    Private Sub Button_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Save.Click

        If MsgBox("This process will save computed informations for the selected S-Box." & vbCrLf & "You can use file formats TXT or CSV. Do you want to continue?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, Me.Text) = MsgBoxResult.No Then Exit Sub

        SaveFileDialog1.FileName = "Information for " & SBoxName
        'SaveFileDialog1.DefaultExt = "csv"
        SaveFileDialog1.Filter = "Comma-separated values (CSV) Files (*.csv)|*.csv|Text Files (*.txt)|*.txt|All Files (*.*)|*.*"

        'SaveFileDialog1.InitialDirectory = My.Application.Info.DirectoryPath
        SaveFileDialog1.Title = "Please select a file to save the current data."

        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.Cancel Then Exit Sub

        Select Case SaveFileDialog1.FilterIndex
            Case 1
                SaveFileDialog1.DefaultExt = "csv"
            Case 2
                SaveFileDialog1.DefaultExt = "txt"
        End Select
        SaveFileDialog1.AddExtension = True
        My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, GeneralLog, False)

        MsgBox("File has been saved successfully.", MsgBoxStyle.Information, Me.Text)

    End Sub

    Private Sub Button_All_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_All.Click

        If MsgBox("This process will try to generate a table which consists informations for all S-Boxes of DES, Serpent and TwoFish." & vbCrLf & "It may take time, please be patient. Do you want to continue?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, Me.Text) = MsgBoxResult.No Then Exit Sub

        ' Kaydedilecek dosyayı belirle

        SaveFileDialog1.FileName = "Table for all S-Boxes"
        'SaveFileDialog1.DefaultExt = "csv"
        SaveFileDialog1.Filter = "Comma-separated values (CSV) Files (*.csv)|*.csv|Text Files (*.txt)|*.txt|All Files (*.*)|*.*"

        'SaveFileDialog1.InitialDirectory = My.Application.Info.DirectoryPath
        SaveFileDialog1.Title = "Please select a file to save the data."

        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.Cancel Then Exit Sub

        Select Case SaveFileDialog1.FilterIndex
            Case 1
                SaveFileDialog1.DefaultExt = "csv"
            Case 2
                SaveFileDialog1.DefaultExt = "txt"
        End Select
        SaveFileDialog1.AddExtension = True

        'Tanımlamalar
        Dim TempSBox(15), i, k As Integer
        Dim InputSize As Integer = 4
        Dim CompLen As Integer = (2 ^ InputSize) - 1

        GeneralLog = ";LAT;;XOR;;Linear Combination of the Output Functions" & vbCrLf & ";Max. Value;Max. Value (wt1);Max. Value;Max Value (wt1);Min. Degree;Max. Degree;Min. NL;Max NL" & vbCrLf

        ' DES
        For k = 0 To 31

            For i = 0 To CompLen
                TempSBox(i) = DES(k, i)
            Next
            SBoxName = ComboBox_DES.Items.Item(k).ToString
            GeneralLog = GeneralLog & WriteAll(TempSBox.Clone, InputSize)

        Next

        ' Serpent
        For k = 0 To 7

            For i = 0 To CompLen
                TempSBox(i) = Serpent(k, i)
            Next
            SBoxName = ComboBox_Serpent.Items.Item(k).ToString
            GeneralLog = GeneralLog & WriteAll(TempSBox.Clone, InputSize)

        Next

        ' TwoFish
        For k = 0 To 7

            For i = 0 To CompLen
                TempSBox(i) = TwoFish(k, i)
            Next
            SBoxName = ComboBox_TwoFish.Items.Item(k).ToString
            GeneralLog = GeneralLog & WriteAll(TempSBox.Clone, InputSize)

        Next

        GeneralLog = GeneralLog & vbCrLf & ControlChars.Quote & "Created with " & Me.Text & ControlChars.Quote

        My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, GeneralLog, False)

        MsgBox("All data has been generated and saved successfully.", MsgBoxStyle.Information, Me.Text)

    End Sub

    Function WriteAll(ByVal TempSbox() As Integer, ByVal InputSize As Integer) As String
        Dim DESinfo As String = ""

        Dim CompLen As Integer = (2 ^ InputSize) - 1
        DESinfo = DESinfo & SBoxName & ";"

        'Tablo bilgilerini hazırla

        Dim MaxPoint As String = ""

        'LAT--------------------------------------------------------------

        Dim LatMax As Integer = 0
        'grid'e kolonları ekle
        Dim LAT_Grid(15, 15) As Integer

        'Her bir row'u sırayla oluştur.
        For i = 0 To CompLen

            'Row'ların column'larını hesapla.
            For j = 0 To CompLen

                Dim LATvalue As Integer = LAT(TempSbox, i, j, 4)

                'Aslında gerekli değil ama sadece wt1 lere bakmak için hesaplıyoruz.
                LAT_Grid(i, j) = LATvalue

                'En büyük noktayı bul

                If i <> 0 Then
                    If Math.Abs(LATvalue) > Math.Abs(LatMax) Then
                        LatMax = LATvalue
                        MaxPoint = LatMax & " (" & i & "," & j & ")"
                    End If
                End If

            Next

        Next

        'LAT Weight 1 input için max noktayı bul
        Dim LatWT1Max, LatWt1Temp As Integer
        LatWT1Max = 0 : LatWt1Temp = 0
        Dim LAtWT1Val As String = ""

        'Weight 1 rowlar için yap (1,2,4,8)
        For i = 0 To 3
            Dim exp As Integer = 2 ^ i

            'Her kolona bak
            For j = 0 To CompLen
                LatWt1Temp = LAT_Grid(exp, j)
                'En büyük noktayı bul
                If exp <> 0 Then
                    If Math.Abs(LatWt1Temp) > Math.Abs(LatWT1Max) Then
                        LatWT1Max = LatWt1Temp
                        'MaxPoint = "at point (" & i & "," & j & ")"
                        LAtWT1Val = LatWT1Max & " (" & exp & "," & j & ")"
                    End If
                End If
            Next
        Next

        DESinfo = DESinfo & MaxPoint & ";" & LAtWT1Val & ";"

        'XOR--------------------------------------------------------------

        Dim XORMax As Integer = 0

        'grid'e kolonları ekle
        Dim XOR_Grid(15, 15) As Integer

        'Her bir row'u sırayla oluştur.
        For i = 0 To CompLen

            'Row'ların column'larını doldur.
            For j = 0 To CompLen

                Dim XORvalue As Integer = XORt(TempSbox, i, j, 4)

                'Aslında gerekli değil ama sadece wt1 lere bakmak için hesaplıyoruz.
                XOR_Grid(i, j) = XORvalue

                'En büyük noktayı bul
                If i <> 0 Then
                    If XORvalue > XORMax Then
                        XORMax = XORvalue
                        MaxPoint = XORMax & " (" & i & "," & j & ")"
                    End If
                End If

            Next

        Next

        '------------------
        'XOR Weight 1 input için max noktayı bul

        Dim XORWT1Max, XORWt1Temp As Integer
        XORWT1Max = 0 : XORWt1Temp = 0
        Dim XORWT1Val As String = ""

        'Weight 1 rowlar için yap (1,2,4,8)
        For i = 0 To 3
            Dim exp As Integer = 2 ^ i

            'Her kolona bak
            For j = 0 To CompLen
                XORWt1Temp = XOR_Grid(exp, j)
                'En büyük noktayı bul
                If exp <> 0 Then
                    If Math.Abs(XORWt1Temp) > Math.Abs(XORWT1Max) Then
                        XORWT1Max = XORWt1Temp
                        'MaxPoint = "at point (" & i & "," & j & ")"
                        XORWT1Val = XORWT1Max & " (" & exp & "," & j & ")"
                    End If
                End If
            Next
        Next

        DESinfo = DESinfo & MaxPoint & ";" & XORWT1Val & ";"

        'LCF---------------------------------------------------------------
        Dim SBoxOutputTT(InputSize - 1, (2 ^ InputSize) - 1), m As Integer

        'S-Box'un her bir output'unu bir Truth Table'a çevir, her bir output için yap
        For i = 0 To TempSbox.Length - 1
            Dim TempArray(InputSize) As Integer

            TempArray = Int2BinArray(TempSbox(i), InputSize)

            'Her bir output'u oluştur.
            For j = 0 To InputSize - 1
                SBoxOutputTT(j, i) = TempArray(j)
            Next
        Next

        Dim Sort() As Integer = {0, 8, 4, 2, 1, 12, 10, 9, 6, 5, 3, 14, 13, 11, 7, 15}
        Dim Degree(15), NL(15) As Integer
        'Her bir row'u sırayla oluştur. Her row bir combining function.
        'o yüzden 0'ı almıyoruz, birden başlıyoruz.
        For i = 1 To CompLen  '1 Step -1

            ' Combininf function'u oluştur.
            Dim TempPoly(), TempTT(CompLen), TempBit As Integer
            TempPoly = Int2BinArray(Sort(i), InputSize)

            ' output'un her bir bit'i için yap
            For j = 0 To CompLen

                TempBit = 0 ' xor'un etkisiz elemanı 0
                'Polinoma göre output'un her bitini xor'la
                For m = 0 To InputSize - 1

                    If TempPoly(m) = 1 Then
                        TempBit = TempBit Xor SBoxOutputTT(m, j)
                    End If

                Next

                TempTT(j) = TempBit

            Next

            Dim TempANF((2 ^ InputSize) - 1) As Integer
            TempANF = ButterflyAlgorithm(TempTT.Clone, InputSize).Clone

            ' Degree 3
            Degree(i) = DegreeOfANF(TempANF.Clone, InputSize)

            Dim Walsh() As Integer
            Walsh = FastWalshTransform(TempTT.Clone, InputSize)

            ' nonlinarity 5
            Dim MaxWalsh As Integer = 0
            For j = 0 To Walsh.Length - 1
                If Math.Abs(Walsh(j)) > MaxWalsh Then MaxWalsh = Math.Abs(Walsh(j))
            Next

            NL(i) = (2 ^ (InputSize - 1)) - (MaxWalsh / 2)

        Next


        'min.deg max.degr min. nonli max nonli vs.

        Dim DegMin, DegMax, NLMin, NLMax, TempVal As Integer
        DegMin = 16 : DegMax = 0 : NLMin = 16 : NLMax = 0 : TempVal = 0

        ' her bir row için yap
        For j = 1 To CompLen

            'degree 3
            TempVal = Degree(j)
            If TempVal < DegMin Then DegMin = TempVal
            If TempVal > DegMax Then DegMax = TempVal

        Next
        For j = 1 To CompLen

            ' nonlinearity 5
            TempVal = NL(j)

            If TempVal < NLMin Then NLMin = TempVal
            If TempVal > NLMax Then NLMax = TempVal

        Next

        DESinfo = DESinfo & DegMin & ";" & DegMax & ";" & NLMin & ";" & NLMax

        '------------------------------------------------------------------

        DESinfo = DESinfo & vbCrLf
        Return DESinfo
    End Function

    Private Sub RadioButton_DES_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton_DES.CheckedChanged

        If RadioButton_DES.Checked Then
            ComboBox_DES.Enabled = True
            ComboBox_Serpent.Enabled = False
            ComboBox_TwoFish.Enabled = False
            TextBox_SpecialSBox.Enabled = False
        End If

    End Sub

    Private Sub RadioButton_Serpent_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton_Serpent.CheckedChanged

        If RadioButton_Serpent.Checked Then
            ComboBox_DES.Enabled = False
            ComboBox_Serpent.Enabled = True
            ComboBox_TwoFish.Enabled = False
            TextBox_SpecialSBox.Enabled = False
        End If

    End Sub

    Private Sub RadioButton_TwoFish_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton_TwoFish.CheckedChanged

        If RadioButton_TwoFish.Checked Then
            ComboBox_DES.Enabled = False
            ComboBox_Serpent.Enabled = False
            ComboBox_TwoFish.Enabled = True
            TextBox_SpecialSBox.Enabled = False
        End If

    End Sub

    Private Sub RadioButton_Special_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton_Special.CheckedChanged

        On Error Resume Next

        If RadioButton_Special.Checked Then
            ComboBox_DES.Enabled = False
            ComboBox_Serpent.Enabled = False
            ComboBox_TwoFish.Enabled = False
            TextBox_SpecialSBox.Enabled = True
            'TextBox_Info.Text = "Please write an S-Box..."
            Randomize()
            Dim SansliDES As Integer = CInt(Int(Rnd() * 32))
            Dim ShowSBOX(15) As Integer
            For i = 0 To 15
                ShowSBOX(i) = DES(SansliDES, i)
            Next

            Dim Ayrac() As String = New String() {",", ".", " ", "-", "_", ";", ":"}
            Dim AyracNo As Integer = CInt(Int(Rnd() * (Ayrac.Length)))

            MsgBox("Only 4x4 S-Boxes are allowed. Input format is decimal." & vbCrLf & "Please use non-numerical characters to seperate S-Box elements (comma, point, space etc.)." & vbCrLf & "An Example Input: " & ArrayToString(ShowSBOX, Ayrac(AyracNo)), MsgBoxStyle.Information, Me.Text)
        End If

    End Sub

    ' Aktif değil
    Private Sub ComboBox_DES_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox_DES.SelectedIndexChanged
        'Dim TempSBox(15) As Integer
        '
        'For i = 0 To 15
        'TempSBox(i) = DES(ComboBox_DES.SelectedIndex, i)
        'Next
        '
        'TextBox_Info.Text = "Selected: " & ComboBox_DES.SelectedItem & " {" & ArrayToString(TempSBox, ",") & "}"

    End Sub

    Private Sub ComboBox_Serpent_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox_Serpent.SelectedIndexChanged
        'Dim TempSBox(15) As Integer
        '
        'For i = 0 To 15
        '    TempSBox(i) = Serpent(ComboBox_Serpent.SelectedIndex, i)
        'Next
        '
        ''TextBox_Info.Text = "Selected: " & ComboBox_Serpent.SelectedItem & " {" & ArrayToString(TempSBox, ",") & "}"

    End Sub

    Private Sub ComboBox_TwoFish_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox_TwoFish.SelectedIndexChanged
        'Dim TempSBox(15) As Integer
        '
        'For i = 0 To 15
        '    TempSBox(i) = TwoFish(ComboBox_TwoFish.SelectedIndex, i)
        'Next
        '
        ''TextBox_Info.Text = "Selected: " & ComboBox_TwoFish.SelectedItem & " {" & ArrayToString(TempSBox, ",") & "}"

    End Sub

    'Private Sub Button_Magic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    'If MsgBox("This process will try to compute informations for all S-Boxes of DES, Serpent and TwoFish." & vbCrLf & "It may take time, please be patient. Do you want to continue?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, Me.Text) = MsgBoxResult.No Then Exit Sub
    'End Sub

End Class