Module ModuleSBox

    ' Author: Halil Kemal TAŞKIN
    ' Web: http://hkt.me

#Region "DES S-Box Tanımlamaları"

    'DES S-Boxlarını array olarak tanımlıyoruz. (32x16 lık matrix, 0-based)
    Public DES(,) As Integer = { _
        {14, 4, 13, 1, 2, 15, 11, 8, 3, 10, 6, 12, 5, 9, 0, 7}, _
        {0, 15, 7, 4, 14, 2, 13, 1, 10, 6, 12, 11, 9, 5, 3, 8}, _
        {4, 1, 14, 8, 13, 6, 2, 11, 15, 12, 9, 7, 3, 10, 5, 0}, _
        {15, 12, 8, 2, 4, 9, 1, 7, 5, 11, 3, 14, 10, 0, 6, 13}, _
        {15, 1, 8, 14, 6, 11, 3, 4, 9, 7, 2, 13, 12, 0, 5, 10}, _
        {3, 13, 4, 7, 15, 2, 8, 14, 12, 0, 1, 10, 6, 9, 11, 5}, _
        {0, 14, 7, 11, 10, 4, 13, 1, 5, 8, 12, 6, 9, 3, 2, 15}, _
        {13, 8, 10, 1, 3, 15, 4, 2, 11, 6, 7, 12, 0, 5, 14, 9}, _
        {10, 0, 9, 14, 6, 3, 15, 5, 1, 13, 12, 7, 11, 4, 2, 8}, _
        {13, 7, 0, 9, 3, 4, 6, 10, 2, 8, 5, 14, 12, 11, 15, 1}, _
        {13, 6, 4, 9, 8, 15, 3, 0, 11, 1, 2, 12, 5, 10, 14, 7}, _
        {1, 10, 13, 0, 6, 9, 8, 7, 4, 15, 14, 3, 11, 5, 2, 12}, _
        {7, 13, 14, 3, 0, 6, 9, 10, 1, 2, 8, 5, 11, 12, 4, 15}, _
        {13, 8, 11, 5, 6, 15, 0, 3, 4, 7, 2, 12, 1, 10, 14, 9}, _
        {10, 6, 9, 0, 12, 11, 7, 13, 15, 1, 3, 14, 5, 2, 8, 4}, _
        {3, 15, 0, 6, 10, 1, 13, 8, 9, 4, 5, 11, 12, 7, 2, 14}, _
        {2, 12, 4, 1, 7, 10, 11, 6, 8, 5, 3, 15, 13, 0, 14, 9}, _
        {14, 11, 2, 12, 4, 7, 13, 1, 5, 0, 15, 10, 3, 9, 8, 6}, _
        {4, 2, 1, 11, 10, 13, 7, 8, 15, 9, 12, 5, 6, 3, 0, 14}, _
        {11, 8, 12, 7, 1, 14, 2, 13, 6, 15, 0, 9, 10, 4, 5, 3}, _
        {12, 1, 10, 15, 9, 2, 6, 8, 0, 13, 3, 4, 14, 7, 5, 11}, _
        {10, 15, 4, 2, 7, 12, 9, 5, 6, 1, 13, 14, 0, 11, 3, 8}, _
        {9, 14, 15, 5, 2, 8, 12, 3, 7, 0, 4, 10, 1, 13, 11, 6}, _
        {4, 3, 2, 12, 9, 5, 15, 10, 11, 14, 1, 7, 6, 0, 8, 13}, _
        {4, 11, 2, 14, 15, 0, 8, 13, 3, 12, 9, 7, 5, 10, 6, 1}, _
        {13, 0, 11, 7, 4, 9, 1, 10, 14, 3, 5, 12, 2, 15, 8, 6}, _
        {1, 4, 11, 13, 12, 3, 7, 14, 10, 15, 6, 8, 0, 5, 9, 2}, _
        {6, 11, 13, 8, 1, 4, 10, 7, 9, 5, 0, 15, 14, 2, 3, 12}, _
        {13, 2, 8, 4, 6, 15, 11, 1, 10, 9, 3, 14, 5, 0, 12, 7}, _
        {1, 15, 13, 8, 10, 3, 7, 4, 12, 5, 6, 11, 0, 14, 9, 2}, _
        {7, 11, 4, 1, 9, 12, 14, 2, 0, 6, 10, 13, 15, 3, 5, 8}, _
        {2, 1, 14, 7, 4, 10, 8, 13, 15, 12, 9, 0, 3, 5, 6, 11}}

#End Region

#Region "Serpent S-Box Tanımlamaları"

    'Serpent S-Boxlarını array olarak tanımlıyoruz. (8x16 lık matrix, 0-based)
    Public Serpent(,) As Integer = { _
        {3, 8, 15, 1, 10, 6, 5, 11, 14, 13, 4, 2, 7, 0, 9, 12}, _
        {15, 12, 2, 7, 9, 0, 5, 10, 1, 11, 14, 8, 6, 13, 3, 4}, _
        {8, 6, 7, 9, 3, 12, 10, 15, 13, 1, 14, 4, 0, 11, 5, 2}, _
        {0, 15, 11, 8, 12, 9, 6, 3, 13, 1, 2, 4, 10, 7, 5, 14}, _
        {1, 15, 8, 3, 12, 0, 11, 6, 2, 5, 4, 10, 9, 14, 7, 13}, _
        {15, 5, 2, 11, 4, 10, 9, 12, 0, 3, 14, 8, 13, 6, 7, 1}, _
        {7, 2, 12, 5, 8, 4, 6, 11, 14, 9, 1, 15, 13, 3, 10, 0}, _
        {1, 13, 15, 0, 14, 8, 2, 11, 7, 4, 12, 10, 9, 3, 5, 6}}

#End Region

#Region "TwoFish S-Box Tanımlamaları"

    'TwoFish S-Boxlarını array olarak tanımlıyoruz. (8x16 lık matrix, 0-based)
    Public TwoFish(,) As Integer = { _
        {8, 1, 7, 13, 6, 15, 3, 2, 0, 11, 5, 9, 14, 12, 10, 4}, _
        {14, 12, 11, 8, 1, 2, 3, 5, 15, 4, 10, 6, 7, 0, 9, 13}, _
        {11, 10, 5, 14, 6, 13, 9, 0, 12, 8, 15, 3, 2, 4, 7, 1}, _
        {13, 7, 15, 4, 1, 2, 6, 14, 9, 11, 3, 0, 8, 5, 12, 10}, _
        {2, 8, 11, 13, 15, 7, 6, 14, 3, 1, 9, 4, 0, 10, 12, 5}, _
        {1, 14, 2, 11, 4, 12, 3, 7, 6, 13, 10, 5, 15, 9, 0, 8}, _
        {4, 12, 7, 5, 1, 6, 9, 10, 0, 14, 13, 8, 2, 11, 3, 15}, _
        {11, 9, 5, 1, 12, 3, 13, 14, 6, 4, 7, 15, 2, 0, 8, 10}}

#End Region

#Region "XOR table hesaplama"

    Function XORt(ByVal SBoxValue() As Integer, ByVal i As Integer, ByVal j As Integer, ByVal Length As Integer) As Integer

        Dim SBoxOutput() As Integer = SBoxValue
        Dim CompLen As Integer = (2 ^ Length) - 1
        Dim k, XORvalue, IsJ, Count As Integer

        Dim iOrg(Length - 1), jOrg(Length - 1), jTemp(Length - 1) As Integer
        jOrg = Int2BinArray(i, Length)
        Count = 0

        For k = 0 To CompLen

            iOrg = Int2BinArray(k, Length)

            For m = 0 To Length - 1
                jTemp(m) = 0
            Next

            For m = 0 To Length - 1
                jTemp(m) = iOrg(m) Xor jOrg(m)
            Next

            XORvalue = BinArray2Int(jTemp)

            IsJ = SBoxOutput(k) Xor SBoxOutput(XORvalue)

            If IsJ = j Then Count = Count + 1


        Next

        Return Count
    End Function

    Function CreateXORtable(ByVal TempSbox() As Integer, ByVal SboxTitle As String, ByVal Length As Integer) As String
        'XOR tablasunun içeriğini temizle
        FormMain.DataGridView_XOR.Rows.Clear()
        FormMain.DataGridView_XOR.Columns.Clear()
        FormMain.DataGridView_XOR.TopLeftHeaderCell.Value = "XOR"

        Application.DoEvents()

        Dim Log As String = ""
        Dim MaxPoint As String = ""
        Dim RowNumber, CompLen As Integer
        CompLen = 2 ^ Length - 1

        '----------------------------------------------------
        'XOR tablosunu hesaplamaya başla
        '----------------------------------------------------

        FormMain.Label_Status.Text = "Computing XOR table..."
        Application.DoEvents()

        Dim XORMax As Integer = 0

        Log = Log & ControlChars.Quote & "XOR table for " & SboxTitle & " = "

        For i = 0 To CompLen
            Log = Log & TempSbox(i) & ","
        Next

        Log = Strings.Left(Log, Log.Length - 1) & ControlChars.Quote & vbCrLf

        'grid'e kolonları ekle
        For i = 0 To CompLen
            FormMain.DataGridView_XOR.Columns.Add(i, i)
            FormMain.DataGridView_XOR.Columns.Item(i).SortMode = DataGridViewColumnSortMode.NotSortable
        Next

        'Her bir row'u sırayla oluştur.
        For i = 0 To CompLen

            'Yeni bir row ekleyince fonksiyon oluşturduğu row'un index'ini veriyor.
            RowNumber = FormMain.DataGridView_XOR.Rows.Add()
            'Raw başlığı ekle
            FormMain.DataGridView_XOR.Rows.Item(RowNumber).HeaderCell.Value = i.ToString

            Dim TempLogPart As String = ""

            'Row'ların column'larını doldur.
            For j = 0 To CompLen

                Dim XORvalue As Integer = XORt(TempSbox, i, j, 4)
                TempLogPart = TempLogPart & XORvalue & ";"
                FormMain.DataGridView_XOR.Rows.Item(RowNumber).Cells(j).Value = XORvalue

                'En büyük noktayı bul
                If i <> 0 Then
                    If XORvalue > XORMax Then
                        XORMax = XORvalue
                        MaxPoint = "(" & i & "," & j & ")"
                        FormMain.DataGridView_XOR.CurrentCell = FormMain.DataGridView_XOR.Rows(i).Cells(j)
                    End If
                End If

            Next

            'kısmi log'u esasına ekle.
            Log = Log & Left(TempLogPart, TempLogPart.Length - 1) & vbCrLf
        Next

        '------------------
        'LAT Weight 1 input için max noktayı bul
        MaxPoint = "Max. Value: " & XORMax & " " & MaxPoint & " | Max. Value (Weight 1 Input): "

        Dim XORWT1Max, XORWt1Temp As Integer
        XORWT1Max = 0 : XORWt1Temp = 0
        Dim XORWT1Val As String = ""

        'Weight 1 rowlar için yap (1,2,4,8)
        For i = 0 To 3
            Dim exp As Integer = 2 ^ i

            'Her kolona bak
            For j = 0 To CompLen
                XORWt1Temp = FormMain.DataGridView_XOR.Rows.Item(exp).Cells(j).Value
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

        MaxPoint = MaxPoint & XORWT1Val

        '-------------------------

        Log = Log & ControlChars.Quote & MaxPoint & ControlChars.Quote & vbCrLf & vbCrLf
        FormMain.Label_XORMax.Text = MaxPoint

        Return Log

    End Function

#End Region

#Region "LAT hesaplama"

    Function LAT(ByVal SBoxValue() As Integer, ByVal i As Integer, ByVal j As Integer, ByVal Length As Integer) As Integer

        Dim SBoxOutput() As Integer = SBoxValue
        'Input(i) ve output(j) değerlerini array polynomial'a çevir
        Dim iBin() As Integer = Int2BinArray(i, Length)
        Dim jBin() As Integer = Int2BinArray(j, Length)

        Dim iTempArrayValue As Integer
        Dim jTempArrayValue As Integer

        Dim iLen As Integer = iBin.Length - 1
        Dim jLen As Integer = jBin.Length - 1

        'Toplan yapılacak işlem sayısını belirle
        Dim CompLen As Integer = (2 ^ Length) - 1

        'iBin ve  kullanılarak oluştutulacak 
        Dim iArray(CompLen), jArray(CompLen), Count, k, m As Integer

        Count = 0

        'iArray ve jArray oluşturuluyor ve eşitlikler sayılıyor.
        For k = 0 To CompLen
            iTempArrayValue = 0 : jTempArrayValue = 0
            For m = 0 To iLen
                'iArray'i oluştur.
                If iBin(m) = 1 Then iTempArrayValue = iTempArrayValue Xor Int2BinArray(k, iLen + 1)(m)
                'jArray'i oluştur.
                If jBin(m) = 1 Then jTempArrayValue = jTempArrayValue Xor Int2BinArray(SBoxOutput(k), jLen + 1)(m)
            Next

            ' iArray ve jArray kısmındaki eşitlikleri sayıyoruz.
            ' eşitlik varsa count'u bir artır.
            If iTempArrayValue = jTempArrayValue Then Count = Count + 1
        Next

        'En son -2^n-1 işlemini yap
        Count = Count - (2 ^ (Length - 1))

        'Yeni count değerini ver.
        Return Count
    End Function

    Function CreateLAT(ByVal TempSbox() As Integer, ByVal SboxTitle As String, ByVal Length As Integer) As String
        'LAT tablasunun içeriğini temizle
        FormMain.DataGridView_LAT.Rows.Clear()
        FormMain.DataGridView_LAT.Columns.Clear()
        FormMain.DataGridView_LAT.TopLeftHeaderCell.Value = "LAT"

        Application.DoEvents()

        Dim Log As String = ""
        Dim MaxPoint As String = ""
        Dim RowNumber, CompLen As Integer
        CompLen = 2 ^ Length - 1

        '----------------------------------------------------
        'LAT hesaplamaya başla
        '----------------------------------------------------

        FormMain.Label_Status.Text = "Computing LAT..."
        Application.DoEvents()

        Dim LatMax As Integer = 0

        Log = Log & ControlChars.Quote & "LAT for " & SboxTitle & " = "

        For i = 0 To CompLen
            Log = Log & TempSbox(i) & ","
        Next

        Log = Strings.Left(Log, Log.Length - 1) & ControlChars.Quote & vbCrLf


        'grid'e kolonları ekle
        For i = 0 To CompLen
            FormMain.DataGridView_LAT.Columns.Add(i, i)
            FormMain.DataGridView_LAT.Columns.Item(i).SortMode = DataGridViewColumnSortMode.NotSortable
        Next

        'Her bir row'u sırayla oluştur.
        For i = 0 To CompLen

            'Yeni bir row ekleyince fonksiyon oluşturduğu row'un index'ini veriyor.
            RowNumber = FormMain.DataGridView_LAT.Rows.Add()
            'Raw başlığı ekle
            FormMain.DataGridView_LAT.Rows.Item(RowNumber).HeaderCell.Value = i.ToString

            Dim TempLogPart As String = ""

            'Row'ların column'larını doldur.
            For j = 0 To CompLen

                Dim LATvalue As Integer = LAT(TempSbox, i, j, 4)
                TempLogPart = TempLogPart & LATvalue & ";"
                FormMain.DataGridView_LAT.Rows.Item(RowNumber).Cells(j).Value = LATvalue

                'En büyük noktayı bul
                If i <> 0 Then
                    If Math.Abs(LATvalue) > Math.Abs(LatMax) Then
                        LatMax = LATvalue
                        'MaxPoint = "at point (" & i & "," & j & ")"
                        MaxPoint = "(" & i & "," & j & ")"

                        FormMain.DataGridView_LAT.CurrentCell = FormMain.DataGridView_LAT.Rows(i).Cells(j)
                    End If
                End If

            Next

            'kısmi log'u esasına ekle.
            Log = Log & Left(TempLogPart, TempLogPart.Length - 1) & vbCrLf
        Next

        'LAT Weight 1 input için max noktayı bul
        MaxPoint = "Max. Value: " & LatMax & " " & MaxPoint & " | Max. Value (Weight 1 Input): "

        Dim LatWT1Max, LatWt1Temp As Integer
        LatWT1Max = 0 : LatWt1Temp = 0
        Dim LAtWT1Val As String = ""

        'Weight 1 rowlar için yap (1,2,4,8)
        For i = 0 To 3
            Dim exp As Integer = 2 ^ i

            'Her kolona bak
            For j = 0 To CompLen
                LatWt1Temp = FormMain.DataGridView_LAT.Rows.Item(exp).Cells(j).Value
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

        MaxPoint = MaxPoint & LAtWT1Val

        Log = Log & ControlChars.Quote & MaxPoint & ControlChars.Quote & vbCrLf & vbCrLf
        FormMain.Label_LATMax.Text = MaxPoint

        Return Log

    End Function

#End Region

#Region "Linear Combination of the Output Functions hesaplamaları"

    Function CreateLC(ByVal TempSbox() As Integer, ByVal SboxTitle As String, ByVal Length As Integer) As String
        'LAT tablasunun içeriğini temizle
        FormMain.DataGridView_LC.Rows.Clear()
        FormMain.DataGridView_LC.Columns.Clear()
        FormMain.DataGridView_LC.TopLeftHeaderCell.Value = "LCF"

        Application.DoEvents()

        Dim Log As String = ""
        Dim CompLen, RowNumber, SBoxOutputTT(Length - 1, (2 ^ Length) - 1), i, j, k As Integer
        CompLen = (2 ^ Length) - 1

        '----------------------------------------------------
        'LC hesaplamaya başla
        '----------------------------------------------------

        FormMain.Label_Status.Text = "Computing Linear Combinations of Output Functions..."
        Application.DoEvents()

        Log = Log & ControlChars.Quote & "Linear Combinations of Outputs of " & SboxTitle & " = "

        For i = 0 To CompLen
            Log = Log & TempSbox(i) & ","
        Next

        Log = Strings.Left(Log, Log.Length - 1) & ControlChars.Quote & vbCrLf

        Log = Log & "Linear Combining Function;" & _
        "Truth Table of the Output;" & _
        "Algebraic Normal Form;" & _
        "Degree;" & _
        "Walsh Spectrum;" & _
        "Nonlinearity;" & _
        "Bent;" & _
        "Weight;" & _
        "Balanced" & vbCrLf

        'grid'e kolonları ekle
        FormMain.DataGridView_LC.Columns.Add(0, "Linear Combining Function for the Outputs of S-Box")
        FormMain.DataGridView_LC.Columns.Add(1, "Truth Table of the new Output")
        FormMain.DataGridView_LC.Columns.Add(2, "Algebraic Normal Form (x1 is MSB)")
        FormMain.DataGridView_LC.Columns.Add(3, "Degree")
        FormMain.DataGridView_LC.Columns.Add(4, "Walsh Spectrum")
        FormMain.DataGridView_LC.Columns.Add(5, "Nonlinearity")
        FormMain.DataGridView_LC.Columns.Add(6, "Bent")
        FormMain.DataGridView_LC.Columns.Add(7, "Weight")
        FormMain.DataGridView_LC.Columns.Add(8, "Balanced")

        For i = 0 To 8
            FormMain.DataGridView_LC.Columns.Item(i).SortMode = DataGridViewColumnSortMode.NotSortable
        Next

        'S-Box'un her bir output'unu bir Truth Table'a çevir, her bir output için yap
        For i = 0 To TempSbox.Length - 1
            Dim TempArray(Length) As Integer

            TempArray = Int2BinArray(TempSbox(i), Length)

            'Her bir output'u oluştur.
            For j = 0 To Length - 1
                SBoxOutputTT(j, i) = TempArray(j)
            Next
        Next

        '--Dim Sort() As Integer = {0, 8, 4, 12, 2, 10, 6, 14, 1, 9, 5, 13, 3, 11, 7, 15}
        Dim Sort() As Integer = {0, 8, 4, 2, 1, 12, 10, 9, 6, 5, 3, 14, 13, 11, 7, 15}
        'Her bir row'u sırayla oluştur. Her row bir combining function.
        'o yüzden 0'ı almıyoruz, birden başlıyoruz.
        For i = 1 To CompLen  '1 Step -1

            'Yeni bir row ekleyince fonksiyon oluşturduğu row'un index'ini veriyor.
            RowNumber = FormMain.DataGridView_LC.Rows.Add()
            'Raw başlığı ekle
            FormMain.DataGridView_LC.Rows.Item(RowNumber).HeaderCell.Value = i.ToString  'Sort(i).ToString   'Str(CompLen + 1 - i)

            ' Combininf function'u oluştur.
            Dim TempPoly(), TempTT(CompLen), TempBit As Integer
            TempPoly = Int2BinArray(Sort(i), Length)

            ' output'un her bir bit'i için yap
            For j = 0 To CompLen

                TempBit = 0 ' xor'un etkisiz elemanı 0
                'Polinoma göre output'un her bitini xor'la
                For k = 0 To Length - 1

                    If TempPoly(k) = 1 Then
                        TempBit = TempBit Xor SBoxOutputTT(k, j)
                    End If

                Next

                TempTT(j) = TempBit

            Next

            Dim LCFLinFunc As String = WriteLinFunc(TempPoly, Length, "x")
            FormMain.DataGridView_LC.Rows.Item(RowNumber).Cells(0).Value = LCFLinFunc
            Log = Log & LCFLinFunc & ";"

            ' Truth Table 1
            Dim TTstr As String = ""
            For j = 0 To TempTT.Length - 1
                TTstr = TTstr & TempTT(j)
            Next
            FormMain.DataGridView_LC.Rows.Item(RowNumber).Cells(1).Value = TTstr
            Log = Log & "{" & TTstr & "};"


            Dim TempANF((2 ^ Length) - 1) As Integer
            TempANF = ButterflyAlgorithm(TempTT.Clone, Length).Clone

            ' ANF 2
            Dim LCFANF As String = WriteANF(TempANF.Clone, Length, "x")
            FormMain.DataGridView_LC.Rows.Item(RowNumber).Cells(2).Value = LCFANF
            Log = Log & LCFANF & ";"

            ' Degree 3
            Dim LCFDegree As String = Str(DegreeOfANF(TempANF.Clone, Length))
            FormMain.DataGridView_LC.Rows.Item(RowNumber).Cells(3).Value = LCFDegree
            Log = Log & LCFDegree & ";"

            Dim Walsh() As Integer
            Walsh = FastWalshTransform(TempTT.Clone, Length)

            ' Walsh 4
            Dim WalshSpec As String = ArrayToString(Walsh.Clone, ",")
            FormMain.DataGridView_LC.Rows.Item(RowNumber).Cells(4).Value = WalshSpec
            Log = Log & WalshSpec & ";"

            ' nonlinarity 5
            Dim MaxWalsh As Integer = 0
            For j = 0 To Walsh.Length - 1
                If Math.Abs(Walsh(j)) > MaxWalsh Then MaxWalsh = Math.Abs(Walsh(j))
            Next

            MaxWalsh = (2 ^ (Length - 1)) - (MaxWalsh / 2)

            FormMain.DataGridView_LC.Rows.Item(RowNumber).Cells(5).Value = MaxWalsh.ToString
            Log = Log & MaxWalsh.ToString & ";"

            ' bent 6
            Dim BentValue As Integer = (2 ^ (Length - 1)) - (2 ^ ((Length / 2) - 1))
            Dim Bent As String = ""
            If BentValue = MaxWalsh Then
                Bent = "True"
            Else
                Bent = "False"
            End If
            FormMain.DataGridView_LC.Rows.Item(RowNumber).Cells(6).Value = Bent
            Log = Log & Bent & ";"

            ' weight 7
            Dim Weight As Integer = 0
            For j = 0 To TempTT.Length - 1
                Weight = Weight + TempTT(j)
            Next
            FormMain.DataGridView_LC.Rows.Item(RowNumber).Cells(7).Value = Weight.ToString
            Log = Log & Weight.ToString & ";"

            ' balanced 8
            Dim Balanced As String = ""
            If Walsh(0) = 0 Then
                Balanced = "True"
            Else
                Balanced = "False"
            End If
            FormMain.DataGridView_LC.Rows.Item(RowNumber).Cells(8).Value = Balanced
            Log = Log & Balanced

            Log = Log & vbCrLf

        Next


        'min.deg max.degr min. nonli max nonli vs.

        Dim DegMin, DegMax, NLMin, NLMax, TempVal As Integer
        DegMin = 16 : DegMax = 0 : NLMin = 16 : NLMax = 0 : TempVal = 0

        ' her bir row için yap
        For j = 0 To CompLen - 1

            'degree 3
            TempVal = FormMain.DataGridView_LC.Rows.Item(j).Cells(3).Value
            If TempVal < DegMin Then DegMin = TempVal
            If TempVal > DegMax Then DegMax = TempVal

            ' nonlinearity 5
            TempVal = FormMain.DataGridView_LC.Rows.Item(j).Cells(5).Value

            If TempVal < NLMin Then NLMin = TempVal
            If TempVal > NLMax Then NLMax = TempVal

        Next

        Dim MinMax As String
        MinMax = "Minimum Degree: " & DegMin & " | Maximum Degree: " & DegMax & " | Minimum Nonlinearity: " & NLMin & " | Maximum Nonlinearity: " & NLMax

        Log = Log & ControlChars.Quote & MinMax & ControlChars.Quote & vbCrLf & vbCrLf

        FormMain.Label_LCFInfo.Text = MinMax

        Return Log
    End Function

#Region "Kullanılan Algoritmalar"

    Function ButterflyAlgorithm(ByVal TruthTable() As Integer, ByVal n As Integer) As Integer()


        Dim i, j, k, RepeatCoeff As Integer
        Dim Input((2 ^ n) - 1), Output((2 ^ n) - 1) As Integer
        Input = TruthTable
        Output = TruthTable

        'debug
        'TextBox1.Clear()

        'Repeat n times
        For i = 0 To n - 1

            RepeatCoeff = 2 ^ i

            'for every loop there are congruence classes of mod 2^(i+1). Repeat for every class.
            For j = 0 To (2 ^ (n - i - 1)) - 1

                ' in every class there are different elements, repeat for each element.
                ' It's a half complete congruence class
                For k = 0 To (2 ^ i) - 1

                    Dim m As Integer = ((2 ^ (i + 1)) * j) + k

                    Output(m) = Input(m)
                    Output(m + RepeatCoeff) = Input(m) Xor Input(m + RepeatCoeff)

                    'debug
                    'TextBox1.AppendText("i:" & i & " j:" & j & " k:" & k & " m:" & m & " a:" & m & " b:" & m + RepeatCoeff & vbCrLf)
                Next

            Next

            For j = 0 To Input.Length - 1
                Input(j) = Output(j)
            Next

            'debug
            'TextBox1.AppendText(vbCrLf)

        Next

        Return Output

    End Function

    Function FastWalshTransform(ByVal TruthTable() As Integer, ByVal n As Integer) As Integer()

        Dim i, j, k, RepeatCoeff As Integer
        Dim Input((2 ^ n) - 1), Output((2 ^ n) - 1) As Integer
        Input = TruthTable
        'Output = TruthTable
        For i = 0 To Output.Length - 1
            Output(i) = 0
        Next

        ' from (0,1) sequence to (1,-1) sequence
        For i = 0 To Input.Length - 1
            If Input(i) = 0 Then
                Input(i) = 1
            Else
                Input(i) = -1
            End If
        Next

        'debug
        'TextBox1.Clear()

        'Repeat n times
        For i = 0 To n - 1

            RepeatCoeff = 2 ^ i

            'for every loop there are congruence classes of mod 2^(i+1). Repeat for every class.
            For j = 0 To (2 ^ (n - i - 1)) - 1

                ' in every class there are different elements, repeat for each element.
                ' It's a half complete congruence class
                For k = 0 To (2 ^ i) - 1

                    Dim m As Integer = ((2 ^ (i + 1)) * j) + k

                    Output(m) = Input(m) + Input(m + RepeatCoeff)
                    Output(m + RepeatCoeff) = Input(m) - Input(m + RepeatCoeff)

                    'debug
                    'TextBox1.AppendText("i:" & i & " j:" & j & " k:" & k & " m:" & m & " a:" & m & " b:" & m + RepeatCoeff & vbCrLf)
                Next

            Next

            For j = 0 To Input.Length - 1
                Input(j) = Output(j)
            Next

            'debug
            'TextBox1.AppendText(vbCrLf)

        Next

        Return Output

    End Function

    Function WriteANF(ByVal Coefficient() As Integer, ByVal Length As Integer, ByVal x As String) As String

        'x1 is LSB

        Dim ANF As String = ""
        Dim Plus As String = " + "
        Dim i, j, CompLen As Integer
        CompLen = (2 ^ Length) - 1
        '--Dim SortDegree() As Integer = {0, 1, 2, 5, 3, 6, 7, 11, 4, 8, 9, 12, 10, 13, 14, 15}
        '--Dim SortDegree() As Integer = {0, 1, 2, 4, 8, 3, 5, 6, 9, 10, 12, 7, 11, 13, 14, 15}
        Dim SortDegree() As Integer = {0, 8, 4, 2, 1, 12, 10, 9, 6, 5, 3, 14, 13, 11, 7, 15}

        ' +1 kısmını özel ele al.
        If Coefficient(SortDegree(0)) = 1 Then ANF = ANF & "1" & Plus

        ' Diğer katsayıları ele al.
        For i = 1 To CompLen

            Dim Temp() As Integer

            ' Eğer bir katsayı aktifse
            If Coefficient(SortDegree(i)) = 1 Then

                'Katsayı değerini binary array yap ve arrayin her değeri bir x olacak.
                Temp = Int2BinArray(SortDegree(i), Length)

                For j = Length - 1 To 0 Step -1

                    If Temp(j) = 1 Then ANF = ANF & x & Length - j & "."

                Next

                ANF = Strings.Left(ANF, ANF.Length - 1)
                ANF = ANF + Plus

            End If

        Next

        If ANF.Length <> 0 Then ANF = Strings.Left(ANF, ANF.Length - Plus.Length)

        Return ANF

    End Function

    Function WriteLinFunc(ByVal Polynomial() As Integer, ByVal Length As Integer, ByVal x As String) As String
        Dim Output As String = ""

        For i = Length - 1 To 0 Step -1
            If Polynomial(i) = 1 Then
                Output = Output + x & Length - i & "+"
            End If
        Next

        Output = Left(Output, Output.Length - 1)

        Return Output
    End Function

    Function DegreeOfANF(ByVal Coefficient() As Integer, ByVal Length As Integer) As Integer

        Dim i, j, TempDegree, Degree, CompLen As Integer
        TempDegree = 0
        Degree = 0
        CompLen = (2 ^ Length) - 1

        ' +1 kısmını özel ele al.
        If Coefficient(0) = 1 Then Degree = 0

        ' Diğer katsayıları ele al.
        For i = 1 To CompLen

            Dim Temp() As Integer

            ' Eğer bir katsayı aktifse
            If Coefficient(i) = 1 Then

                'Katsayı değerini binary array yap ve arrayin her değeri bir x olacak.
                Temp = Int2BinArray(i, Length)
                TempDegree = 0

                For j = 0 To Length - 1

                    TempDegree = TempDegree + Temp(j)

                Next

                If TempDegree > Degree Then Degree = TempDegree

            End If
        Next

        Return Degree

    End Function

#End Region

#End Region

#Region "Diğer fonksiyonlar"

    Function Int2BinArray(ByVal IntData As Integer, ByVal BinaryOutputLength As Integer) As Integer()
        Dim TempData As Integer = IntData
        Dim BinData(BinaryOutputLength - 1) As Integer
        Dim i As Integer = 0

        Do Until TempData < 2
            BinData(i) = TempData Mod 2
            TempData = Math.Truncate(TempData / 2)
            i = i + 1
        Loop
        BinData(i) = TempData Mod 2

        Return BinData
    End Function

    Function BinArray2Int(ByVal BinaryArray() As Integer) As Integer
        Dim TempInt As Integer = 0
        For i = 0 To BinaryArray.Length - 1
            TempInt = TempInt + (2 ^ i) * BinaryArray(i)
        Next

        Return TempInt
    End Function

    Function ArrayToString(ByVal ArrayData() As Integer, ByVal Seperator As String) As String

        Dim Temp As String = ""

        For i = 0 To ArrayData.Length - 1
            Temp = Temp & ArrayData(i) & Seperator
        Next

        Temp = Left(Temp, Temp.Length - Seperator.Length)

        Return Temp

    End Function

    Function Int2Bin(ByVal IntData As Integer) As String
        Dim BinData As String = ""
        Dim TempData, TempBin As Decimal
        TempData = Val(IntData)
        Do Until TempData < 2
            TempBin = TempData Mod 2
            BinData = TempBin & BinData
            TempData = Math.Truncate(TempData / 2)
        Loop
        BinData = TempData & BinData

        Return BinData
    End Function

#End Region

#Region "Gereksizler"

    Public Sub Gereksizler()

        'Gereksiz yedek fonksiyonları vs. depolamak için sub :)

        ' Dim DES1() As Integer = {14, 4, 13, 1, 2, 15, 11, 8, 3, 10, 6, 12, 5, 9, 0, 7}
        ' Dim DES2() As Integer = {0, 15, 7, 4, 14, 2, 13, 1, 10, 6, 12, 11, 9, 5, 3, 8}
        ' Dim DES3() As Integer = {4, 1, 14, 8, 13, 6, 2, 11, 15, 12, 9, 7, 3, 10, 5, 0}
        ' Dim DES4() As Integer = {15, 12, 8, 2, 4, 9, 1, 7, 5, 11, 3, 14, 10, 0, 6, 13}
        ' Dim DES5() As Integer = {15, 1, 8, 14, 6, 11, 3, 4, 9, 7, 2, 13, 12, 0, 5, 10}
        ' Dim DES6() As Integer = {3, 13, 4, 7, 15, 2, 8, 14, 12, 0, 1, 10, 6, 9, 11, 5}
        ' Dim DES7() As Integer = {0, 14, 7, 11, 10, 4, 13, 1, 5, 8, 12, 6, 9, 3, 2, 15}
        ' Dim DES8() As Integer = {13, 8, 10, 1, 3, 15, 4, 2, 11, 6, 7, 12, 0, 5, 14, 9}
        ' Dim DES9() As Integer = {10, 0, 9, 14, 6, 3, 15, 5, 1, 13, 12, 7, 11, 4, 2, 8}
        ' Dim DES10() As Integer = {13, 7, 0, 9, 3, 4, 6, 10, 2, 8, 5, 14, 12, 11, 15, 1}
        ' Dim DES11() As Integer = {13, 6, 4, 9, 8, 15, 3, 0, 11, 1, 2, 12, 5, 10, 14, 7}
        ' Dim DES12() As Integer = {1, 10, 13, 0, 6, 9, 8, 7, 4, 15, 14, 3, 11, 5, 2, 12}
        ' Dim DES13() As Integer = {7, 13, 14, 3, 0, 6, 9, 10, 1, 2, 8, 5, 11, 12, 4, 15}
        ' Dim DES14() As Integer = {13, 8, 11, 5, 6, 15, 0, 3, 4, 7, 2, 12, 1, 10, 14, 9}
        ' Dim DES15() As Integer = {10, 6, 9, 0, 12, 11, 7, 13, 15, 1, 3, 14, 5, 2, 8, 4}
        ' Dim DES16() As Integer = {3, 15, 0, 6, 10, 1, 13, 8, 9, 4, 5, 11, 12, 7, 2, 14}
        ' Dim DES17() As Integer = {2, 12, 4, 1, 7, 10, 11, 6, 8, 5, 3, 15, 13, 0, 14, 9}
        ' Dim DES18() As Integer = {14, 11, 2, 12, 4, 7, 13, 1, 5, 0, 15, 10, 3, 9, 8, 6}
        ' Dim DES19() As Integer = {4, 2, 1, 11, 10, 13, 7, 8, 15, 9, 12, 5, 6, 3, 0, 14}
        ' Dim DES20() As Integer = {11, 8, 12, 7, 1, 14, 2, 13, 6, 15, 0, 9, 10, 4, 5, 3}
        ' Dim DES21() As Integer = {12, 1, 10, 15, 9, 2, 6, 8, 0, 13, 3, 4, 14, 7, 5, 11}
        ' Dim DES22() As Integer = {10, 15, 4, 2, 7, 12, 9, 5, 6, 1, 13, 14, 0, 11, 3, 8}
        ' Dim DES23() As Integer = {9, 14, 15, 5, 2, 8, 12, 3, 7, 0, 4, 10, 1, 13, 11, 6}
        ' Dim DES24() As Integer = {4, 3, 2, 12, 9, 5, 15, 10, 11, 14, 1, 7, 6, 0, 8, 13}
        ' Dim DES25() As Integer = {4, 11, 2, 14, 15, 0, 8, 13, 3, 12, 9, 7, 5, 10, 6, 1}
        ' Dim DES26() As Integer = {13, 0, 11, 7, 4, 9, 1, 10, 14, 3, 5, 12, 2, 15, 8, 6}
        ' Dim DES27() As Integer = {1, 4, 11, 13, 12, 3, 7, 14, 10, 15, 6, 8, 0, 5, 9, 2}
        ' Dim DES28() As Integer = {6, 11, 13, 8, 1, 4, 10, 7, 9, 5, 0, 15, 14, 2, 3, 12}
        ' Dim DES29() As Integer = {13, 2, 8, 4, 6, 15, 11, 1, 10, 9, 3, 14, 5, 0, 12, 7}
        ' Dim DES30() As Integer = {1, 15, 13, 8, 10, 3, 7, 4, 12, 5, 6, 11, 0, 14, 9, 2}
        ' Dim DES31() As Integer = {7, 11, 4, 1, 9, 12, 14, 2, 0, 6, 10, 13, 15, 3, 5, 8}
        ' Dim DES32() As Integer = {2, 1, 14, 7, 4, 10, 8, 13, 15, 12, 9, 0, 3, 5, 6, 11}


        ''-''Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_LAT.Click
        ''-''  'LAT tablasunun içeriğini temizle
        ''-''DataGridView_LAT.Rows.Clear()
        ''-''DataGridView_LAT.Columns.Clear()
        ''-''
        ''-'''XOR tablosunun içeriğini temizle
        ''-''DataGridView_XOR.Rows.Clear()
        ''-''DataGridView_XOR.Columns.Clear()
        ''-''
        ''-''Application.DoEvents()
        ''-''
        ''-''Dim Log As String = ""
        ''-''Dim MaxPoint As String = ""
        ''-''Dim TempSBox(15), RowNumber, CompLen As Integer
        ''-''Dim k As Integer = ComboBox_DES.SelectedIndex
        ''-''CompLen = 15
        ''-''
        ''-'''For k = 0 To 31
        ''-''
        ''-''For i = 0 To CompLen
        ''-''TempSBox(i) = DES(k, i)
        ''-''Next
        ''-''
        ''-'''----------------------------------------------------
        ''-'''LAT hesaplamaya başla
        ''-'''----------------------------------------------------
        ''-''
        ''-''Label_Status.Text = "Computing LAT..."
        ''-''Application.DoEvents()
        ''-''
        ''-''Dim LatMax As Integer = 0
        ''-''
        ''-''Log = Log & Now & ": LAT for DES S-Box(" & k + 1 & ") = "
        ''-''
        ''-''For i = 0 To CompLen
        ''-''Log = Log & TempSBox(i) & ","
        ''-''Next
        ''-''
        ''-''Log = Strings.Left(Log, Log.Length - 1) & vbCrLf
        ''-''
        ''-'''grid'e kolonları ekle
        ''-''For i = 0 To CompLen
        ''-''DataGridView_LAT.Columns.Add(i, i)
        ''-''Next
        ''-''
        ''-'''Her bir row'u sırayla oluştur.
        ''-''For i = 0 To CompLen
        ''-''
        ''-'''Yeni bir row ekleyince fonksiyon oluşturduğu row'un index'ini veriyor.
        ''-''RowNumber = DataGridView_LAT.Rows.Add()
        ''-'''Raw başlığı ekle
        ''-''DataGridView_LAT.Rows.Item(RowNumber).HeaderCell.Value = i.ToString
        ''-''
        ''-''Dim TempLogPart As String = ""
        ''-''
        ''-'''Row'ların column'larını doldur.
        ''-''For j = 0 To CompLen
        ''-''
        ''-''Dim LATvalue As Integer = LAT(TempSBox, i, j, 4)
        ''-''TempLogPart = TempLogPart & LATvalue & vbTab
        ''-''DataGridView_LAT.Rows.Item(RowNumber).Cells(j).Value = LATvalue
        ''-''
        ''-'''En büyük noktayı bul
        ''-''If i <> 0 Then
        ''-''If LATvalue > LatMax Then
        ''-''LatMax = LATvalue
        ''-''MaxPoint = " at point (" & i & "," & j & ")"
        ''-''End If
        ''-''End If
        ''-''
        ''-''Next
        ''-''
        ''-'''kısmi log'u esasına ekle.
        ''-''Log = Log & TempLogPart & vbCrLf
        ''-''Next
        ''-''
        ''-''MaxPoint = LatMax & " " & MaxPoint
        ''-''Log = Log & "Maximum Value: " & MaxPoint & vbCrLf & vbCrLf
        ''-''
        ''-'''Next
        ''-''
        ''-'''----------------------------------------------------
        ''-'''XOR tablosunu hesaplamaya başla
        ''-'''----------------------------------------------------
        ''-''
        ''-''Label_Status.Text = "Computing XOR table..."
        ''-''Application.DoEvents()
        ''-''
        ''-''Dim XORMax As Integer = 0
        ''-''
        ''-''Log = Log & Now & ": XOR table for DES S-Box(" & k + 1 & ") = "
        ''-''
        ''-''For i = 0 To CompLen
        ''-''Log = Log & TempSBox(i) & ","
        ''-''Next
        ''-''
        ''-''Log = Strings.Left(Log, Log.Length - 1) & vbCrLf
        ''-''
        ''-'''grid'e kolonları ekle
        ''-''For i = 0 To CompLen
        ''-''    DataGridView_XOR.Columns.Add(i, i)
        ''-''Next
        ''-''
        ''-'''Her bir row'u sırayla oluştur.
        ''-''For i = 0 To CompLen
        ''-''
        ''-''    'Yeni bir row ekleyince fonksiyon oluşturduğu row'un index'ini veriyor.
        ''-''    RowNumber = DataGridView_XOR.Rows.Add()
        ''-''    'Raw başlığı ekle
        ''-''DataGridView_XOR.Rows.Item(RowNumber).HeaderCell.Value = i.ToString
        ''-''
        ''-''Dim TempLogPart As String = ""
        ''-''
        ''-'''Row'ların column'larını doldur.
        ''-''For j = 0 To CompLen
        ''-''
        ''-''    Dim XORvalue As Integer = XORt(TempSBox, i, j, 4)
        ''-''TempLogPart = TempLogPart & XORvalue & vbTab
        ''-''DataGridView_XOR.Rows.Item(RowNumber).Cells(j).Value = XORvalue
        ''-''
        ''-'''En büyük noktayı bul
        ''-''If i <> 0 Then
        ''-''    If XORvalue > XORMax Then
        ''-''        XORMax = XORvalue
        ''-''        MaxPoint = " at point (" & i & "," & j & ")"
        ''-''    End If
        ''-''End If
        ''-''
        ''-''Next
        ''-''
        ''-'''kısmi log'u esasına ekle.
        ''-''Log = Log & TempLogPart & vbCrLf
        ''-''Next
        ''-''
        ''-''MaxPoint = XORMax & " " & MaxPoint
        ''-''Log = Log & "Maximum Value: " & MaxPoint & vbCrLf & vbCrLf
        ''-''
        ''-'''Next
        ''-''
        ''-''Label_Status.Text = "Ready"
        ''-''Application.DoEvents()
        ''-''
        ''-'''My.Computer.FileSystem.WriteAllText("c:\everything.txt", Log, False)

        '''''''Form Load kısmı
        'Dim c() As Integer
        'c = ButterflyAlgorithm(New Integer() {0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0}, 4)
        'MsgBox(WriteANF(c, 4, "x") & vbCrLf & DegreeOfANF(c, 4))

        'CreateLC(New Integer() {14, 4, 13, 1, 2, 15, 11, 8, 3, 10, 6, 12, 5, 9, 0, 7}, "", 4)

        'MsgBox(DegreeOfANF(New Integer() {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0}, 4))

        'Dim a() As Integer
        'a = FastWalshTransform(New Integer() {0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 1, 1, 1, 0}, 4)
        'MsgBox(a.ToString)

        'For i = 0 To c.Length - 1
        'If c(i) = 1 Then
        'msgBox(i & "-" & Int2Bin(i))
        'End If
        'Next
        'End

        'DES s-boxlarını listeleme testi
        'For i = 0 To 31
        'Dim a As String = ""
        'For j = 0 To 15
        'a = a & DES(i, j) & "-"
        'Next
        'MsgBox(a)
        'Next

        'fonksiyon testi
        'For i = 0 To 31
        'Dim b As String = ""
        'Dim BinL As Integer = 5
        'For j = 0 To BinL - 1
        'b = b & Int2Bin(i, BinL)(j) & ""
        'Next
        'MsgBox(b)
        'Next

        'fonksiyon testi
        'MsgBox(BinArray2Int(New Integer() {0, 1, 1, 1, 1, 0}))
        'End

        'Me.Width = 880
        'Me.Height = 506

        'Me.Width = 1024
        'Me.Height = 600

        'For i = 0 To 1000000
        'Randomize()
        'Dim SansliDES As Integer = CInt(Int(Rnd() * 32))
        'Dim Ayrac() As String = New String() {",", ".", " ", "-", "_", ";", ":"}
        'Dim AyracNo As Integer = CInt(Int(Rnd() * (Ayrac.Length)))
        'If (SansliDES = 32) Or (AyracNo = 7) Then MsgBox(SansliDES & "-" & AyracNo)
        'Application.DoEvents()
        'Next
        'MsgBox("bitti")
        'End

    End Sub

#End Region

End Module
