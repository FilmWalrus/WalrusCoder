Imports System.IO

Module Globals

#Region " Global Variables"

    '--ASCII and alphabet handling
    Public Const AlphaDiff As Integer = 97
    Public Const NumeralDiff As Integer = 48
    Public Const CapDiff As Integer = 65
    Public Const AlphaCapDiff As Integer = AlphaDiff - CapDiff
    Public Const AlphaNumeralDiff As Integer = AlphaDiff - NumeralDiff
    Public Const AlphaCount As Integer = 26
    Public Const NumeralCount As Integer = 10
    Public Const AlphaNumeralCount As Integer = 36
    Public Const MaxBinarySize As Integer = 5
    Public Const MaxGridValue As Integer = 5

    '--Cryptanalysis
    Public TheCryptoLabels(AlphaCount) As Label
    Public TheCryptoTexts(AlphaCount) As TextBox

    '--Options
    Public AlwaysRemove As Boolean = False
    Public AlwaysSub As Boolean = False
    Public AlwaysConvertNumbers As Boolean = False
    Public AlwaysRoute As Boolean = True
    Public Verbose As Boolean = True
    Public ShowCryptanalysis As Boolean = True
    Public LetterToRemove As Char = "j"c
    Public PathStyle As Integer = PathVertical
    Public SpacingDistance As Integer = 0
    Public PunctuationType As Integer = LeavePunct
    Public InitialCode As String = "Single Sub"
    Public InitialText As String = ""
    Public InitialKey As String = "default"
    Public InitialSeed As Integer = 0

    '--Punctuation Styles
    Public Const LeavePunct = 0
    Public Const ShortPunct = 1
    Public Const LongPunct = 2

    '--Pad Styles
    Enum PADSTYLES
        AlphaRandom = 0
        AlphaFrequency = 1
        ZeroesOnly = 2
        SpacesOnly = 3
        NumericRandom = 4
    End Enum


    '--Path Categories
    Public PathRaster As Boolean = True
    Public PathDiagonal As Boolean = True
    Public PathSpiral As Boolean = True
    Public PathZigzag As Boolean = True
    Public PathArch As Boolean = True
    Public PathInverse As Boolean = True
    Public PathSwirl As Boolean = True
    Public PathKnight As Boolean = True
    Public PathVertical As Integer = MAYBE
    Public PathReverse As Integer = MAYBE
    Public PathSwapPairs As Integer = MAYBE
    Public PathCheckerboard As Integer = MAYBE

    '--Path Values
    Public Const RasterInt = 0
    Public Const DiagonalInt = 1
    Public Const SpiralInt = 2
    Public Const ZigzagInt = 3
    Public Const ArchInt = 4
    Public Const InverseInt = 5
    Public Const SwirlInt = 6
    Public Const KnightInt = 7

    '--Key types for Tabula Recta
    Enum KEYTYPES
        Autokey = 0
        Repeat = 1
        Progressive = 2
    End Enum

    '--Questions
    Public Const NO = 0
    Public Const YES = 1
    Public Const MAYBE = 2

    '--Test Strings
    Public TestString1 As String = ""
    Public TestString2 As String = ""

#End Region

#Region " Global Functions "

    Function GetRandom(ByVal Min As Integer, ByVal Max As Integer) As Integer
        'Randomize(Date.Now.Millisecond)
        Max += 1
        Dim TheResult As Integer = Int(Min + (Rnd() * (Max - Min)))
        Return TheResult
    End Function

    Function SafeDivide(ByVal A As Double, ByVal B As Double) As Double
        If A = 0 Or B = 0 Then
            Return 0
        Else
            Return A / B
        End If
    End Function

    Public Sub SaveOptions()
        Dim FileString As String
        Dim Parser As New Parser
        FileString = Parser.AddSlash(Application.StartupPath) & "WalrusCipherOptions.wcp"
        Dim fi As New FileInfo(FileString)
        If fi.Exists Then
            fi.Delete()
        End If
        '-- Open File
        Dim sw As StreamWriter = New StreamWriter(FileString)
        '-- Record
        sw.Write(AlwaysRemove.ToString & ControlChars.Lf)
        sw.Write(AlwaysSub.ToString & ControlChars.Lf)
        sw.Write(AlwaysConvertNumbers.ToString & ControlChars.Lf)
        sw.Write(Verbose.ToString & ControlChars.Lf)
        sw.Write(ShowCryptanalysis.ToString & ControlChars.Lf)
        sw.Write(LetterToRemove & ControlChars.Lf)
        sw.Write(SpacingDistance.ToString & ControlChars.Lf)
        sw.Write(PunctuationType.ToString & ControlChars.Lf)
        'Routes
        sw.Write(AlwaysRoute.ToString & ControlChars.Lf)
        sw.Write(PathRaster.ToString & ControlChars.Lf)
        sw.Write(PathZigzag.ToString & ControlChars.Lf)
        sw.Write(PathDiagonal.ToString & ControlChars.Lf)
        sw.Write(PathSpiral.ToString & ControlChars.Lf)
        sw.Write(PathSwirl.ToString & ControlChars.Lf)
        sw.Write(PathArch.ToString & ControlChars.Lf)
        sw.Write(PathInverse.ToString & ControlChars.Lf)
        sw.Write(PathKnight.ToString & ControlChars.Lf)
        sw.Write(PathVertical.ToString & ControlChars.Lf)
        sw.Write(PathReverse.ToString & ControlChars.Lf)
        sw.Write(PathCheckerboard.ToString & ControlChars.Lf)
        sw.Write(PathSwapPairs.ToString & ControlChars.Lf)
        'Save data on screen
        sw.Write(InitialCode.ToString & ControlChars.Lf)
        sw.Write(InitialKey.ToString & ControlChars.Lf)
        sw.Write(InitialSeed.ToString & ControlChars.Lf)
        sw.Write(InitialText.ToString & ControlChars.Lf)
        '-- Close File
        sw.Close()
        'MsgBox("Options info saved successfully.", , "Options Save")

    End Sub

    Public Sub LoadOptions()
        Dim FileString As String
        Dim Parser As New Parser
        FileString = Parser.AddSlash(Application.StartupPath) & "WalrusCipherOptions.wcp"
        Try
            Dim fi As New FileInfo(FileString)
            If fi.Exists Then
                ' Create an instance of StreamReader to read from a file.
                Dim sr As StreamReader = New StreamReader(FileString)
                '-- Read
                AlwaysRemove = sr.ReadLine
                AlwaysSub = sr.ReadLine
                AlwaysConvertNumbers = sr.ReadLine
                Verbose = sr.ReadLine
                ShowCryptanalysis = sr.ReadLine
                LetterToRemove = sr.ReadLine
                SpacingDistance = sr.ReadLine
                PunctuationType = sr.ReadLine
                'Routes
                AlwaysRoute = sr.ReadLine
                PathRaster = sr.ReadLine
                PathZigzag = sr.ReadLine
                PathDiagonal = sr.ReadLine
                PathSpiral = sr.ReadLine
                PathSwirl = sr.ReadLine
                PathArch = sr.ReadLine
                PathInverse = sr.ReadLine
                PathKnight = sr.ReadLine
                PathVertical = sr.ReadLine
                PathReverse = sr.ReadLine
                PathCheckerboard = sr.ReadLine
                PathSwapPairs = sr.ReadLine
                'Initial screen setup
                InitialCode = sr.ReadLine
                InitialKey = sr.ReadLine
                InitialSeed = sr.ReadLine
                InitialText = sr.ReadToEnd
                '-- Close File
                sr.Close()
            End If
        Catch Ex As Exception
            MsgBox("Couldn't read file.", , "Load Error")
        End Try

    End Sub

#End Region

End Module
