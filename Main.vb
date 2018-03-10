Imports System.IO

Public Class WalrusCoder
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents txtInitial As System.Windows.Forms.TextBox
    Friend WithEvents ubEncode As System.Windows.Forms.Button
    Friend WithEvents txtEncode As System.Windows.Forms.TextBox
    Friend WithEvents txtDecode As System.Windows.Forms.TextBox
    Friend WithEvents ubDecode As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbSystem As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtKey As System.Windows.Forms.TextBox
    Friend WithEvents ubInfo As System.Windows.Forms.Button
    Friend WithEvents numSeed As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents gbCrypto As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ubOptions As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblEndings As System.Windows.Forms.Label
    Friend WithEvents lblBigrams As System.Windows.Forms.Label
    Friend WithEvents ubRecipher As System.Windows.Forms.Button
    Friend WithEvents ubRedecipher As System.Windows.Forms.Button
    Friend WithEvents lblIC As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WalrusCoder))
        Me.txtInitial = New System.Windows.Forms.TextBox()
        Me.txtEncode = New System.Windows.Forms.TextBox()
        Me.ubEncode = New System.Windows.Forms.Button()
        Me.ubDecode = New System.Windows.Forms.Button()
        Me.txtDecode = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbSystem = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtKey = New System.Windows.Forms.TextBox()
        Me.numSeed = New System.Windows.Forms.NumericUpDown()
        Me.ubInfo = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.gbCrypto = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblBigrams = New System.Windows.Forms.Label()
        Me.lblEndings = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblIC = New System.Windows.Forms.Label()
        Me.ubOptions = New System.Windows.Forms.Button()
        Me.ubRecipher = New System.Windows.Forms.Button()
        Me.ubRedecipher = New System.Windows.Forms.Button()
        CType(Me.numSeed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbCrypto.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtInitial
        '
        Me.txtInitial.AcceptsReturn = True
        Me.txtInitial.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtInitial.Location = New System.Drawing.Point(16, 24)
        Me.txtInitial.Multiline = True
        Me.txtInitial.Name = "txtInitial"
        Me.txtInitial.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtInitial.Size = New System.Drawing.Size(528, 152)
        Me.txtInitial.TabIndex = 0
        '
        'txtEncode
        '
        Me.txtEncode.AcceptsReturn = True
        Me.txtEncode.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtEncode.Location = New System.Drawing.Point(16, 200)
        Me.txtEncode.Multiline = True
        Me.txtEncode.Name = "txtEncode"
        Me.txtEncode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtEncode.Size = New System.Drawing.Size(528, 152)
        Me.txtEncode.TabIndex = 1
        '
        'ubEncode
        '
        Me.ubEncode.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ubEncode.BackColor = System.Drawing.Color.Navy
        Me.ubEncode.ForeColor = System.Drawing.Color.White
        Me.ubEncode.Location = New System.Drawing.Point(472, 544)
        Me.ubEncode.Name = "ubEncode"
        Me.ubEncode.Size = New System.Drawing.Size(72, 24)
        Me.ubEncode.TabIndex = 2
        Me.ubEncode.Text = "Encode"
        Me.ubEncode.UseVisualStyleBackColor = False
        '
        'ubDecode
        '
        Me.ubDecode.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ubDecode.BackColor = System.Drawing.Color.Navy
        Me.ubDecode.ForeColor = System.Drawing.Color.White
        Me.ubDecode.Location = New System.Drawing.Point(472, 584)
        Me.ubDecode.Name = "ubDecode"
        Me.ubDecode.Size = New System.Drawing.Size(72, 24)
        Me.ubDecode.TabIndex = 3
        Me.ubDecode.Text = "Decode"
        Me.ubDecode.UseVisualStyleBackColor = False
        '
        'txtDecode
        '
        Me.txtDecode.AcceptsReturn = True
        Me.txtDecode.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtDecode.Location = New System.Drawing.Point(16, 376)
        Me.txtDecode.Multiline = True
        Me.txtDecode.Name = "txtDecode"
        Me.txtDecode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDecode.Size = New System.Drawing.Size(528, 152)
        Me.txtDecode.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Input"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(16, 184)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Encrypted Output"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(16, 360)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Decrypted Output"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.Location = New System.Drawing.Point(152, 536)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Cipher"
        '
        'cbSystem
        '
        Me.cbSystem.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cbSystem.Location = New System.Drawing.Point(152, 552)
        Me.cbSystem.Name = "cbSystem"
        Me.cbSystem.Size = New System.Drawing.Size(152, 21)
        Me.cbSystem.Sorted = True
        Me.cbSystem.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.Location = New System.Drawing.Point(320, 536)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 16)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Seed"
        '
        'txtKey
        '
        Me.txtKey.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtKey.Location = New System.Drawing.Point(152, 592)
        Me.txtKey.Name = "txtKey"
        Me.txtKey.Size = New System.Drawing.Size(248, 20)
        Me.txtKey.TabIndex = 10
        Me.txtKey.Text = "default"
        '
        'numSeed
        '
        Me.numSeed.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.numSeed.Location = New System.Drawing.Point(320, 552)
        Me.numSeed.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
        Me.numSeed.Name = "numSeed"
        Me.numSeed.Size = New System.Drawing.Size(80, 20)
        Me.numSeed.TabIndex = 12
        '
        'ubInfo
        '
        Me.ubInfo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ubInfo.BackColor = System.Drawing.Color.Navy
        Me.ubInfo.ForeColor = System.Drawing.Color.White
        Me.ubInfo.Location = New System.Drawing.Point(16, 544)
        Me.ubInfo.Name = "ubInfo"
        Me.ubInfo.Size = New System.Drawing.Size(72, 24)
        Me.ubInfo.TabIndex = 13
        Me.ubInfo.Text = "Info"
        Me.ubInfo.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label6.Location = New System.Drawing.Point(152, 576)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 16)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Key"
        '
        'gbCrypto
        '
        Me.gbCrypto.Controls.Add(Me.Label9)
        Me.gbCrypto.Controls.Add(Me.lblBigrams)
        Me.gbCrypto.Controls.Add(Me.lblEndings)
        Me.gbCrypto.Controls.Add(Me.Label8)
        Me.gbCrypto.Controls.Add(Me.Label7)
        Me.gbCrypto.Controls.Add(Me.lblIC)
        Me.gbCrypto.Location = New System.Drawing.Point(560, 16)
        Me.gbCrypto.Name = "gbCrypto"
        Me.gbCrypto.Size = New System.Drawing.Size(272, 592)
        Me.gbCrypto.TabIndex = 15
        Me.gbCrypto.TabStop = False
        Me.gbCrypto.Text = "Cryptanalysis"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(8, 360)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(128, 16)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Most Common Bigrams"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBigrams
        '
        Me.lblBigrams.Location = New System.Drawing.Point(8, 376)
        Me.lblBigrams.Name = "lblBigrams"
        Me.lblBigrams.Size = New System.Drawing.Size(256, 48)
        Me.lblBigrams.TabIndex = 11
        '
        'lblEndings
        '
        Me.lblEndings.Location = New System.Drawing.Point(8, 344)
        Me.lblEndings.Name = "lblEndings"
        Me.lblEndings.Size = New System.Drawing.Size(256, 24)
        Me.lblEndings.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(8, 328)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(128, 16)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Most Common Endings"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(56, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(152, 16)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Letter Frequencies"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblIC
        '
        Me.lblIC.Location = New System.Drawing.Point(8, 432)
        Me.lblIC.Name = "lblIC"
        Me.lblIC.Size = New System.Drawing.Size(248, 16)
        Me.lblIC.TabIndex = 20
        Me.lblIC.Text = "Index of Coincidence: "
        '
        'ubOptions
        '
        Me.ubOptions.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ubOptions.BackColor = System.Drawing.Color.Navy
        Me.ubOptions.ForeColor = System.Drawing.Color.White
        Me.ubOptions.Location = New System.Drawing.Point(16, 584)
        Me.ubOptions.Name = "ubOptions"
        Me.ubOptions.Size = New System.Drawing.Size(72, 24)
        Me.ubOptions.TabIndex = 16
        Me.ubOptions.Text = "Options"
        Me.ubOptions.UseVisualStyleBackColor = False
        '
        'ubRecipher
        '
        Me.ubRecipher.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ubRecipher.Location = New System.Drawing.Point(256, 176)
        Me.ubRecipher.Name = "ubRecipher"
        Me.ubRecipher.Size = New System.Drawing.Size(32, 24)
        Me.ubRecipher.TabIndex = 18
        Me.ubRecipher.Text = "^"
        '
        'ubRedecipher
        '
        Me.ubRedecipher.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ubRedecipher.Location = New System.Drawing.Point(256, 352)
        Me.ubRedecipher.Name = "ubRedecipher"
        Me.ubRedecipher.Size = New System.Drawing.Size(32, 24)
        Me.ubRedecipher.TabIndex = 19
        Me.ubRedecipher.Text = "^"
        '
        'WalrusCoder
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(848, 622)
        Me.Controls.Add(Me.ubRedecipher)
        Me.Controls.Add(Me.ubRecipher)
        Me.Controls.Add(Me.gbCrypto)
        Me.Controls.Add(Me.ubOptions)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ubInfo)
        Me.Controls.Add(Me.numSeed)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtKey)
        Me.Controls.Add(Me.cbSystem)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDecode)
        Me.Controls.Add(Me.ubDecode)
        Me.Controls.Add(Me.ubEncode)
        Me.Controls.Add(Me.txtEncode)
        Me.Controls.Add(Me.txtInitial)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(568, 656)
        Me.Name = "WalrusCoder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Walrus Cipher"
        CType(Me.numSeed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbCrypto.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region " Variables "
    'Randomizer --- Always seeded by Encode() and Decode() ---
    Dim randObj As Random
    Dim randObjAsym As Random 'Use for asymmetrical cases (Encode <> Decode)

    'Positions
    Dim CryptoLeft As Integer = 8
    Dim CryptoTop As Integer = 35 '16
    Dim CryptoHIncrement As Integer = 85
    Dim CryptoVIncrement As Integer = 32
    Dim CryptoSpacing As Integer = 50

    'Fonts
    Dim style As FontStyle = FontStyle.Regular
    Dim CourierNew1 As Font = New Font("Courier New", 8, style)
    Dim TimesNewRoman As Font = New Font("Times New Roman", 10, style)
    Dim SmallFont As Integer = 8.5

    'Cryptanalysis display
    Const MaxEndings As Integer = 7
    Const MaxBigrams As Integer = 25

    'Permanent Lists
    Dim ShortWords As New ArrayList
    Dim FrequencyChart(AlphaCount - 1) As String
    Dim EndingChart(MaxEndings - 1) As String
    Dim BigramChart(MaxBigrams - 1) As String
    Dim TabulaRecta(AlphaCount - 1, AlphaCount - 1) As Char
    Dim PolybiusSquare(AlphaCount - 2) As String

    'Default characters
    Dim GrouperSpace As Char = "0"c
    Dim WallChar As Char = "#"c
    Dim StartMazeChar As Char = "@"c
    Dim EndMazeChar As Char = "$"c

    'Carried over info from encode to decode
    Dim OldLength As Integer = 0

    'Code Names
    Dim Code1 As String = "Grouper"
    Dim Code2 As String = "Single Sub"
    Dim Code3 As String = "Alternator"
    Dim Code4 As String = "Maze"
    Dim Code5 As String = "Binary"
    Dim Code6 As String = "Basic Numeric"
    Dim Code7 As String = "Double Sub"
    Dim Code8 As String = "Grid-5"
    Dim Code9 As String = "ASCII"
    Dim Code10 As String = "Fragmenter"
    Dim Code11 As String = "Morse"
    'Dim Code12 As String = "No Repeats"
    Dim Code12 As String = "Caesar"
    Dim Code13 As String = "Vigenere"
    Dim Code14 As String = "Autokey"
    Dim Code15 As String = "ROT13"
    Dim Code16 As String = "Letters Only"
    Dim Code17 As String = "Scytale"
    Dim Code18 As String = "Grille"
    Dim Code19 As String = "Straddling Checkerboard"
    Dim Code20 As String = "Keyword"
    Dim Code21 As String = "Atbash"
    Dim Code22 As String = "DES"
    Dim Code23 As String = "2TDEA"
    Dim Code24 As String = "3TDEA"
    Dim Code25 As String = "RC4"
    Dim Code26 As String = "Columnar Transposition"
    Dim Code27 As String = "Turning Grille"
    Dim Code28 As String = "Polybius Square"
    Dim Code29 As String = "ADFGVX"
    Dim Code30 As String = "Radiotelephony"
    Dim Code31 As String = "Playfair"
    Dim Code32 As String = "Two Square"
    Dim Code33 As String = "Four Square"
    Dim Code34 As String = "Route"
    Dim Code35 As String = "Voweliant"
    Dim Code36 As String = "Skip Rope"
    Dim Code37 As String = "Bifid"
    Dim Code38 As String = "Trifid"
    Dim Code39 As String = "Polyfair"
    Dim Code40 As String = "Bacon's Children"
    Dim Code41 As String = "Treasure Map"
    Dim Code42 As String = "Progressive Key"
    Dim Code43 As String = "Typewriter Wars"
    Dim Code44 As String = "Alphabetical Squares"
    Dim Code45 As String = ""
    Dim Code46 As String = ""
    Dim Code47 As String = ""
    Dim Code48 As String = ""
    Dim Code49 As String = ""
    Dim Code50 As String = ""

    'Test strings
    Dim Instruct As String = "This is the default message created after pressing the INFO button. Press it again to see information specific to the individual ciphers selected in the dropdown list. You can use this text as a sample for encoding and decoding. Remember that you can copy and paste the encoded portions back into the first textbox to create multiple layers of encryption. Enjoy trying to solve the cryptology techniques, learning about the subject and disguising messages to friends!"
    Dim Instruct1 As String = "Grouper creates a series of nested grouping characters. Parenthesis have the most value, then brackets, then braces and finally arrows. To solve, simply take the first letter in the series of ending letters and replace the first parenthesis and its matching pair. Put in the second letter for the second pair of matching parenthesis. Continue until all the parenthesis are done. Then continue through each of the other grouping characters from the beginning. Grouper is an original cipher by Brian Vacek."
    Dim Instruct2 As String = "Single substitution is a classical cryptology method and easily the most common used for basic ciphers. Each letter in the original text is linked to a unique new letter. By switching all the values, gibberish is created. These are easy to crack by looking at common letters, words and spacing (frequency analysis makes these ciphers trivial), but they are also quite useful. Set the key value at the bottom to create any of several thousand variations that will remain consistent across tests. It is often a good idea to use single-sub as the first step in a series of encryptions."
    Dim Instruct3 As String = "Alternator encodes lowercase letters into lowercase, uppercase and numbers. It works by taking a letter and following it with a number if the next letter is within nine of the first letter (in ascii or alphabetic order). If so, the second number is replaced with the numeric difference between them. If the second number was earlier in the alphabet, the first number is capitalized. It is highly recommended to run single-sub on the message first. Alternator is an original cipher by Brian Vacek."
    Dim Instruct4 As String = "Hit encode to see the maze. The letters correspond to travel instructions; e for east, n for north, w for west and s for south. The capitalization makes no difference for navigating, but is important for solving. Start one character to the right of the @ (at) and obey the directions, always jumping over all previously visited characters, to get to the ending $ (dollar) sign. The distance, direction and capitalization of each move store the message. Maze cipher is an original creation by Brian Vacek."
    Dim Instruct5 As String = "Binary encoding is used by computers for storing information and shows off how to convert numbers between bases. In this case, Basic Numeric coding is done followed by a base change from ten to two. This technique is not intrinsically very useful to cryptology, but it is often the first step for practical applications of digital communication. To strengthen this cipher, anything entered as a key will be converted to binary and used as a xor key."
    Dim Instruct6 As String = "Basic numeric is a trivial cipher that assigns a number to each letter in alphabetic order; a equals one, b equals two, c equals three, etc. Elementary to crack, but useful as a kickoff point."
    Dim Instruct7 As String = "Double substitution is similar to single, but it replaces letters with a random selection of two possibilities. This helps mask the frequency of letters, a common clue in cracking ciphers. This method is an improvement, but still not advised for serious encryption."
    Dim Instruct8 As String = "Grid Five encodes all the letters of a word into five digit (0-31) binary number and then stacks the results in rows. This makes a five x wordlength grid. New binary numbers are then created by reading the digits down each column and translating those back into decimal, thus turning every word into a five number sequence. Grid Five disguises spacing and sentence length, but is slightly unstable on very short words, requiring an occasional repeated first letter and a tiny bit of decoder interpretation. Grid Five was developed independently by Brian Vacek, but is basically a Binary Columnar Cipher."
    Dim Instruct9 As String = "ASCII stands for American Standard Code for Information Interchange. It is a mapping of characters to the numbers 0 through 255. ASCII is used by computers as a universal coding for both plain and rich text. It is not really useful for cryptology although it has the advantage of preserving all capitalization and punctuation which is not supported by many coding systems."
    Dim Instruct10 As String = "One of the most common techniques for solving ciphers, especially substitution ciphers, is to analyze the lengths of words. A and I are easily found from one letter words and repititions of two and three letter words can provide promising keys to the most common letters. Fragmenter disguises this by breaking longer words into semirandom smaller ones. Fragmenter does a little work to prevent ambiguity although some is still possible. This technique is best if combined with single or double substitution. Decoding is not possible, but should not be necessary."
    Dim Instruct11 As String = "Morse code was developed by Samuel F. B. Morse in the 1840s. It bacame the standard for early radio communication because it reduced letters into short and long sounds with pauses in between. It was used by amateur radio enthusiasts, maritime sailors, military operators, prison inmates and emergency broadcasters. Today, Morse code is so rarely used, that it can actually succeed as a high-speed, efficient cipher amongst the general populace when no serious security is required."
    Dim Instruct12 As String = "This cipher is named after Julius Caesar, who used it for military correspondance. It is a very simple substitution system that merely shifts each letter down the alphabet by an offset. Specify the offset using the seed box. Caesar ciphers are considered very poor and can be broken by almost anyone with little difficulty."
    Dim Instruct13 As String = "The Vigenere cipher was actually invented by Giovan Batista Belaso around 1553, although Vignere designed the Autokey variation that made it famous. This cipher is considered polyalphbetic because it uses a tabula recta (a 26x26 of all possible alphabetic offsets) to change the substitution system at every letter based on a required keyword shared by sender and receiver. The keyword is repeated until it is the length of the message and then at each position the original letter and keyword letter are used to find the row and column of the resultant letter on the tabula. The inverse yields the decoded message. This cipher was extremely popular because the keyword was required even if you knew how the cipher worked. However, the repetition of the key still yielded patterns that make it susceptible to advanced frequency analysis. It is also known as Repeat Key. You can key the tabula recta by providing a second key."
    Dim Instruct14 As String = "Autokey was invented by Blaise de Vigenere as a fix for Vigenere cipher that was wrongly attributed to him. Unlike the Vignere, the autokey does not repeat the keyword after the first occurance. Instead it starts using the beginning of the original message as the key (now offset by the initial keyword). Autokey remained unbroken for two hundred years and defeats even frequency analysis. Although certain heuristics, advanced analysis tools and brute force optimizers have since been able to break Autokey it is still one of the most common and effective hand-coded methods. You can key the tabula recta by providing a second key."
    Dim Instruct15 As String = "ROT13 is an abbreviation for Rotation Thirteen. It is a specific case of a Caesar cipher with an offset of 13 allowing it to be encoded and decoded with exactly the same process. It bacame popular on Usenet and the world wide web for hiding punchlines, spoilers and obscenities. It is never used for actual security and has become the whipping boy example of poor encryption. The most famous coded words are: tang, abjurer, terra and irk."
    Dim Instruct16 As String = "Letters Only removes all whitespace and punctuation. Numbers are replaced with the word equivalent (e.g. 1 becomes one). This is not a cipher, but a routine to assist other encryption methods. It can not be decoded."
    Dim Instruct17 As String = "Scytale is an early encryption method developed by the ancient Spartans. It is a simple transpositional cipher that can be done by jumping forward by a set number of characters and wrapping around. The jump quantity is set with the seed value and must be greater than 1."
    Dim Instruct18 As String = "A Grille, in cryptology, is a square mask placed over a series of seemingly random text. By reading through the holes in the mask, the message is revealed. This cipher creates a random mask for you and fills in the intervening characters with random letters at the correct English letter frequency."
    Dim Instruct19 As String = "Straddling Checkboard is a hand cipher developed by the soviets in the 1950s. It replaces the eight most common letters with single digits and the rest of the alphabet including fullstop and null with two digit numbers. If a numeric is entered for the key, the encryption will be much stronger. Popular mnemonics for the most common letters are SENORITA and ESTONIA-R, but according to legend spies use the phrase <a sin to err> while lower ranking members learned <at once, sir>."
    Dim Instruct20 As String = "Keyword is a simple substitution cipher that sets a equal to the first letter of the keyword, b to the second and so on. The remainder of the alphabet is assigned to the first available letter that has not yet been used. The Keyword Cipher is the easiest cipher to impliment that has a customizable text keyword, but it is also the least secure. One of its major flaws is that letters near the end of the alphabet are often entirely transparent (unencrypted)."
    Dim Instruct21 As String = "Atbash is a simple substitution cipher that swaps the value of the ith letter to the (n - i)th. So A becomes Z, Z becomes A and so on. It provides almost no security but is simple and can be encrypted and decrypted with the same process. This was one of the earliest substitution ciphers ever made, designed by the ancient Hebrews. They also used two lesser known variations called Albam and Atbah."
    Dim Instruct22 As String = "DES stands for Digital Encryption Standard. It is a block cipher that requires a 64 bit key (8 ASCII characters or 16 hexidecimal digits). It was developed in the mid 1970s by IBM and the NSA and was released in 1976. It became the most popular computer encryption algorithm in the world due to its fast hardware implimentation (it runs slow in software) and extremely high security (due to equally high complexity). Although it has been under academic scrutiny and realworld attack since its release, it continues to resist cryptanalysis. The only practical technique to break DES is the brute force method of trying every possible key. In 1998 a team brute cracked a single DES message in 56 hours on a $220,000 machine proving that the algorithm was not technically invincible."
    Dim Instruct23 As String = "2TDEA stands for 2-key Triple Digital Encryption Algorithm. It became popular in the 1980's and is still used for many security programs today. After it was shown that DES was theoretically susceptible to certain brute force attacks, 2TDEA was developed to increase the 56 bits of security in DES to 80 bits of security. 2TDEA has never been broken. It requires two keys, separated by a space."
    Dim Instruct24 As String = "3TDEA stands for 3-key Triple Digital Encryption Algorithm. It became popular in the 1980's and is still used for many security programs today. After it was shown that DES was theoretically susceptible to certain brute force attacks, 3TDEA was developed to increase the 56 bits of security in DES to 112 bits of security. 3TDEA has never been broken. It requires three keys, separated by spaces."
    Dim Instruct25 As String = "RC4 stands for Ron's Code 4, a digital stream cipher designed for simplicity and speed with relatively high security. It operates without linear feedback shift registers and instead uses a variable length key to initialize a pseudorandom lookup table and then performs various symmetrical bitwise and swapping functions. It became extremely popular after its development in 1987 and is used for wireless networks, SLL (web browsing and emailing), remote desktop and BitTorrent."
    Dim Instruct26 As String = "Transposition is, along with substitution, one of the fundamental methods of confusion and diffusion in cryptology as defined by information theory founder Claude Shannon. Transposition rearranged letters according to some permutation. Columnar Transposition takes in a key and divides the text into rows of length equal to the key. These rows are then read verically (down the column) in the alphabetic order of the letters in the key."
    Dim Instruct27 As String = "The Turning Grille is a variation of the regular Grille designed by Baron Edouard Fleissner von Wostrowitz and used by the Germans during WWI. You create a mask with a quarter of the squares removed and put your message in the squares until you run out. Then you turn the the mask and repeat three times. The mask is specially designed so that no letters overlap during any of the rotations. The turning grille is clever and fun, but can be broken by frequency analysis, and transposition cryptanalysis techniques. The original is a good first step in a sequence but completely unsecure."
    Dim Instruct28 As String = "The Polybius Square is a simple device used for 25 letter alphabets. The letters are laid out in a 5x5 grid and then replaced by their row and column coordinates. So A equals 11, B equals 12, F equals 21 and so on. This technique was invented by the Greek historian from which it takes its name and was later reinvented and retrofitted as the more secure, scrambled ADFGVX cipher by the Germans."
    Dim Instruct29 As String = "ADFGVX is a German WWI cipher that is based on the Polybius Square. It takes a scrambled 6 x 6 table of letters and numbers and replaces them with their row and column coordinates. These digits are then replaced with the letters in the title: 12 = AD, 63 = XF, 54 = VG and so on. Columnar Transposition is done as the final step. The six letters were chosen for maximum distinctness in morse code. Colonel Fritz Nebel invented the cipher in 1918 and it was French Lieutenant Georges Painvin who cracked it within a month, despite the inordinate difficulty and lack of technology."
    Dim Instruct30 As String = "International Radiotelephony Spelling Alphabet is a code used for radio communication that tries to enhance rather than obscure clarity. Each letter is mapped to an internationally accepted word (chosen by NATO) that maximizes the distinctness of the pronunciation. These words always begin with the letter represented. Radiotelephony also converts punctuation and numbers."
    Dim Instruct31 As String = "Playfair was invented by Charles Wheatstone in 1854 and was put to use by the British military during the Boer War and World War One. It takes a scrambled twentyfive letter alphabet and arranges it on a five by five grid. The plaintext is divided into letter pairs that are found on the grid. The new letters are those at the opposite corners of the rectangle formed by the two letters. If they are in the same column, you take the two below them. If they are in the same row you take the two on their right. Playfair is popular because it partially obscures frequency analysis. You can generate the grid with a keyword or randomly by leaving the keyword box blank."
    Dim Instruct32 As String = "Two Square is a variant of Playfair that puts two grids on top of each other. For each bigram in the original, the first letter is found in the first grid and the second in the other grid. The cipher letters are the opposite corners created by a rectangle from the starting letters. One in every five pairs will be in the same column and so will not be enciphered, a major flaw that helped decription of this technique. Each grid can have a keyword or be randomly generated. Enter zero, one or two keys separated by spaces. All keys not specified will be replaced by a random alphabet grid."
    Dim Instruct33 As String = "Four Square is a variant of Playfair that creates a metagrid of four alphabet grids. The top left and bottom right grids are in regular alphabetic order while the others are either randomly or key generated. For each bigram in the original, find the first letter is found in the top left grid and the second in the bottom right grid. The cipher letters are the opposite corners created by a rectangle from the starting letters. This handles even double letters, matching rows and matching columns, making it the most secure of basic Playfair descendants. Each grid can have a keyword or be randomly generated. Enter zero, one or two keys separated by spaces. All keys not specified will be replaced by a random alphabet grid."
    Dim Instruct34 As String = "The route cipher is a classical transposition cipher with nearly infinite variations. Chunks of 25 letters are written into a grid in a particular order and taken back out of the grid in a second order, thus rearranging them. A simple case would be inscribing them in horizontal rows and then retrieving them in vertical columns (this is how columnar transposition works). The path types available here include raster (line by line), zigzag (back and forth), diagonal, spiral, swirl, archway, inverse (an echo shape) and symmetrical knight's tour (a chess puzzle with movement in an L pattern). These can be in any rotation, reflection or reversal. Set the specifics in the options menu. Playfair and all its descendants can be set to use routes."
    Dim Instruct35 As String = "Voweliant is an original block cipher by Brian Vacek. It takes an eight character key and XORs its binary representation with eight repetitions of its vowel-space pattern (vowels and spaces are given a 1, consonants and other symbols get a 0) to get the master key. Then the message is broken into 64 bit blocks and XORed with the last block in binary and the permutated XOR of the masterkey with 8 repetitions of the last block's vowel-space pattern. The result is converted to hex. Although it approaches 64 bit security, Voweliant is highly susceptible to digital linear cryptanalysis and exploitations of common vowel-space patterns/limitations. It is unlikely to be secure against a determined opponent."
    Dim Instruct36 As String = "Skip Rope is a cipher invented by Brian Vacek that makes use of an unusual fractionation method. It creates a masterkey by converting the input key to 5-bit binary and then adding the interleaving of key bits and message bits. Then it runs through the message bits, depositing them throughout the output. It determines where to place them in the output by removing pairs of digits from the key, skipping that many spaces ahead. Every time that it reaches the original message length, it wraps around again just looking at the remaining skipped positions. Skip Rope can be done by hand, though it is tedious and prone to error. A slight change to the key or message can completely alter the result."
    Dim Instruct37 As String = "Bifid is a classical digraphic cipher invented around the turn of the century by Felix Delastelle, who also designed Two-Square and Trifid. It uses a scrambled Polybius square to find coordinates for letters. It then takes all the row values as one string and all the column values as a second. Pairs of numbers are then read out from the combined string and converted back to letters. Bifid is a very simple and effective fractionation technique that resists frequency analysis. If you do not provide a key, a random polynius grid will be generated. You can also set routes in the option screen."
    Dim Instruct38 As String = "Trifid is the most common and easiest trigraphic (three letters at a time) substitution system. It was invented by Felix Delastelle soon after he developed Bifid. Rather than using a 5 by 5 grid, it uses a 3 by 3 by 3 cube with a full alphabet and the null character. The principle is the same as Bifid, but with a string for row, column and depth values. It achieves greater diffusion than its father. Keywords and routes are not supported."
    Dim Instruct39 As String = "Polyfair is a variation on Playfair invented by Brian Vacek. It makes use of autokey principles. You begin by creating a grid with the starting key. Bigrams are enciphered like in Playfair except that when rows match, you move one down and when columns match you move one right (opposite of regular Playfair). The result is that you will always define a rectangle. Find the earliest alphabetic corner letter and create the new key by moving clockwise back around the rectangle. This key is then used to make the grid for the next bigram, written using the same route."
    Dim Instruct40 As String = "Bacon's Children is a variant on Bacon's cipher. More properly, Bacon's cipher is a form of steganography, the art of disguising a message such that no one is aware of its existence. Around 1600, Francis Bacon came up with the idea of using binary to represent characters from text with letters from the first half of the alphabet equating to zero and letters from the second half equating to one. This variant uses a list of five letter names to carry out his idea, although it is not necessary to use names or even equal length words."
    Dim Instruct41 As String = "Treasure Map is an original cipher by Brian Vacek. You use two scrambled or keyed polybius squares. One grid is known as the World and the other is known as the Map. You begin with a Traveler on the World at the last letter of the key, or 'a' if you have no key. To encipher the first letter of the plaintext, you find that letter in the World and move your traveler to it. You then find any equivalent non-wrapping move on the Map (not necessarily in the same start and end position, but with the same relative relationship), and use its start letter and end letter as the ciphertext. Repeat with the Traveler now in his new position for each following letter. This cipher is powerful because it uses homophones that change based on previous moves and can still be easily done by hand. Routes are supported. Its weaknesses are that double letters remain doubles and opposite corners always map to the same thing."
    Dim Instruct42 As String = "Progressive Key was a variation on Repeat Key, created by Johannes Trithemius. It uses a Tabula Recta like regular Vigenere but each time the key is repeated, each of the letters in the key advanced by one. a becomes b, b becomes c and so on. It is more powerful than Repeat Key because it has a cycle 26 times longer. However, it can still be cracked with a simple modification of the same methods that broke the original Vigenere cipher. You can key the tabula recta by providing a second key."
    Dim Instruct43 As String = "Typewriter Wars is a substitution cipher that replaces characters typed on a QWERTY keyboard with the corresponding symbol from a Dvorak keyboard. Decryption is the reverse. While this cipher is trivial to crack, it provides a mechanism for ultrafast encryption: a trained typist simply touchtypes the message on the opposite keyboard from their training. In fact, for even faster speeds one can swap the order of decryption and encryption, since trained Dvorak users are significantly faster. Note that 'a' and 'm' are transparent (the same on both keyboards)."
    Dim Instruct44 As String = "Alphabetical Squares is a cipher invented by Brian Vacek. It works like Musical Squares. It creates two polybius squares, one in alphabetic order and one scrambled (keyword optional). The letter not used in the square is considered to be 'standing.' For each letter in the message, find the corresponding letter in the scrambled grid that matches its location in the ordered grid. Use this new letter as the enciphered character and then swap it with the 'standing' letter. This swap ensures that the same letter is never enciphered with the same character twice in a row. With a little work, it should be possible to hand crack Alphabetical Squares, but it is easy to use and moderately secure. Like Playfair, the ciphertext has no repeats, but it can include all 26 letters."
    Dim Instruct45 As String = ""
    Dim Instruct46 As String = ""
    Dim Instruct47 As String = ""
    Dim Instruct48 As String = ""
    Dim Instruct49 As String = ""
    Dim Instruct50 As String = ""

#End Region

#Region " DES Constants "
    Const KeyLength As Integer = 16
    Const RoundCount As Integer = 16
    Const KeyBitLength As Integer = 56
    Const KeyBitHalf As Integer = 28
    Const BlockBitSize As Integer = 64
    Const HalfBlock As Integer = 32
    Const SubKeySize As Integer = 48
    Const ByteSize As Integer = 8
    Const SboxSize As Integer = 6
    Const SboxCount As Integer = 8
    Dim Subkeys(KeyLength - 1, SubKeySize - 1) As Char

    'Dim ErrorFlag As Boolean
    'Dim ErrorMsg As String

    Dim IP() As Integer = {58, 50, 42, 34, 26, 18, 10, 2, _
                        60, 52, 44, 36, 28, 20, 12, 4, _
                        62, 54, 46, 38, 30, 22, 14, 6, _
                        64, 56, 48, 40, 32, 24, 16, 8, _
                        57, 49, 41, 33, 25, 17, 9, 1, _
                        59, 51, 43, 35, 27, 19, 11, 3, _
                        61, 53, 45, 37, 29, 21, 13, 5, _
                        63, 55, 47, 39, 31, 23, 15, 7}
    Dim FP() As Integer = {40, 8, 48, 16, 56, 24, 64, 32, _
                            39, 7, 47, 15, 55, 23, 63, 31, _
                            38, 6, 46, 14, 54, 22, 62, 30, _
                            37, 5, 45, 13, 53, 21, 61, 29, _
                            36, 4, 44, 12, 52, 20, 60, 28, _
                            35, 3, 43, 11, 51, 19, 59, 27, _
                            34, 2, 42, 10, 50, 18, 58, 26, _
                            33, 1, 41, 9, 49, 17, 57, 25}
    Dim Expansion() As Integer = {32, 1, 2, 3, 4, 5, _
                                4, 5, 6, 7, 8, 9, _
                                8, 9, 10, 11, 12, 13, _
                                12, 13, 14, 15, 16, 17, _
                                16, 17, 18, 19, 20, 21, _
                                20, 21, 22, 23, 24, 25, _
                                24, 25, 26, 27, 28, 29, _
                                28, 29, 30, 31, 32, 1}
    Dim Permutation() As Integer = {16, 7, 20, 21, _
                                    29, 12, 28, 17, _
                                    1, 15, 23, 26, _
                                    5, 18, 31, 10, _
                                    2, 8, 24, 14, _
                                    32, 27, 3, 9, _
                                    19, 13, 30, 6, _
                                    22, 11, 4, 25}
    Dim PC1_Left() As Integer = {57, 49, 41, 33, 25, 17, 9, _
                                1, 58, 50, 42, 34, 26, 18, _
                                10, 2, 59, 51, 43, 35, 27, _
                                19, 11, 3, 60, 52, 44, 36}
    Dim PC1_Right() As Integer = {63, 55, 47, 39, 31, 23, 15, _
                                7, 62, 54, 46, 38, 30, 22, _
                                14, 6, 61, 53, 45, 37, 29, _
                                21, 13, 5, 28, 20, 12, 4}
    Dim PC2() As Integer = {14, 17, 11, 24, 1, 5, _
                            3, 28, 15, 6, 21, 10, _
                            23, 19, 12, 4, 26, 8, _
                            16, 7, 27, 20, 13, 2, _
                            41, 52, 31, 37, 47, 55, _
                            30, 40, 51, 45, 33, 48, _
                            44, 49, 39, 56, 34, 53, _
                            46, 42, 50, 36, 29, 32}
    Dim S1() As Integer = {14, 4, 13, 1, 2, 15, 11, 8, 3, 10, 6, 12, 5, 9, 0, 7, _
                            0, 15, 7, 4, 14, 2, 13, 1, 10, 6, 12, 11, 9, 5, 3, 8, _
                            4, 1, 14, 8, 13, 6, 2, 11, 15, 12, 9, 7, 3, 10, 5, 0, _
                            15, 12, 8, 2, 4, 9, 1, 7, 5, 11, 3, 14, 10, 0, 6, 13}
    Dim S2() As Integer = {15, 1, 8, 14, 6, 11, 3, 4, 9, 7, 2, 13, 12, 0, 5, 10, _
                            3, 13, 4, 7, 15, 2, 8, 14, 12, 0, 1, 10, 6, 9, 11, 5, _
                            0, 14, 7, 11, 10, 4, 13, 1, 5, 8, 12, 6, 9, 3, 2, 15, _
                            13, 8, 10, 1, 3, 15, 4, 2, 11, 6, 7, 12, 0, 5, 14, 9}
    Dim S3() As Integer = {10, 0, 9, 14, 6, 3, 15, 5, 1, 13, 12, 7, 11, 4, 2, 8, _
                            13, 7, 0, 9, 3, 4, 6, 10, 2, 8, 5, 14, 12, 11, 15, 1, _
                            13, 6, 4, 9, 8, 15, 3, 0, 11, 1, 2, 12, 5, 10, 14, 7, _
                            1, 10, 13, 0, 6, 9, 8, 7, 4, 15, 14, 3, 11, 5, 2, 12}
    Dim S4() As Integer = {7, 13, 14, 3, 0, 6, 9, 10, 1, 2, 8, 5, 11, 12, 4, 15, _
                            13, 8, 11, 5, 6, 15, 0, 3, 4, 7, 2, 12, 1, 10, 14, 9, _
                            10, 6, 9, 0, 12, 11, 7, 13, 15, 1, 3, 14, 5, 2, 8, 4, _
                            3, 15, 0, 6, 10, 1, 13, 8, 9, 4, 5, 11, 12, 7, 2, 14}
    Dim S5() As Integer = {2, 12, 4, 1, 7, 10, 11, 6, 8, 5, 3, 15, 13, 0, 14, 9, _
                            14, 11, 2, 12, 4, 7, 13, 1, 5, 0, 15, 10, 3, 9, 8, 6, _
                            4, 2, 1, 11, 10, 13, 7, 8, 15, 9, 12, 5, 6, 3, 0, 14, _
                            11, 8, 12, 7, 1, 14, 2, 13, 6, 15, 0, 9, 10, 4, 5, 3}
    Dim S6() As Integer = {12, 1, 10, 15, 9, 2, 6, 8, 0, 13, 3, 4, 14, 7, 5, 11, _
                            10, 15, 4, 2, 7, 12, 9, 5, 6, 1, 13, 14, 0, 11, 3, 8, _
                            9, 14, 15, 5, 2, 8, 12, 3, 7, 0, 4, 10, 1, 13, 11, 6, _
                            4, 3, 2, 12, 9, 5, 15, 10, 11, 14, 1, 7, 6, 0, 8, 13}
    Dim S7() As Integer = {4, 11, 2, 14, 15, 0, 8, 13, 3, 12, 9, 7, 5, 10, 6, 1, _
                            13, 0, 11, 7, 4, 9, 1, 10, 14, 3, 5, 12, 2, 15, 8, 6, _
                            1, 4, 11, 13, 12, 3, 7, 14, 10, 15, 6, 8, 0, 5, 9, 2, _
                            6, 11, 13, 8, 1, 4, 10, 7, 9, 5, 0, 15, 14, 2, 3, 12}
    Dim S8() As Integer = {13, 2, 8, 4, 6, 15, 11, 1, 10, 9, 3, 14, 5, 0, 12, 7, _
                            1, 15, 13, 8, 10, 3, 7, 4, 12, 5, 6, 11, 0, 14, 9, 2, _
                            7, 11, 4, 1, 9, 12, 14, 2, 0, 6, 10, 13, 15, 3, 5, 8, _
                            2, 1, 14, 7, 4, 10, 8, 13, 15, 12, 9, 0, 3, 5, 6, 11}
    Dim KeySchedule() As Integer = {1, 1, 2, 2, 2, 2, 2, 2, 1, 2, 2, 2, 2, 2, 2, 1}

#End Region

#Region " RC4 Variables "
    Const BoxSize As Integer = 256
    Dim RCBox(BoxSize) As Integer
#End Region

#Region " Voweliant Constants "
    Dim VowelKeyTable() As Integer = {38, 32, 56, 25, 12, 17, 51, 36, _
                                    59, 11, 29, 61, 3, 41, 21, 7, _
                                    13, 47, 35, 49, 44, 63, 5, 26, _
                                    4, 40, 28, 19, 16, 58, 30, 22, _
                                    52, 43, 23, 54, 39, 24, 34, 45, _
                                    8, 15, 0, 6, 60, 10, 53, 37, _
                                    18, 46, 31, 50, 62, 27, 2, 14, _
                                    33, 1, 55, 42, 9, 48, 20, 57}
#End Region

#Region " New "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        CreateLists()
        LoadOptions()
        InitializeCoder()
        UpdateOptions()
    End Sub

    Private Sub WalrusCoder_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'InitializeCoder()
    End Sub

    Sub UpdateOptions()
        If (ShowCryptanalysis) Then
            Me.Size = New System.Drawing.Size(856, 656)
        Else
            Me.Size = New System.Drawing.Size(568, 656)
        End If
        txtInitial.Text = InitialText.Trim
        txtKey.Text = InitialKey
        numSeed.Value = InitialSeed
    End Sub

    Sub CreateLists()
        CreateShortWordList()
        CreateTabulaRecta()
        CreatePolybiusSquare()
        CreateFrequencyChart()
        CreateCrypto()
    End Sub

    Sub InitializeCoder()
        cbSystem.Items.Add(Code1)
        cbSystem.Items.Add(Code2)
        cbSystem.Items.Add(Code3)
        cbSystem.Items.Add(Code4)
        cbSystem.Items.Add(Code5)
        cbSystem.Items.Add(Code6)
        cbSystem.Items.Add(Code7)
        cbSystem.Items.Add(Code8)
        cbSystem.Items.Add(Code9)
        cbSystem.Items.Add(Code10)
        cbSystem.Items.Add(Code11)
        cbSystem.Items.Add(Code12)
        cbSystem.Items.Add(Code13)
        cbSystem.Items.Add(Code14)
        cbSystem.Items.Add(Code15)
        cbSystem.Items.Add(Code16)
        cbSystem.Items.Add(Code17)
        cbSystem.Items.Add(Code18)
        cbSystem.Items.Add(Code19)
        cbSystem.Items.Add(Code20)
        cbSystem.Items.Add(Code21)
        cbSystem.Items.Add(Code22)
        cbSystem.Items.Add(Code23)
        cbSystem.Items.Add(Code24)
        cbSystem.Items.Add(Code25)
        cbSystem.Items.Add(Code26)
        cbSystem.Items.Add(Code27)
        cbSystem.Items.Add(Code28)
        cbSystem.Items.Add(Code29)
        cbSystem.Items.Add(Code30)
        cbSystem.Items.Add(Code31)
        cbSystem.Items.Add(Code32)
        cbSystem.Items.Add(Code33)
        cbSystem.Items.Add(Code34)
        cbSystem.Items.Add(Code35)
        cbSystem.Items.Add(Code36)
        cbSystem.Items.Add(Code37)
        cbSystem.Items.Add(Code38)
        cbSystem.Items.Add(Code39)
        cbSystem.Items.Add(Code40)
        cbSystem.Items.Add(Code41)
        cbSystem.Items.Add(Code42)
        cbSystem.Items.Add(Code43)
        cbSystem.Items.Add(Code44)
        'cbSystem.Items.Add(Code45)
        'cbSystem.Items.Add(Code46)
        'cbSystem.Items.Add(Code47)
        'cbSystem.Items.Add(Code48)
        'cbSystem.Items.Add(Code49)
        'cbSystem.Items.Add(Code50)
        'cbSystem.Items.Add(Code51)

        'cbSystem.SelectedIndex = 1
        cbSystem.SelectedItem = InitialCode
    End Sub

    Sub SetInfo()
        If (String.Compare(txtInitial.Text, Instruct) = 0) Then
            If (String.Compare(cbSystem.Text, Code1) = 0) Then
                txtInitial.Text = Instruct1
            ElseIf (String.Compare(cbSystem.Text, Code2) = 0) Then
                txtInitial.Text = Instruct2
            ElseIf (String.Compare(cbSystem.Text, Code3) = 0) Then
                txtInitial.Text = Instruct3
            ElseIf (String.Compare(cbSystem.Text, Code4) = 0) Then
                txtInitial.Text = Instruct4
            ElseIf (String.Compare(cbSystem.Text, Code5) = 0) Then
                txtInitial.Text = Instruct5
            ElseIf (String.Compare(cbSystem.Text, Code6) = 0) Then
                txtInitial.Text = Instruct6
            ElseIf (String.Compare(cbSystem.Text, Code7) = 0) Then
                txtInitial.Text = Instruct7
            ElseIf (String.Compare(cbSystem.Text, Code8) = 0) Then
                txtInitial.Text = Instruct8
            ElseIf (String.Compare(cbSystem.Text, Code9) = 0) Then
                txtInitial.Text = Instruct9
            ElseIf (String.Compare(cbSystem.Text, Code10) = 0) Then
                txtInitial.Text = Instruct10
            ElseIf (String.Compare(cbSystem.Text, Code11) = 0) Then
                txtInitial.Text = Instruct11
            ElseIf (String.Compare(cbSystem.Text, Code12) = 0) Then
                txtInitial.Text = Instruct12
            ElseIf (String.Compare(cbSystem.Text, Code13) = 0) Then
                txtInitial.Text = Instruct13
            ElseIf (String.Compare(cbSystem.Text, Code14) = 0) Then
                txtInitial.Text = Instruct14
            ElseIf (String.Compare(cbSystem.Text, Code15) = 0) Then
                txtInitial.Text = Instruct15
            ElseIf (String.Compare(cbSystem.Text, Code16) = 0) Then
                txtInitial.Text = Instruct16
            ElseIf (String.Compare(cbSystem.Text, Code17) = 0) Then
                txtInitial.Text = Instruct17
            ElseIf (String.Compare(cbSystem.Text, Code18) = 0) Then
                txtInitial.Text = Instruct18
            ElseIf (String.Compare(cbSystem.Text, Code19) = 0) Then
                txtInitial.Text = Instruct19
            ElseIf (String.Compare(cbSystem.Text, Code20) = 0) Then
                txtInitial.Text = Instruct20
            ElseIf (String.Compare(cbSystem.Text, Code21) = 0) Then
                txtInitial.Text = Instruct21
            ElseIf (String.Compare(cbSystem.Text, Code22) = 0) Then
                txtInitial.Text = Instruct22
            ElseIf (String.Compare(cbSystem.Text, Code23) = 0) Then
                txtInitial.Text = Instruct23
            ElseIf (String.Compare(cbSystem.Text, Code24) = 0) Then
                txtInitial.Text = Instruct24
            ElseIf (String.Compare(cbSystem.Text, Code25) = 0) Then
                txtInitial.Text = Instruct25
            ElseIf (String.Compare(cbSystem.Text, Code26) = 0) Then
                txtInitial.Text = Instruct26
            ElseIf (String.Compare(cbSystem.Text, Code27) = 0) Then
                txtInitial.Text = Instruct27
            ElseIf (String.Compare(cbSystem.Text, Code28) = 0) Then
                txtInitial.Text = Instruct28
            ElseIf (String.Compare(cbSystem.Text, Code29) = 0) Then
                txtInitial.Text = Instruct29
            ElseIf (String.Compare(cbSystem.Text, Code30) = 0) Then
                txtInitial.Text = Instruct30
            ElseIf (String.Compare(cbSystem.Text, Code31) = 0) Then
                txtInitial.Text = Instruct31
            ElseIf (String.Compare(cbSystem.Text, Code32) = 0) Then
                txtInitial.Text = Instruct32
            ElseIf (String.Compare(cbSystem.Text, Code33) = 0) Then
                txtInitial.Text = Instruct33
            ElseIf (String.Compare(cbSystem.Text, Code32) = 0) Then
                txtInitial.Text = Instruct32
            ElseIf (String.Compare(cbSystem.Text, Code33) = 0) Then
                txtInitial.Text = Instruct33
            ElseIf (String.Compare(cbSystem.Text, Code34) = 0) Then
                txtInitial.Text = Instruct34
            ElseIf (String.Compare(cbSystem.Text, Code35) = 0) Then
                txtInitial.Text = Instruct35
            ElseIf (String.Compare(cbSystem.Text, Code36) = 0) Then
                txtInitial.Text = Instruct36
            ElseIf (String.Compare(cbSystem.Text, Code37) = 0) Then
                txtInitial.Text = Instruct37
            ElseIf (String.Compare(cbSystem.Text, Code38) = 0) Then
                txtInitial.Text = Instruct38
            ElseIf (String.Compare(cbSystem.Text, Code39) = 0) Then
                txtInitial.Text = Instruct39
            ElseIf (String.Compare(cbSystem.Text, Code40) = 0) Then
                txtInitial.Text = Instruct40
            ElseIf (String.Compare(cbSystem.Text, Code41) = 0) Then
                txtInitial.Text = Instruct41
            ElseIf (String.Compare(cbSystem.Text, Code42) = 0) Then
                txtInitial.Text = Instruct42
            ElseIf (String.Compare(cbSystem.Text, Code43) = 0) Then
                txtInitial.Text = Instruct43
            ElseIf (String.Compare(cbSystem.Text, Code44) = 0) Then
                txtInitial.Text = Instruct44
                'ElseIf (String.Compare(cbSystem.Text, Code45) = 0) Then
                '    txtInitial.Text = Instruct45
                'ElseIf (String.Compare(cbSystem.Text, Code46) = 0) Then
                '    txtInitial.Text = Instruct46
                'ElseIf (String.Compare(cbSystem.Text, Code47) = 0) Then
                '    txtInitial.Text = Instruct47
                'ElseIf (String.Compare(cbSystem.Text, Code48) = 0) Then
                '    txtInitial.Text = Instruct48
                'ElseIf (String.Compare(cbSystem.Text, Code49) = 0) Then
                '    txtInitial.Text = Instruct49
                'ElseIf (String.Compare(cbSystem.Text, Code50) = 0) Then
                '    txtInitial.Text = Instruct50
            End If
        Else
            txtInitial.Text = Instruct
        End If
    End Sub

    Sub Encode()
        'Seed random
        SeedRandom()

        'Initialize textbox
        txtEncode.Text = ""
        txtEncode.WordWrap = True
        txtEncode.ScrollBars = ScrollBars.Vertical
        txtEncode.Font = TimesNewRoman

        Dim Initial As String = txtInitial.Text
        Dim Encoded As String

        'Check Options
        If (AlwaysRemove) Then
            Initial = RemoveNonLetters(Initial)
        End If
        If (AlwaysSub) Then
            Initial = EncodeSingleSub(Initial)
        End If
        If (PunctuationType <> LeavePunct) Then
            Initial = ReplacePunctuation(Initial)
        End If

        'Run Ciphers
        If (String.Compare(cbSystem.Text, Code1) = 0) Then
            Encoded = EncodeGrouper(Initial)
        ElseIf (String.Compare(cbSystem.Text, Code2) = 0) Then
            Encoded = EncodeSingleSub(Initial)
        ElseIf (String.Compare(cbSystem.Text, Code3) = 0) Then
            Encoded = EncodeAlternator(Initial)
        ElseIf (String.Compare(cbSystem.Text, Code4) = 0) Then
            txtEncode.WordWrap = False
            txtEncode.ScrollBars = ScrollBars.Both
            txtEncode.Font = CourierNew1
            Encoded = EncodeMaze(Initial)
        ElseIf (String.Compare(cbSystem.Text, Code5) = 0) Then
            Encoded = EncodeBinary(Initial)
        ElseIf (String.Compare(cbSystem.Text, Code6) = 0) Then
            Encoded = EncodeBasicNumeric(Initial)
        ElseIf (String.Compare(cbSystem.Text, Code7) = 0) Then
            Encoded = EncodeDoubleSub(Initial)
        ElseIf (String.Compare(cbSystem.Text, Code8) = 0) Then
            Encoded = EncodeGrid5(Initial)
        ElseIf (String.Compare(cbSystem.Text, Code9) = 0) Then
            Encoded = EncodeASCII(Initial)
        ElseIf (String.Compare(cbSystem.Text, Code10) = 0) Then
            Encoded = EncodeFragmenter(Initial)
        ElseIf (String.Compare(cbSystem.Text, Code11) = 0) Then
            Encoded = EncodeMorse(Initial)
        ElseIf (String.Compare(cbSystem.Text, Code12) = 0) Then
            Encoded = EncodeCaesar(Initial)
        ElseIf (String.Compare(cbSystem.Text, Code13) = 0) Then
            Encoded = EncodeTabulaKey(Initial, KEYTYPES.Repeat)
        ElseIf (String.Compare(cbSystem.Text, Code14) = 0) Then
            Encoded = EncodeTabulaKey(Initial, KEYTYPES.Autokey)
        ElseIf (String.Compare(cbSystem.Text, Code15) = 0) Then
            numSeed.Value = 13
            Encoded = EncodeCaesar(Initial)
        ElseIf (String.Compare(cbSystem.Text, Code16) = 0) Then
            Encoded = RemoveNonLetters(Initial)
        ElseIf (String.Compare(cbSystem.Text, Code17) = 0) Then
            Encoded = EncodeScytale(Initial)
        ElseIf (String.Compare(cbSystem.Text, Code18) = 0) Then
            txtEncode.WordWrap = False
            txtEncode.ScrollBars = ScrollBars.Both
            txtEncode.Font = CourierNew1
            Encoded = EncodeGrille(Initial)
        ElseIf (String.Compare(cbSystem.Text, Code19) = 0) Then
            Encoded = EncodeStraddling(Initial)
        ElseIf (String.Compare(cbSystem.Text, Code20) = 0) Then
            Encoded = EncodeKeyword(Initial)
        ElseIf (String.Compare(cbSystem.Text, Code21) = 0) Then
            Encoded = EncodeAtbash(Initial)
        ElseIf (String.Compare(cbSystem.Text, Code22) = 0) Then
            Encoded = EncodeDES(Initial, 1)
        ElseIf (String.Compare(cbSystem.Text, Code23) = 0) Then
            Encoded = EncodeDES(Initial, 2)
        ElseIf (String.Compare(cbSystem.Text, Code24) = 0) Then
            Encoded = EncodeDES(Initial, 3)
        ElseIf (String.Compare(cbSystem.Text, Code25) = 0) Then
            Encoded = EncodeRC4(Initial)
        ElseIf (String.Compare(cbSystem.Text, Code26) = 0) Then
            Encoded = EncodeColumnar(Initial)
        ElseIf (String.Compare(cbSystem.Text, Code27) = 0) Then
            txtEncode.WordWrap = False
            txtEncode.ScrollBars = ScrollBars.Both
            txtEncode.Font = CourierNew1
            Encoded = EncodeRGrille(Initial)
        ElseIf (String.Compare(cbSystem.Text, Code28) = 0) Then
            Encoded = EncodePolybius(Initial)
        ElseIf (String.Compare(cbSystem.Text, Code29) = 0) Then
            Encoded = EncodeADFGVX(Initial)
        ElseIf (String.Compare(cbSystem.Text, Code30) = 0) Then
            Encoded = EncodeRadiotelephony(Initial)
        ElseIf (String.Compare(cbSystem.Text, Code31) = 0) Then
            Encoded = EncodePlayfair(Initial)
        ElseIf (String.Compare(cbSystem.Text, Code32) = 0) Then
            Encoded = EncodeTwoSquare(Initial)
        ElseIf (String.Compare(cbSystem.Text, Code33) = 0) Then
            Encoded = EncodeFourSquare(Initial)
        ElseIf (String.Compare(cbSystem.Text, Code34) = 0) Then
            Encoded = EncodeRoute(Initial)
        ElseIf (String.Compare(cbSystem.Text, Code35) = 0) Then
            Encoded = EncodeVoweliant(Initial)
        ElseIf (String.Compare(cbSystem.Text, Code36) = 0) Then
            Encoded = EncodeSkipRope2(Initial)
        ElseIf (String.Compare(cbSystem.Text, Code37) = 0) Then
            Encoded = EncodeBifid(Initial)
        ElseIf (String.Compare(cbSystem.Text, Code38) = 0) Then
            Encoded = EncodeTrifid(Initial)
        ElseIf (String.Compare(cbSystem.Text, Code39) = 0) Then
            Encoded = EncodePolyfair(Initial)
        ElseIf (String.Compare(cbSystem.Text, Code40) = 0) Then
            Encoded = EncodeBaconsChildren(Initial)
        ElseIf (String.Compare(cbSystem.Text, Code41) = 0) Then
            Encoded = EncodeTreasureMap(Initial)
        ElseIf (String.Compare(cbSystem.Text, Code42) = 0) Then
            Encoded = EncodeTabulaKey(Initial, KEYTYPES.Progressive)
        ElseIf (String.Compare(cbSystem.Text, Code43) = 0) Then
            Encoded = EncodeTypewriterWars(Initial)
        ElseIf (String.Compare(cbSystem.Text, Code44) = 0) Then
            Encoded = EncodeAlphabeticalSquares(Initial)
        End If


        If (SpacingDistance > 0) Then
            Encoded = SpaceRegularly(Encoded)
        End If

        txtEncode.Text = Encoded

    End Sub

    Sub Decode()
        'Seed random
        SeedRandom()

        'Initialize textbox
        txtDecode.Text = ""
        txtDecode.WordWrap = True
        txtDecode.ScrollBars = ScrollBars.Vertical
        If (Verbose) Then
            txtDecode.Font = CourierNew1
        Else
            txtDecode.Font = TimesNewRoman
        End If

        Dim Encoded As String = txtEncode.Text
        Dim Decoded As String = ""

        'Check Options
        If (SpacingDistance > 0) Then
            Encoded = RemoveWhiteSpace(Encoded)
            Encoded = Encoded.Replace(" ", "")
        End If

        If (String.Compare(cbSystem.Text, Code1) = 0) Then
            Decoded = DecodeGrouper(Encoded)
        ElseIf (String.Compare(cbSystem.Text, Code2) = 0) Then
            Decoded = DecodeSingleSub(Encoded)
        ElseIf (String.Compare(cbSystem.Text, Code3) = 0) Then
            Decoded = DecodeAlternator(Encoded)
        ElseIf (String.Compare(cbSystem.Text, Code4) = 0) Then
            Decoded = DecodeMaze(Encoded)
        ElseIf (String.Compare(cbSystem.Text, Code5) = 0) Then
            Decoded = DecodeBinary(Encoded)
        ElseIf (String.Compare(cbSystem.Text, Code6) = 0) Then
            Decoded = DecodeBasicNumeric(Encoded)
        ElseIf (String.Compare(cbSystem.Text, Code7) = 0) Then
            Decoded = DecodeDoubleSub(Encoded)
        ElseIf (String.Compare(cbSystem.Text, Code8) = 0) Then
            Decoded = DecodeGrid5(Encoded)
        ElseIf (String.Compare(cbSystem.Text, Code9) = 0) Then
            Decoded = DecodeASCII(Encoded)
        ElseIf (String.Compare(cbSystem.Text, Code10) = 0) Then
            Decoded = DecodeFragmenter(Encoded)
        ElseIf (String.Compare(cbSystem.Text, Code11) = 0) Then
            Decoded = DecodeMorse(Encoded)
        ElseIf (String.Compare(cbSystem.Text, Code12) = 0) Then
            Decoded = DecodeCaesar(Encoded)
        ElseIf (String.Compare(cbSystem.Text, Code13) = 0) Then
            Decoded = DecodeTabulaKey(Encoded, KEYTYPES.Repeat)
        ElseIf (String.Compare(cbSystem.Text, Code14) = 0) Then
            Decoded = DecodeTabulaKey(Encoded, KEYTYPES.Autokey)
        ElseIf (String.Compare(cbSystem.Text, Code15) = 0) Then
            numSeed.Value = 13
            Decoded = EncodeCaesar(Encoded)
        ElseIf (String.Compare(cbSystem.Text, Code17) = 0) Then
            Decoded = DecodeScytale(Encoded)
        ElseIf (String.Compare(cbSystem.Text, Code18) = 0) Then
            Decoded = DecodeGrille(Encoded)
        ElseIf (String.Compare(cbSystem.Text, Code19) = 0) Then
            Decoded = DecodeStraddling(Encoded)
        ElseIf (String.Compare(cbSystem.Text, Code20) = 0) Then
            Decoded = DecodeKeyword(Encoded)
        ElseIf (String.Compare(cbSystem.Text, Code21) = 0) Then
            Decoded = EncodeAtbash(Encoded, True)
        ElseIf (String.Compare(cbSystem.Text, Code22) = 0) Then
            Decoded = DecodeDES(Encoded, 1)
        ElseIf (String.Compare(cbSystem.Text, Code23) = 0) Then
            Decoded = DecodeDES(Encoded, 2)
        ElseIf (String.Compare(cbSystem.Text, Code24) = 0) Then
            Decoded = DecodeDES(Encoded, 3)
        ElseIf (String.Compare(cbSystem.Text, Code25) = 0) Then
            Decoded = DecodeRC4(Encoded)
        ElseIf (String.Compare(cbSystem.Text, Code26) = 0) Then
            Decoded = DecodeColumnar(Encoded)
        ElseIf (String.Compare(cbSystem.Text, Code27) = 0) Then
            Decoded = DecodeRGrille(Encoded)
        ElseIf (String.Compare(cbSystem.Text, Code28) = 0) Then
            Decoded = DecodePolybius(Encoded)
        ElseIf (String.Compare(cbSystem.Text, Code29) = 0) Then
            Decoded = DecodeADFGVX(Encoded)
        ElseIf (String.Compare(cbSystem.Text, Code30) = 0) Then
            Decoded = DecodeRadiotelephony(Encoded)
        ElseIf (String.Compare(cbSystem.Text, Code31) = 0) Then
            Decoded = EncodePlayfair(Encoded, True)
        ElseIf (String.Compare(cbSystem.Text, Code32) = 0) Then
            Decoded = EncodeTwoSquare(Encoded, True)
        ElseIf (String.Compare(cbSystem.Text, Code33) = 0) Then
            Decoded = EncodeFourSquare(Encoded, True)
        ElseIf (String.Compare(cbSystem.Text, Code34) = 0) Then
            Decoded = EncodeRoute(Encoded, True)
        ElseIf (String.Compare(cbSystem.Text, Code35) = 0) Then
            Decoded = DecodeVoweliant(Encoded)
        ElseIf (String.Compare(cbSystem.Text, Code36) = 0) Then
            Decoded = DecodeSkipRope2(Encoded)
        ElseIf (String.Compare(cbSystem.Text, Code37) = 0) Then
            Decoded = DecodeBifid(Encoded)
        ElseIf (String.Compare(cbSystem.Text, Code38) = 0) Then
            Decoded = DecodeTrifid(Encoded)
        ElseIf (String.Compare(cbSystem.Text, Code39) = 0) Then
            Decoded = EncodePolyfair(Encoded, True)
        ElseIf (String.Compare(cbSystem.Text, Code40) = 0) Then
            Decoded = DecodeBaconsChildren(Encoded)
        ElseIf (String.Compare(cbSystem.Text, Code41) = 0) Then
            Decoded = DecodeTreasureMap(Encoded)
        ElseIf (String.Compare(cbSystem.Text, Code42) = 0) Then
            Decoded = DecodeTabulaKey(Encoded, KEYTYPES.Progressive)
        ElseIf (String.Compare(cbSystem.Text, Code43) = 0) Then
            Decoded = EncodeTypewriterWars(Encoded, True)
        ElseIf (String.Compare(cbSystem.Text, Code44) = 0) Then
            Decoded = DecodeAlphabeticalSquares(Encoded)
        End If

        If (AlwaysSub) Then
            Decoded = DecodeSingleSub(Decoded)
        End If

        txtDecode.Text = Decoded
    End Sub

#End Region

#Region "One Time Initialization "
    Sub CreateCrypto()
        Dim Alphabet As ArrayList = CreateAlphabetList()

        Dim i As Integer
        Dim CurrentX As Integer = CryptoLeft
        Dim CurrentY As Integer = CryptoTop
        For i = 0 To AlphaCount - 1
            '--Create Cryptoinfo
            Dim NewCryptoLabel As New Label
            Dim NewCryptoText As New TextBox
            NewCryptoLabel.Parent = gbCrypto
            NewCryptoText.Parent = gbCrypto
            NewCryptoLabel.Location = New System.Drawing.Point(gbCrypto.Location.X + CurrentX, gbCrypto.Location.Y + CurrentY)
            NewCryptoText.Location = New System.Drawing.Point(gbCrypto.Location.X + CurrentX + CryptoSpacing, gbCrypto.Location.Y + CurrentY)

            If i Mod 9 = 8 And i <> 0 Then  'Second Column
                CurrentY = CryptoTop
                CurrentX += CryptoHIncrement
            Else
                CurrentY += CryptoVIncrement
            End If

            'NewCryptoLabel.Appearance.FontData.SizeInPoints = SmallFont
            NewCryptoLabel.Name = "CryptoLabel" + i.ToString()
            NewCryptoText.Name = "CryptoText" + i.ToString()
            NewCryptoLabel.Tag = i
            NewCryptoText.Tag = i
            NewCryptoLabel.Size = New System.Drawing.Size(70, 30)
            NewCryptoText.Size = New System.Drawing.Size(30, 30)
            NewCryptoLabel.TabStop = False
            NewCryptoText.TabStop = False
            NewCryptoText.MaxLength = 1
            NewCryptoLabel.TextAlign = ContentAlignment.MiddleLeft
            'NewCryptoLabel.Appearance.TextHAlign = Infragistics.Win.HAlign.Left
            'NewCryptoLabel.Appearance.TextVAlign = Infragistics.Win.VAlign.Middle
            NewCryptoText.TextAlign = HorizontalAlignment.Center
            NewCryptoLabel.Text = Chr(i + CapDiff) + "   " + FrequencyChart(i)
            NewCryptoText.Text = ""
            AddHandler NewCryptoText.TextChanged, AddressOf LabelTextChangedCrypto
            TheCryptoLabels(i) = NewCryptoLabel
            TheCryptoTexts(i) = NewCryptoText
            Me.Controls.Add(NewCryptoLabel)
            Me.Controls.Add(NewCryptoText)
            NewCryptoLabel.BringToFront()
            NewCryptoText.BringToFront()
        Next
    End Sub

    Sub CreateShortWordList()
        ShortWords.Clear()
        ShortWords.Add("a")
        ShortWords.Add("i")
        ShortWords.Add("an")
        ShortWords.Add("at")
        ShortWords.Add("be")
        ShortWords.Add("by")
        ShortWords.Add("do")
        ShortWords.Add("go")
        ShortWords.Add("he")
        ShortWords.Add("hi")
        ShortWords.Add("if")
        ShortWords.Add("in")
        ShortWords.Add("is")
        ShortWords.Add("it")
        ShortWords.Add("me")
        ShortWords.Add("no")
        ShortWords.Add("of")
        ShortWords.Add("on")
        ShortWords.Add("or")
        ShortWords.Add("so")
        ShortWords.Add("to")
        ShortWords.Add("up")
        ShortWords.Add("we")
        ShortWords.Add("act")
        ShortWords.Add("age")
        ShortWords.Add("and")
        ShortWords.Add("ape")
        ShortWords.Add("are")
        ShortWords.Add("arm")
        ShortWords.Add("ant")
        ShortWords.Add("any")
        ShortWords.Add("ate")
        ShortWords.Add("bat")
        ShortWords.Add("bet")
        ShortWords.Add("but")
        ShortWords.Add("con")
        ShortWords.Add("ear")
        ShortWords.Add("eat")
        ShortWords.Add("eve")
        ShortWords.Add("for")
        ShortWords.Add("her")
        ShortWords.Add("his")
        ShortWords.Add("let")
        ShortWords.Add("man")
        ShortWords.Add("mar")
        ShortWords.Add("nor")
        ShortWords.Add("not")
        ShortWords.Add("opt")
        ShortWords.Add("out")
        ShortWords.Add("pen")
        ShortWords.Add("per")
        ShortWords.Add("par")
        ShortWords.Add("pre")
        ShortWords.Add("set")
        ShortWords.Add("she")
        ShortWords.Add("tar")
        ShortWords.Add("yes")
        ShortWords.Add("you")
    End Sub

    Function CreatePolybiusSquare()
        Dim i, j As Integer

        For i = 0 To 4
            For j = 0 To 4
                PolybiusSquare((i * 5) + j) = (i + 1).ToString + (j + 1).ToString
            Next
        Next

    End Function

    Function IsShortWord(ByVal TheStr As String) As Boolean
        If ShortWords.IndexOf(TheStr) >= 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Sub CreateFrequencyChart()
        'Dim InputString As String = "0.73 9 30 44 130 28 16 35 74 2 3 35 25 78 74 27 3 77 63 93 27 13 16 5 19 1"
        Dim InputFraction As String = "0.073 0.009 0.030 0.044 0.130 0.028 0.016 0.035 0.074 0.002 0.003 0.035 0.025 0.078 0.074 0.027 0.003 0.077 0.063 0.093 0.027 0.013 0.016 0.005 0.019 0.001"
        FrequencyChart = InputFraction.Split(" ")
        InputFraction = "E T S D N R Y"
        EndingChart = InputFraction.Split(" ")
        InputFraction = "TH ER ON AN RE HE IN ED ND HA AT EN ES OF OR NT EA TI OT IT ST IO LE IS OU"
        BigramChart = InputFraction.Split(" ")
    End Sub
#End Region

#Region " Cryptoanalysis "

    Private Sub LabelTextChangedCrypto(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim TheTextBox As TextBox = CType(sender, TextBox)
        If (TheTextBox.Text.Length = 1) Then
            If (Char.IsLetter(TheTextBox.Text)) Then
                TheTextBox.Text = Char.ToUpper(TheTextBox.Text)
            End If
        End If
        UpdateDecode()
    End Sub

    Private Sub txtInitial_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtInitial.TextChanged
        'UpdateEncode()
    End Sub

    Private Sub txtEncode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEncode.TextChanged
        UpdateFrequencies()
    End Sub

    Function UpdateFrequencies()
        Dim RawString As String = txtEncode.Text
        RawString = RawString.ToLower
        Dim FullCharArray As Char() = RawString.ToCharArray
        Dim CurrentFrequency(AlphaNumeralCount - 1) As Integer
        Dim EndingFrequency(AlphaNumeralCount - 1) As AlphaNumericPair
        Dim BigramFrequency((AlphaNumeralCount * AlphaNumeralCount) - 1) As AlphaNumericPair
        Dim StringLength = FullCharArray.Length
        Dim NonWhiteLength As Integer = 0
        Dim Frequency As Double

        Dim i, j As Integer
        Dim iChar, jChar As String
        'Initialize arrays
        For i = 0 To AlphaNumeralCount - 1
            If (i < AlphaCount) Then
                iChar = Chr(i + AlphaDiff)
            Else
                iChar = Chr(i - AlphaCount + NumeralDiff)
            End If
            EndingFrequency(i) = New AlphaNumericPair(0, iChar)
            For j = 0 To AlphaNumeralCount - 1
                If (j < AlphaCount) Then
                    jChar = Chr(j + AlphaDiff)
                Else
                    jChar = Chr(j - AlphaCount + NumeralDiff)
                End If
                BigramFrequency((i * AlphaNumeralCount) + j) = New AlphaNumericPair(0, iChar + jChar)
            Next
        Next

        'Find count of each character, ending and bigram
        For i = 0 To StringLength - 1
            If (Get36ArrayValue(FullCharArray(i)) >= 0) Then
                CurrentFrequency(Get36ArrayValue(FullCharArray(i))) += 1
                NonWhiteLength += 1
                If (i + 1 < StringLength) Then
                    If (FullCharArray(i + 1) = " "c) Then
                        EndingFrequency(Get36ArrayValue(FullCharArray(i))).Number += 1
                    End If
                    If (Get36ArrayValue(FullCharArray(i + 1)) >= 0) Then
                        BigramFrequency(((Get36ArrayValue(FullCharArray(i))) * AlphaNumeralCount) + Get36ArrayValue(FullCharArray(i + 1))).Number += 1
                    End If
                Else
                    EndingFrequency(Get36ArrayValue(FullCharArray(i))).Number += 1
                End If
            Else
                'StringLength -= 1   'Does not effect for loop
            End If
        Next

        'Find and update index of coincidence
        Dim FSum As Double = 0
        For i = 0 To AlphaCount - 1
            If (CurrentFrequency(i) > 1) Then
                FSum = FSum + (CurrentFrequency(i) * (CurrentFrequency(i) - 1))
            End If
        Next
        If NonWhiteLength > 1 Then
            FSum = FSum * AlphaCount / (NonWhiteLength * (NonWhiteLength - 1))
        Else
            FSum = 0
        End If
        lblIC.Text = "Index of Coincidence: 1.73 (" + String.Format("{0:n2}", FSum) + ")"

        'Update frequency table with counts
        For i = 0 To AlphaCount - 1
            If (CurrentFrequency(i) > 0) Then
                Frequency = CurrentFrequency(i) / StringLength
            Else
                Frequency = 0
            End If
            TheCryptoLabels(i).Text = Chr(i + CapDiff) + "   " + FrequencyChart(i) + ControlChars.NewLine + "  (" + Frequency.ToString("0.000") + ")"
        Next

        'Update endings
        Array.Sort(EndingFrequency)
        Array.Reverse(EndingFrequency)
        Dim EndingString As String = ""
        Dim EndingCurrent As String = ""
        For i = 0 To MaxEndings - 1
            EndingString += EndingChart(i) + " "
            If (EndingFrequency(i).Number > 0) Then
                EndingCurrent += Char.ToUpper(EndingFrequency(i).Letter) + " "
            End If
        Next
        lblEndings.Text = EndingString + "(" + EndingCurrent.TrimEnd() + ")"

        'Update bigrams
        Array.Sort(BigramFrequency)
        Array.Reverse(BigramFrequency)
        Dim BigramString As String = ""
        Dim BigramCurrent As String = ""
        For i = 0 To MaxBigrams - 1
            BigramString += BigramChart(i) + " "
            If (BigramFrequency(i).Number > 0) Then
                BigramCurrent += (BigramFrequency(i).Letter) + " "
            End If
        Next
        lblBigrams.Text = BigramString + ControlChars.NewLine + "(" + BigramCurrent.TrimEnd() + ")"

    End Function

    Function UpdateDecode()
        Dim RawString As String = txtEncode.Text
        RawString = RawString.ToLower
        Dim FullCharArray As Char() = RawString.ToCharArray
        Dim SubstitutionArray(AlphaCount) As Char
        Dim StringLength = FullCharArray.Length
        Dim OutputString As String = ""

        Dim i As Integer
        For i = 0 To AlphaCount - 1
            If (Char.IsLetter(TheCryptoTexts(i).Text)) Then
                SubstitutionArray(i) = Char.ToUpper(TheCryptoTexts(i).Text)
            Else
                SubstitutionArray(i) = Chr(i + AlphaDiff)
            End If
        Next

        For i = 0 To StringLength - 1
            If (Char.IsLetter(FullCharArray(i))) Then
                OutputString += SubstitutionArray(Asc(FullCharArray(i)) - AlphaDiff)
            Else
                OutputString += FullCharArray(i)
            End If
        Next

        txtDecode.Text = OutputString
    End Function

#End Region

#Region " Data Conversions "

    Function CharToDecimal(ByVal theChar As String) As Integer
        Dim theASCII As Integer
        theASCII = Asc(theChar)
        If (theASCII >= AlphaDiff And theASCII <= 122) Then
            Return theASCII - AlphaDiff
        ElseIf (theChar = " "c) Then
            Return 26
        ElseIf (theChar = "."c) Then
            Return 27
        ElseIf (theChar = "!"c) Then
            Return 28
        ElseIf (theChar = "?"c) Then
            Return 29
        ElseIf (theChar = ","c) Then
            Return 30
        ElseIf (theChar = ";"c) Then
            Return 31
        Else
            Return -1
        End If
    End Function

    Function DecimalToChar(ByVal theNum As Integer) As String
        If (theNum >= 0 And theNum < 26) Then
            Return Chr(theNum + AlphaDiff)
        ElseIf (theNum = 26) Then
            Return " "
        ElseIf (theNum = 27) Then
            Return "."
        ElseIf (theNum = 28) Then
            Return "!"
        ElseIf (theNum = 29) Then
            Return "?"
        ElseIf (theNum = 30) Then
            Return ","
        ElseIf (theNum = 31) Then
            Return ";"
        Else
            Return ""
        End If
    End Function

    Function DecimalToHex(ByVal theDouble As Double) As String
        Dim CurrentDecimal As Double
        Dim newDigit As Char
        Dim HexString As String = ""
        Do
            CurrentDecimal = (theDouble Mod 16.0)
            If (CurrentDecimal < 10) Then
                newDigit = CurrentDecimal.ToString()
            ElseIf (CurrentDecimal = 10) Then
                newDigit = "A"
            ElseIf (CurrentDecimal = 11) Then
                newDigit = "B"
            ElseIf (CurrentDecimal = 12) Then
                newDigit = "C"
            ElseIf (CurrentDecimal = 13) Then
                newDigit = "D"
            ElseIf (CurrentDecimal = 14) Then
                newDigit = "E"
            ElseIf (CurrentDecimal = 15) Then
                newDigit = "F"
            End If
            theDouble = Math.Floor(theDouble / 16.0)
            HexString = newDigit.ToString() + HexString
        Loop While (theDouble > 0)

        Return HexString
    End Function

    Function HexToDecimal(ByVal HexString As String) As Double
        Dim i As Integer
        Dim factor, output As Double
        Dim CharArray() As Char
        CharArray = HexString.TrimEnd().ToCharArray()
        output = 0
        factor = 1
        For i = CharArray.Length() - 1 To 0 Step -1
            If (Char.IsDigit(CharArray(i))) Then
                output += (Microsoft.VisualBasic.Val(CharArray(i)) * factor)
            ElseIf (CharArray(i) = "A"c) Then
                output += (10 * factor)
            ElseIf (CharArray(i) = "B"c) Then
                output += (11 * factor)
            ElseIf (CharArray(i) = "C"c) Then
                output += (12 * factor)
            ElseIf (CharArray(i) = "D"c) Then
                output += (13 * factor)
            ElseIf (CharArray(i) = "E"c) Then
                output += (14 * factor)
            ElseIf (CharArray(i) = "F"c) Then
                output += (15 * factor)
            Else
                'ERROR: Someone tampered with binary data.
                Return -1
            End If
            factor *= 16
        Next
        Return output
    End Function

    Function BinaryToHex(ByVal Binary As String) As String
        'Binary = Binary.Trim()
        'Dim theDecimal As Double = BinaryToDecimal(Binary)
        'Return DecimalToHex(theDecimal)

        'Dim BinaryArray() As Char = Binary.ToCharArray()
        Dim HexString As String = ""
        Dim i As Integer
        For i = 0 To Binary.Length - 1 Step 4
            Select Case Binary.PadLeft(4, "0").Substring(i, 4)
                Case "0000"
                    HexString += "0"
                Case "0001"
                    HexString += "1"
                Case "0010"
                    HexString += "2"
                Case "0011"
                    HexString += "3"
                Case "0100"
                    HexString += "4"
                Case "0101"
                    HexString += "5"
                Case "0110"
                    HexString += "6"
                Case "0111"
                    HexString += "7"
                Case "1000"
                    HexString += "8"
                Case "1001"
                    HexString += "9"
                Case "1010"
                    HexString += "A"
                Case "1011"
                    HexString += "B"
                Case "1100"
                    HexString += "C"
                Case "1101"
                    HexString += "D"
                Case "1110"
                    HexString += "E"
                Case "1111"
                    HexString += "F"
                Case Else
                    'Error
                    HexString += "*"
            End Select
        Next
        Return HexString
    End Function

    Function HexToBinary(ByVal Hex As String) As String
        'Hex = Hex.Trim()
        'Dim theDecimal As Double = HexToDecimal(Hex)
        'Return DecimalToBinary(theDecimal)

        Dim HexArray() As Char = Hex.ToCharArray()
        Dim BinaryString As String = ""
        Dim i As Integer
        For i = 0 To Hex.Length - 1
            Select Case HexArray(i)
                Case "0"c
                    BinaryString += "0000"
                Case "1"c
                    BinaryString += "0001"
                Case "2"c
                    BinaryString += "0010"
                Case "3"c
                    BinaryString += "0011"
                Case "4"c
                    BinaryString += "0100"
                Case "5"c
                    BinaryString += "0101"
                Case "6"c
                    BinaryString += "0110"
                Case "7"c
                    BinaryString += "0111"
                Case "8"c
                    BinaryString += "1000"
                Case "9"c
                    BinaryString += "1001"
                Case "A"c
                    BinaryString += "1010"
                Case "B"c
                    BinaryString += "1011"
                Case "C"c
                    BinaryString += "1100"
                Case "D"c
                    BinaryString += "1101"
                Case "E"c
                    BinaryString += "1110"
                Case "F"c
                    BinaryString += "1111"
                Case Else
                    'Error
                    BinaryString += "****"
            End Select
        Next
        Return BinaryString
    End Function

    Function HexStringToBinary(ByVal theHexes As String) As String
        'Convert from hex to binary
        Dim BinaryOutput As String = ""
        Dim i As Integer
        Dim HexArray() As Char = theHexes.ToCharArray()
        For i = 0 To HexArray.Length - 1
            BinaryOutput += HexToBinary(HexArray(i))
        Next

        Return BinaryOutput
    End Function

    Function BinaryToHexString(ByVal BinaryString As String) As String
        Dim HexOutput As String = ""
        Dim i As Integer
        For i = 0 To BinaryString.Length - 1 Step 4
            HexOutput += BinaryToHex(BinaryString.Substring(i, 4))
        Next

        Return HexOutput
    End Function

    Function DecimalToBinary(ByVal theDouble As Double) As String
        Dim newDigit As Double
        'Dim newDigit As Long
        Dim BinaryString As String = ""
        Do
            newDigit = (theDouble Mod 2.0)
            theDouble = Math.Floor(theDouble / 2.0)
            BinaryString = newDigit.ToString() + BinaryString
        Loop While (theDouble > 0)

        Return BinaryString
    End Function

    Function DecimalToBinary(ByVal theDouble As Double, ByVal PadLength As Integer) As String
        Dim OutputString As String = DecimalToBinary(theDouble)
        Return OutputString.Trim().PadLeft(PadLength, "0")
    End Function

    Function BinaryToDecimal(ByVal BinaryString As String) As Double
        Dim i As Integer
        Dim factor, output As Double
        Dim CharArray() As Char
        CharArray = BinaryString.TrimEnd().ToCharArray()
        output = 0
        factor = 1
        For i = CharArray.Length() - 1 To 0 Step -1
            If (CharArray(i) = "1"c) Then
                output += factor
            ElseIf (CharArray(i) = "0"c) Then
                'Nothing
            Else
                'ERROR: Someone tampered with binary data.
                Return -1
            End If
            factor *= 2
        Next
        Return output
    End Function

    Function ASCIIStringToBinary(ByVal theText As String) As String
        'Convert from Text to Binary
        Dim i As Integer
        Dim MsgChar() As Char = theText.ToCharArray()
        Dim BinaryStr As String = ""
        For i = 0 To MsgChar.Length - 1
            BinaryStr += DecimalToBinary(Asc(MsgChar(i))).PadLeft(8, "0")
        Next
        Return BinaryStr
    End Function

    Function BinaryToASCIIString(ByVal theText As String) As String
        'Convert from Binary to Text
        Dim i As Integer
        Dim BinaryChunk As String
        Dim TextOutput As String = ""
        If (theText.Length Mod ByteSize = 0) Then
            For i = 0 To theText.Length - 1 Step ByteSize
                BinaryChunk = theText.Substring(i, ByteSize)
                TextOutput += Chr(BinaryToDecimal(BinaryChunk))
            Next
            Return TextOutput
        Else
            Return "Binary string was not of the byte divisible length."
        End If
    End Function

    Function ASCIIStringToBinary5(ByVal RawText As String) As String
        RawText = RawText.ToLower()
        Dim SafeArrayList As ArrayList = CreateAlphabetList32()
        Dim OutputString As String = ""
        Dim i As Integer
        Dim FullCharArray() As Char
        FullCharArray = RawText.ToCharArray

        For i = 0 To FullCharArray.Length - 1
            If (SafeArrayList.IndexOf(FullCharArray(i)) >= 0) Then
                'Only include the 32 recognized characters
                OutputString += DecimalToBinary(CharToDecimal(FullCharArray(i)), 5).ToString()
            End If
        Next

        Return OutputString
    End Function

    Function Binary5ToASCIIString(ByVal RawText As String) As String
        RawText = RemoveNonNumbers(RawText.Trim())
        Dim OutputString As String = ""
        Dim i As Integer
        RawText = PadToMultiple(RawText, 5, PADSTYLES.ZeroesOnly)

        For i = 0 To RawText.Length - 1 Step 5
            OutputString += DecimalToChar(BinaryToDecimal(RawText.Substring(i, 5))).ToString()
        Next

        Return OutputString
    End Function

    Function Get36ArrayValue(ByVal theChar As Char) As Integer
        'Return value > 0 if alphanumeric (a-z=0-25,0-9=26-35)
        If (Char.IsLetter(theChar) And Asc(theChar) < 128) Then
            If (Char.IsLower(theChar)) Then
                Return Asc(theChar) - AlphaDiff
            Else
                Return Asc(theChar) - CapDiff
            End If
        ElseIf (Char.IsDigit(theChar)) Then
            Return Asc(theChar) - NumeralDiff + AlphaCount
        Else
            Return -1
        End If
    End Function

    Function Get25Char(ByVal theValue As Integer) As Char
        Dim theChar As Char = Chr(theValue + AlphaDiff)
        If (theChar = LetterToRemove) Then
            If (LetterToRemove = "j"c) Then
                theChar = "i"c
            ElseIf (LetterToRemove = "q"c) Then
                theChar = "p"c
            ElseIf (LetterToRemove = "x"c) Then
                theChar = "k"c
            ElseIf (LetterToRemove = "z"c) Then
                theChar = "s"c
            End If
        End If
        Return theChar
    End Function

    Function Get25Char(ByVal inChar As Char) As Char
        If (inChar = LetterToRemove) Then
            If (LetterToRemove = "j"c) Then
                inChar = "i"c
            ElseIf (LetterToRemove = "q"c) Then
                inChar = "p"c
            ElseIf (LetterToRemove = "x"c) Then
                inChar = "k"c
            ElseIf (LetterToRemove = "z"c) Then
                inChar = "s"c
            End If
        End If
        Return inChar
    End Function

    Function Get25ArrayValue(ByVal theChar As Char) As Integer
        Dim theValue As Integer = Asc(theChar)
        If (theValue = Asc(LetterToRemove)) Then
            'Error
            Return -1
        ElseIf (theValue > Asc(LetterToRemove)) Then
            theValue -= 1
        End If
        Return theValue - AlphaDiff
    End Function

    Function Get25ArrayChar(ByVal theValue As Integer) As Char
        theValue += AlphaDiff
        If (theValue = Asc(LetterToRemove)) Then
            'Error
            Return "!"
        ElseIf (theValue > Asc(LetterToRemove)) Then
            theValue -= 1
        End If
        Return Chr(theValue)
    End Function

    Function ConvertNumbers(ByVal RawText As String) As String
        RawText = RawText.Replace("1", "one")
        RawText = RawText.Replace("2", "two")
        RawText = RawText.Replace("3", "three")
        RawText = RawText.Replace("4", "four")
        RawText = RawText.Replace("5", "five")
        RawText = RawText.Replace("6", "six")
        RawText = RawText.Replace("7", "seven")
        RawText = RawText.Replace("8", "eight")
        RawText = RawText.Replace("9", "nine")
        RawText = RawText.Replace("0", "zero")
        Return RawText
    End Function

    Function ConvertToVowelBinary(ByVal theText As String) As String
        'Turns vowels and spaces to ones and everything else to 0
        Dim FullCharArray() As Char = theText.ToCharArray()
        Dim OutputString As String = ""
        Dim i As Integer

        For i = 0 To FullCharArray.Length - 1
            If (IsVowel(FullCharArray(i)) Or FullCharArray(i) = " "c) Then
                OutputString += "1"
            Else
                OutputString += "0"
            End If
        Next

        Return OutputString
    End Function

    Function RemoveNonLetters(ByVal RawText As String) As String
        RawText = ConvertNumbers(RawText)
        Dim FullCharArray As Char() = RawText.ToCharArray
        Dim OutputString As String = ""
        Dim i As Integer
        For i = 0 To FullCharArray.Length - 1
            If (Char.IsLetter(FullCharArray(i))) Then
                OutputString += FullCharArray(i)
            End If
        Next
        Return OutputString
    End Function

    Function RemoveNonNumbers(ByVal RawText As String) As String
        Dim FullCharArray As Char() = RawText.ToCharArray
        Dim OutputString As String = ""
        Dim i As Integer
        For i = 0 To FullCharArray.Length - 1
            If (Char.IsDigit(FullCharArray(i))) Then
                OutputString += FullCharArray(i)
            End If
        Next
        Return OutputString
    End Function

    Function RemoveAllButSpaces(ByVal RawText As String) As String
        RawText = ConvertNumbers(RawText)
        Dim FullCharArray As Char() = RawText.ToCharArray
        Dim OutputString As String = ""
        Dim i As Integer
        For i = 0 To FullCharArray.Length - 1
            If (Char.IsLetter(FullCharArray(i)) Or FullCharArray(i) = " ") Then
                OutputString += FullCharArray(i)
            End If
        Next
        Return OutputString
    End Function

    Function ReplacePunctuation(ByVal RawText As String) As String
        Select Case PunctuationType
            Case ShortPunct
                RawText = RawText.Replace(".", " PD")
                RawText = RawText.Replace("!", " PD")
                RawText = RawText.Replace(",", " CMA")
                RawText = RawText.Replace(";", " CMA")
                RawText = RawText.Replace("?", " RQ")
            Case LongPunct
                RawText = RawText.Replace(".", " STOP")
                RawText = RawText.Replace("!", " STOP")
                RawText = RawText.Replace(",", " COMMA")
                RawText = RawText.Replace(":", " COLON")
                RawText = RawText.Replace(";", " SCOLON")
                RawText = RawText.Replace(Chr(34), " QUOTE ")
                RawText = RawText.Replace("(", "PAREN ")
                RawText = RawText.Replace(")", " PAREN")
                RawText = RawText.Replace("?", " QMARK")
            Case LeavePunct

        End Select
        Return RawText
    End Function

    Function RemoveWhiteSpace(ByVal theText As String) As String
        theText = theText.Trim()
        theText = theText.Replace(Chr(10), " ")
        theText = theText.Replace(Chr(13), " ")
        theText = theText.Replace(Chr(9), " ")
        While (theText.IndexOf("  ") > 0)
            theText = theText.Replace("  ", " ")
        End While
        Return theText
    End Function

    Function RemoveDuplicates(ByVal RawText As String) As String
        RawText = RawText.ToLower
        Dim FullCharArray() As Char = RawText.ToCharArray()
        Dim OutputString As String = ""
        Dim i As Integer
        For i = 0 To FullCharArray.Length - 1
            If (i >= 0 And i <= Array.IndexOf(FullCharArray, FullCharArray(i))) Then
                OutputString += FullCharArray(i)
            End If
        Next
        Return OutputString
    End Function

    Function SpaceRegularly(ByVal RawText As String) As String
        If (SpacingDistance > 0) Then
            RawText = RemoveWhiteSpace(RawText)
            RawText = RawText.Replace(" ", "")
            Dim FullCharArray() As Char = RawText.ToCharArray()
            Dim OutputString As String = ""
            Dim i As Integer

            For i = 0 To FullCharArray.Length - 1
                OutputString += FullCharArray(i)
                If (i > 0 And i Mod SpacingDistance = 1) Then
                    OutputString += " "
                End If
            Next

            Return OutputString
        Else
            Return RawText
        End If


    End Function

    Function SetTo25(ByVal RawText As String) As String
        Return RawText.Replace(LetterToRemove, Get25Char(Asc(LetterToRemove) - AlphaDiff))
    End Function

#End Region

#Region " Helper Functions "

    Sub SeedRandom()
        randObj = New Random(numSeed.Value)
        randObjAsym = New Random(numSeed.Value + randObj.Next(0, 100000))
    End Sub

    Sub SeedRandom(ByVal offset As Integer)
        randObj = New Random(numSeed.Value + offset)
        randObjAsym = New Random(numSeed.Value + randObj.Next(0, 100000))
    End Sub

    Function CreateTabulaRecta()
        Dim i, j As Integer

        For i = 0 To AlphaCount - 1
            For j = 0 To AlphaCount - 1
                TabulaRecta(i, j) = Chr(((i + j) Mod AlphaCount) + AlphaDiff)
            Next
        Next
    End Function

    Function CreateKeyedTabulaRecta(ByVal theKey As String)
        'Format Key
        theKey = RemoveDuplicates(RemoveNonLetters(theKey.ToLower))
        Dim KeyArray() As Char = theKey.ToCharArray()

        'Remembered Arrays
        Dim CharMapper(AlphaCount - 1) As Char

        'Setup alphabet
        Dim CharList As ArrayList = CreateAlphabetList()

        'Enter key followed by alphabet
        Dim i, j As Integer
        For i = 0 To AlphaCount - 1
            If (i < theKey.Length) Then
                CharMapper(i) = KeyArray(i)
                CharList.RemoveAt(CharList.IndexOf(KeyArray(i)))
            Else
                CharMapper(i) = CharList(0)
                CharList.RemoveAt(0)
            End If
        Next

        'Fill keyed TabulaRecta
        For i = 0 To AlphaCount - 1
            For j = 0 To AlphaCount - 1
                TabulaRecta(i, j) = CharMapper((i + j) Mod AlphaCount)
            Next
        Next
    End Function

    Function GetTabulaRecta() As String
        Dim i, j As Integer
        Dim OutputString As String = ""

        For i = 0 To AlphaCount - 1
            For j = 0 To AlphaCount - 1
                OutputString += TabulaRecta(i, j) + " "
            Next
            OutputString += ControlChars.NewLine
        Next

        Return OutputString
    End Function

    Function CreateNamesList() As ArrayList
        'Fill name list
        Dim theNames As New ArrayList
        theNames.Add("cliff abbie adele heidi mikel leigh bambi cecil") 'a
        theNames.Add("billy jeffy james mikey allen megan kelly") 'b
        theNames.Add("clark diane abdul jacob keith jeane elena") 'c
        theNames.Add("damon bacon keats ellyn") 'd
        theNames.Add("lance carla katie katja derek mitch david maria marge abram hazel jared kathi basil chuck") 'e
        theNames.Add("gavin mandy davis chris kirby meyer kevin karan") 'f
        theNames.Add("laura lloyd carol daryl fiona dante") 'g
        theNames.Add("marty aaron larry jason jesus henry") 'h
        theNames.Add("kylie lydia lucia craig jodie julia grace isaac drake") 'i
        theNames.Add("brian molly logan ethan lucas") 'j
        theNames.Add("frank moira irene") 'k
        theNames.Add("johny brent grant fritz angus brett") 'l
        theNames.Add("jorgi annie louie josef april") 'm
        theNames.Add("bryan gorky louis brody aspen corey doris boris erwin irvin jones cosmo") 'n
        theNames.Add("donna monte lynne lotta brook errol lorri") 'o
        theNames.Add("dotty dusty horst autry bruno") 'p
        theNames.Add("ollie vicki wilma zelda") 'q
        theNames.Add("pablo timmy sammy regis ricky nelly peggy sally vicky teddy") 'r
        theNames.Add("tamra ralph reese smith tiana olive siena pearl shari sibyl") 's
        theNames.Add("simon shawn shaun ramon pedro rhett saint") 't
        theNames.Add("sarah ritch paula vance naomi") 'u 
        theNames.Add("sandy nancy randy") 'v
        theNames.Add("patti raoul thora") 'w
        theNames.Add("patty perry venus scott") 'x
        theNames.Add("tobie sofia oneal price") 'y
        theNames.Add("roman stacy romeo tracy tobey tommy") 'z
        theNames.Add("steve oneta rubye trina trish sylva") 'space
        theNames.Add("trent quinn pratt wyatt owens robyn tylor") '.
        theNames.Add("ozzie norma norah susie") '!
        theNames.Add("susan ruthy trudy posey rosco toney") '?
        theNames.Add("tonya sonya young stone") ',
        theNames.Add("upton orson tyson") ';

        Return theNames
    End Function

    Function CreateAlphabetList() As ArrayList
        Dim CharList As New ArrayList

        'Make alphabet list
        Dim i As Integer
        For i = 0 To AlphaCount - 1
            CharList.Add(Chr(AlphaDiff + i))
        Next
        Return CharList
    End Function

    Function CreateAlphabetList25() As ArrayList
        Dim CharList As New ArrayList

        'Make alphabet list
        Dim i As Integer
        For i = 0 To AlphaCount - 1
            If (Chr(AlphaDiff + i) <> LetterToRemove) Then
                CharList.Add(Chr(AlphaDiff + i))
            End If
        Next
        Return CharList
    End Function

    Function CreateAlphabetList32() As ArrayList
        Dim i As Integer
        Dim CharList As ArrayList = CreateAlphabetList()
        CharList.Add(" "c)
        CharList.Add("."c)
        CharList.Add(","c)
        CharList.Add("!"c)
        CharList.Add("?"c)
        CharList.Add(";"c)
        Return CharList
    End Function

    Function CreateAlphaNumericList() As ArrayList
        Dim CharArrayList As New ArrayList

        'Make alphabet array
        Dim i As Integer
        For i = 0 To AlphaCount - 1
            CharArrayList.Add(Chr(AlphaDiff + i))
        Next
        For i = 0 To NumeralCount - 1
            CharArrayList.Add(Chr(NumeralDiff + i))
        Next
        Return CharArrayList
    End Function

    Function CreateAlphabetArray() As Array

        Dim CharArray(AlphaCount - 1) As Char

        'Make alphabet array
        Dim i As Integer
        For i = 0 To AlphaCount - 1
            CharArray(i) = Chr(AlphaDiff + i)
        Next
        Return CharArray
    End Function

    Function CreateAlphabetArray25() As Array
        Dim CharArray(AlphaCount - 2) As Char

        'Make alphabet list
        Dim i, index As Integer
        index = 0
        For i = 0 To AlphaCount - 1
            If (Chr(AlphaDiff + i) <> LetterToRemove) Then
                CharArray(index) = Chr(AlphaDiff + i)
                index += 1
            End If
        Next
        Return CharArray
    End Function

    Function CreateAlphabetAndCapsList() As ArrayList
        Dim CharList As New ArrayList

        'Make alphabet list
        Dim i As Integer
        For i = 0 To AlphaCount - 1
            CharList.Add(Chr(AlphaDiff + i))
        Next
        For i = 0 To AlphaCount - 1
            CharList.Add(Chr(CapDiff + i))
        Next
        Return CharList
    End Function

    Function CreateRoutes(ByVal oldArray As Char()) As Char()
        Dim routeString As String

        'Decide routeArray
        Dim routeChoice As New ArrayList
        If (PathRaster) Then
            routeChoice.Add(RasterInt)
        End If
        If (PathDiagonal) Then
            routeChoice.Add(DiagonalInt)
        End If
        If (PathSpiral) Then
            routeChoice.Add(SpiralInt)
        End If
        If (PathZigzag) Then
            routeChoice.Add(ZigzagInt)
        End If
        If (PathArch) Then
            routeChoice.Add(ArchInt)
        End If
        If (PathInverse) Then
            routeChoice.Add(InverseInt)
        End If
        If (PathSwirl) Then
            routeChoice.Add(SwirlInt)
        End If
        If (PathKnight) Then
            routeChoice.Add(KnightInt)
        End If

        'Set Path strings
        Select Case routeChoice(randObj.Next(0, routeChoice.Count))
            Case DiagonalInt
                Select Case (randObj.Next(0, 4))
                    Case 0
                        routeString = "0 5 1 10 6 2 15 11 7 3 20 16 12 8 4 21 17 13 9 22 18 14 23 19 24"
                    Case 1
                        routeString = "4 3 9 2 8 14 1 7 13 19 0 6 12 18 24 5 11 17 23 10 16 22 15 21 20"
                    Case 2
                        routeString = "24 23 19 22 18 14 21 17 13 9 20 16 12 8 4 15 11 7 3 10 6 2 5 1 0"
                    Case 3
                        routeString = "20 15 21 10 16 22 5 11 17 23 0 6 12 18 24 1 7 13 19 2 8 14 3 9 4"
                    Case Else
                End Select
            Case SpiralInt
                Select Case (randObj.Next(0, 8))
                    Case 0 'Spiral Clockwise
                        routeString = "0 1 2 3 4 9 14 19 24 23 22 21 20 15 10 5 6 7 8 13 18 17 16 11 12"
                    Case 1
                        routeString = "4 9 14 19 24 23 22 21 20 15 10 5 0 1 2 3 8 13 18 17 16 11 6 7 12"
                    Case 2
                        routeString = "24 23 22 21 20 15 10 5 0 1 2 3 4 9 14 19 18 17 16 11 6 7 8 13 12"
                    Case 3
                        routeString = "20 15 10 5 0 1 2 3 4 9 14 19 24 23 22 21 16 11 6 7 8 13 18 17 12"
                    Case 4 'Spirals CounterClockwise
                        routeString = "0 5 10 15 20 21 22 23 24 19 14 9 4 3 2 1 6 11 16 17 18 13 8 7 12"
                    Case 5
                        routeString = "4 3 2 1 0 5 10 15 20 21 22 23 24 19 14 9 8 7 6 11 16 17 18 13 12"
                    Case 6
                        routeString = "24 19 14 9 4 3 2 1 0 5 10 15 20 21 22 23 18 13 8 7 6 11 16 17 12"
                    Case 7
                        routeString = "20 21 22 23 24 19 14 9 4 3 2 1 0 5 10 15 16 17 18 13 8 7 6 11 12"
                End Select
            Case ZigzagInt
                If (GetAnswer(PathVertical)) Then
                    If (randObj.Next(0, 2) = 0) Then
                        routeString = "0 5 10 15 20 21 16 11 6 1 2 7 12 17 22 23 18 13 8 3 4 9 14 19 24"
                    Else
                        routeString = "20 15 10 5 0 1 6 11 16 21 22 17 12 7 2 3 8 13 18 23 24 19 14 9 4"
                    End If
                Else
                    If (randObj.Next(0, 2) = 0) Then
                        routeString = "0 1 2 3 4 9 8 7 6 5 10 11 12 13 14 19 18 17 16 15 20 21 22 23 24"
                    Else
                        routeString = "4 3 2 1 0 5 6 7 8 9 14 13 12 11 10 15 16 17 18 19 24 23 22 21 20"
                    End If
                End If
            Case ArchInt
                If (GetAnswer(PathVertical)) Then
                    Select Case (randObj.Next(0, 4))
                        Case 0
                            routeString = "12 17 22 21 16 11 6 7 8 13 18 23 24 19 14 9 4 3 2 1 0 5 10 15 20"
                        Case 1
                            routeString = "12 17 22 23 18 13 8 7 6 11 16 21 20 15 10 5 0 1 2 3 4 9 14 19 24"
                        Case 2
                            routeString = "12 7 2 3 8 13 18 17 16 11 6 1 0 5 10 15 20 21 22 23 24 19 14 9 4"
                        Case 3
                            routeString = "12 7 2 1 6 11 16 17 18 13 8 3 4 9 14 19 24 23 22 21 20 15 10 5 0"
                    End Select
                Else
                    Select Case (randObj.Next(0, 4))
                        Case 0
                            routeString = "12 13 14 19 18 17 16 11 6 7 8 9 4 3 2 1 0 5 10 15 20 21 22 23 24"
                        Case 1
                            routeString = "12 13 14 9 8 7 6 11 16 17 18 19 24 23 22 21 20 15 10 5 0 1 2 3 4"
                        Case 2
                            routeString = "12 11 10 5 6 7 8 13 18 17 16 15 20 21 22 23 24 19 14 9 4 3 2 1 0"
                        Case 3
                            routeString = "12 11 10 15 16 17 18 13 8 7 6 5 0 1 2 3 4 9 14 19 24 23 22 21 20"
                    End Select
                End If
            Case InverseInt
                Select Case (randObj.Next(0, 8))
                    Case 0
                        routeString = "0 1 2 3 4 9 14 19 24 23 18 13 8 7 6 5 10 11 12 17 22 21 16 15 20"
                    Case 1
                        routeString = "0 5 10 15 20 21 22 23 24 19 18 17 16 11 6 1 2 7 12 13 14 9 8 3 4"
                    Case 2
                        routeString = "4 9 14 19 24 23 22 21 20 15 16 17 18 13 8 3 2 7 12 11 10 5 6 1 0"
                    Case 3
                        routeString = "4 3 2 1 0 5 10 15 20 21 16 11 6 7 8 9 14 13 12 17 22 23 18 19 24"
                    Case 4
                        routeString = "24 23 22 21 20 15 10 5 0 1 6 11 16 17 18 19 14 13 12 7 2 3 8 9 4"
                    Case 5
                        routeString = "24 19 14 9 4 3 2 1 0 5 6 7 8 13 18 23 22 17 12 11 10 15 16 21 20"
                    Case 6
                        routeString = "20 15 10 5 0 1 2 3 4 9 8 7 6 11 16 21 22 17 12 13 14 19 18 23 24"
                    Case 7
                        routeString = "20 21 22 23 24 19 14 9 4 3 8 13 18 17 16 15 10 11 12 7 2 1 6 5 0"
                End Select
            Case SwirlInt
                If (GetAnswer(PathVertical)) Then
                    If (randObj.Next(0, 2) = 0) Then
                        routeString = "0 5 10 15 20 21 22 23 18 13 8 7 12 17 16 11 6 1 2 3 4 9 14 19 24"
                    Else
                        routeString = "20 15 10 5 0 1 2 3 8 13 18 17 12 7 6 11 16 21 22 23 24 19 14 9 4"
                    End If
                Else
                    If (randObj.Next(0, 2) = 0) Then
                        routeString = "0 1 2 3 4 9 14 19 18 17 16 11 12 13 8 7 6 5 10 15 20 21 22 23 24"
                    Else
                        routeString = "4 3 2 1 0 5 10 15 16 17 18 13 12 11 6 7 8 9 14 19 24 23 22 21 20"
                    End If
                End If
            Case KnightInt 'Knights Tour
                Select Case (randObj.Next(0, 8))
                    Case 0
                        routeString = "0 7 4 13 2 9 18 21 10 1 8 19 12 5 16 23 14 3 6 15 22 11 20 17 24"
                    Case 1
                        routeString = "4 7 0 11 22 19 8 1 10 21 18 9 12 15 6 3 14 23 16 5 2 13 24 17 20"
                    Case 2
                        routeString = "0 7 4 13 16 23 14 3 6 15 22 19 12 5 2 9 18 21 10 1 8 11 20 17 24"
                    Case 3
                        routeString = "4 7 0 11 8 1 10 21 18 9 2 5 12 19 22 15 6 3 14 23 16 13 24 17 20"
                    Case 4
                        routeString = "0 7 4 13 22 19 8 1 10 21 18 9 12 15 6 3 14 23 16 5 2 11 20 17 24"
                    Case 5
                        routeString = "4 7 0 11 2 9 18 21 10 1 8 19 12 5 16 23 14 3 6 15 22 13 24 17 20"
                    Case 6
                        routeString = "0 7 4 13 6 15 22 19 8 1 10 21 12 3 14 23 16 5 2 9 18 11 20 17 24"
                    Case 7
                        routeString = "4 7 0 11 18 9 2 5 16 23 14 3 12 21 10 1 8 19 22 15 6 13 24 17 20"
                End Select
            Case Else 'Raster
                If (GetAnswer(PathVertical)) Then
                    routeString = "0 5 10 15 20 1 6 11 16 21 2 7 12 17 22 3 8 13 18 23 4 9 14 19 24"
                Else
                    routeString = "0 1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 20 21 22 23 24"
                End If


        End Select


        'Create path values 0 - 24
        Dim i As Integer
        Dim routeArray() As String = routeString.Split(" ")

        'Swap Pairs
        If (GetAnswer(PathSwapPairs)) Then
            Dim temp As Integer
            For i = 0 To AlphaCount - 3 Step 2
                'Swap 1 and 2, 3 and 4, etc
                temp = routeArray(i + 1)
                routeArray(i + 1) = routeArray(i)
                routeArray(i) = temp
            Next
        End If

        'Checkerboard
        If (GetAnswer(PathCheckerboard)) Then
            Dim tempArray(AlphaCount - 2) As String
            Dim index As Integer = 0
            For i = 0 To AlphaCount - 2
                'Skip every other one, then restart and fill in skipped
                If (i Mod 2 = 0) Then
                    tempArray(index) = routeArray(i)
                Else
                    tempArray(index + 13) = routeArray(i)
                    index += 1
                End If
            Next
            routeArray = tempArray
        End If

        'Fill new array
        Dim newArray(AlphaCount - 2) As Char
        For i = 0 To AlphaCount - 2
            newArray(Microsoft.VisualBasic.Val(routeArray(i))) = oldArray(i)
        Next

        'Reverse?
        If (GetAnswer(PathReverse)) Then
            Array.Reverse(newArray)
        End If

        'Return array
        Return newArray
    End Function

    Function GenerateMapper26() As Char()
        'Remembered Arrays
        Dim CharMapper(AlphaCount - 1) As Char

        'Setup alphabet
        Dim CharList As ArrayList = CreateAlphabetList()

        'Shuffle
        Dim i, current As Integer
        For i = 0 To AlphaCount - 1
            current = randObj.Next(0, CharList.Count)
            CharMapper(i) = CharList(current)
            CharList.RemoveAt(current)
        Next

        Return CharMapper
    End Function

    Function GenerateMapper27() As Char()
        'Remembered Arrays
        Dim CharMapper(AlphaCount) As Char

        'Setup alphabet
        Dim CharList As ArrayList = CreateAlphabetList()
        CharList.Add(" ")

        'Shuffle
        Dim i, current As Integer
        For i = 0 To AlphaCount
            current = randObj.Next(0, CharList.Count)
            CharMapper(i) = CharList(current)
            CharList.RemoveAt(current)
        Next

        Return CharMapper
    End Function

    Function GenerateMapper25() As Char()
        'Remembered Arrays
        Dim CharMapper(AlphaCount - 2) As Char

        'Setup alphabet
        Dim CharList As ArrayList = CreateAlphabetList25()

        'Shuffle
        Dim i, current As Integer
        For i = 0 To AlphaCount - 2
            current = randObj.Next(0, CharList.Count)
            CharMapper(i) = CharList(current)
            CharList.RemoveAt(current)
        Next

        Return CharMapper
    End Function

    Function GenerateMapper25(ByVal theKey As String, Optional ByVal routeMe As Boolean = False) As Char()
        'Will always run route if option is selected

        'Format Key
        theKey = theKey.Replace(LetterToRemove, Get25Char(Asc(LetterToRemove) - AlphaDiff))
        theKey = RemoveDuplicates(RemoveNonLetters(theKey.ToLower))
        Dim KeyArray() As Char = theKey.ToCharArray()

        'Remembered Arrays
        Dim CharMapper(AlphaCount - 2) As Char

        'Setup alphabet
        Dim CharList As ArrayList = CreateAlphabetList25()

        'Enter key followed by alphabet
        Dim i As Integer
        For i = 0 To AlphaCount - 2
            If (i < theKey.Length) Then
                CharMapper(i) = KeyArray(i)
                CharList.RemoveAt(CharList.IndexOf(KeyArray(i)))
            Else
                CharMapper(i) = CharList(0)
                CharList.RemoveAt(0)
            End If
        Next

        'Routed
        If (AlwaysRoute Or routeMe) Then
            CharMapper = CreateRoutes(CharMapper)
        End If

        Return CharMapper
    End Function

    Function GenerateMapper36() As Char()
        'Remembered Arrays
        Dim CharMapper(AlphaCount + NumeralCount - 1) As Char

        'Setup alphabet
        Dim CharList As ArrayList = CreateAlphaNumericList()

        'Shuffle
        Dim i, current As Integer
        For i = 0 To AlphaCount + NumeralCount - 1
            current = randObj.Next(0, CharList.Count)
            CharMapper(i) = CharList(current)
            CharList.RemoveAt(current)
        Next

        Return CharMapper
    End Function

    Function GenerateMapper52() As Char(,)
        'Remembered Arrays
        Dim CharMapper(AlphaCount - 1, 1) As Char

        'Setup alphabet
        Dim CharList As ArrayList = CreateAlphabetAndCapsList()

        'Shuffle
        Dim i, j, current As Integer
        For i = 0 To AlphaCount - 1
            For j = 0 To 1
                current = randObj.Next(0, CharList.Count)
                CharMapper(i, j) = CharList(current)
                CharList.RemoveAt(current)
            Next
        Next

        Return CharMapper
    End Function

    Function PadRandom(ByVal theText As String, ByVal totalLength As Integer) As String
        'Make sure to call seed random before this function
        Dim newLetter As Char
        While (theText.Length < totalLength)
            newLetter = Chr(randObjAsym.Next(0, AlphaCount) + AlphaDiff)
            theText += newLetter
        End While
        Return theText
    End Function

    Function PadFrequency(ByVal theText As String, ByVal totalLength As Integer) As String
        'Create new letter at proper English frequency
        'Make sure to call seed random before this function
        Dim i, x, k As Integer
        While (theText.Length < totalLength)
            x = randObjAsym.Next(0, 1000)
            For k = 0 To AlphaCount - 1
                x -= (FrequencyChart(k) * 1000.0)
                If (x < 0) Then
                    theText += Chr(k + AlphaDiff)
                    Exit For
                End If
            Next
        End While
        Return theText
    End Function

    Function PadToMultiple(ByVal theText As String, ByVal Multiple As Integer, Optional ByVal PadStyle As Integer = PADSTYLES.AlphaRandom) As String
        'Pad the string to a multiple of the "Multiple" input value
        Dim TextLength As Integer = theText.Length
        If (TextLength Mod Multiple <> 0) Then
            Dim PadLength As Integer = Multiple - (TextLength Mod Multiple)
            Dim Output As String = ""
            Select Case PadStyle
                Case PADSTYLES.AlphaRandom
                    Output = PadRandom(theText, TextLength + PadLength)
                Case PADSTYLES.AlphaFrequency
                    Output = PadFrequency(theText, TextLength + PadLength)
                Case PADSTYLES.ZeroesOnly
                    Output = theText.PadRight(TextLength + PadLength, "0")
                Case PADSTYLES.SpacesOnly
                    Output = theText.PadRight(TextLength + PadLength, " ")
                Case PADSTYLES.NumericRandom
                    'not yet implimented
            End Select
            Return Output
        Else
            Return theText
        End If
    End Function

    Function RepeatToMatchLengths(ByVal Shorter As String, ByVal Longer As String) As String
        While (Shorter.Length < Longer.Length)
            Shorter += Shorter
        End While
        Shorter = Shorter.Substring(0, Longer.Length)
        Return Shorter
    End Function

    Function Translate(ByVal theKeyInput As String, ByVal theKeyOutput As String, ByVal thePlainText As String) As String
        'This does not work. Do not use it.

        theKeyInput = RemoveWhiteSpace(theKeyInput.Trim())
        theKeyOutput = RemoveWhiteSpace(theKeyOutput.Trim())
        Dim KeysInput() As String = theKeyInput.Split(" ")
        Dim KeysOutput() As String = theKeyOutput.Split(" ")
        Dim KeysLength As Integer = KeysInput.Length
        If (KeysLength = KeysOutput.Length) Then
            Dim i As Integer
            For i = 0 To KeysLength - 1
                thePlainText = thePlainText.Replace(KeysInput(i), KeysOutput(i))
            Next
        Else
            PostError("Error: Translation protocol not of matching lengths")
            Return "Error"
        End If
    End Function

    Function IsHexidecimal(ByVal Hex As String) As Boolean
        Dim i As Integer
        Dim CharArray() As Char = Hex.ToUpper().ToCharArray()
        For i = 0 To Hex.Length - 1
            If (Not (Char.IsDigit(CharArray(i)) Or (Asc(CharArray(i)) >= 65 And Asc(CharArray(i)) <= 70))) Then
                Return False
            End If
        Next
        Return True
    End Function

    Function IsVowel(ByVal theChar As Char) As Boolean
        theChar = Char.ToLower(theChar)
        If (theChar = "a"c Or theChar = "e"c Or theChar = "i"c Or theChar = "o"c Or theChar = "u"c) Then
            Return True
        Else
            Return False
        End If
    End Function

    Function GenerateStraddlingCheckerboard() As String()
        'Remembered Arrays
        Const StraddleSize As Integer = 28
        Dim StraddlingCB(StraddleSize - 1) As String

        'Setup alphabet
        Dim CharList As ArrayList = CreateAlphabetList()
        CharList.Add(" ")
        CharList.Add(".")
        Dim CommonString As String = ("ESTONIAR").ToLower()

        'Generate straddling checkerboard
        Dim i As Integer
        Dim current, firstdigit1, firstdigit2 As String
        Dim safeValue As Boolean
        firstdigit1 = "0"
        firstdigit2 = "0"
        'Determine first digit for two digit values
        While (firstdigit1 = firstdigit2)
            firstdigit1 = (randObj.Next(0, 10)).ToString()
            firstdigit2 = (randObj.Next(0, 10)).ToString()
        End While
        For i = 0 To CharList.Count - 1
            safeValue = False
            While (Not safeValue)
                current = (randObj.Next(0, 10)).ToString()
                If (CommonString.IndexOf(Chr(i + AlphaDiff)) >= 0) Then 'If Common
                    'Leave current as is
                ElseIf (randObj.Next(0, 2) = 0) Then
                    current = firstdigit1 + current
                Else
                    current = firstdigit2 + current
                End If

                'If the value has not already been taken
                If (Array.IndexOf(StraddlingCB, current) < 0 And Not current = firstdigit1 And Not current = firstdigit2) Then 'If Common
                    safeValue = True
                    StraddlingCB(i) = current
                End If
            End While

        Next

        Return StraddlingCB
    End Function

    Function EncodeFromTabulaRecta(ByVal PlainTextChar As Char, ByVal KeyChar As Char) As Char
        If (Char.IsLetter(PlainTextChar) And Char.IsLetter(KeyChar)) Then
            Return TabulaRecta(CharToDecimal(PlainTextChar), CharToDecimal(KeyChar))
        Else
            'Error: Not a real number delivered
            Return "*"c
        End If
    End Function

    Function DecodeFromTabulaRecta(ByVal CipherChar As Char, ByVal KeyChar As Char) As Char
        If (Char.IsLetter(CipherChar) And Char.IsLetter(KeyChar)) Then
            Dim i As Integer
            For i = 0 To AlphaCount - 1
                If (TabulaRecta(CharToDecimal(KeyChar), i) = CipherChar) Then
                    Return DecimalToChar(i)
                End If
            Next
            Return TabulaRecta(CharToDecimal(CipherChar), CharToDecimal(KeyChar))
        Else
            'Error: Not a real number delivered
            Return "*"c
        End If
    End Function

    Function NonCarryAddition(ByVal RawText As String, Optional ByVal Subtraction As Boolean = False) As String
        Dim KeyLength As Integer = txtKey.Text.Length
        If (KeyLength > 0) Then
            Dim OutputString As String = ""
            Dim FullKeyArray As Char() = txtKey.Text.ToCharArray()
            Dim FullCharArray As Char() = RawText.ToCharArray()
            Dim i, j, a, b As Integer
            j = 0
            For i = 0 To FullCharArray.Length - 1
                If (Char.IsDigit(FullCharArray(i)) And Char.IsDigit(FullKeyArray(j))) Then
                    a = Microsoft.VisualBasic.Val(FullCharArray(i))
                    b = Microsoft.VisualBasic.Val(FullKeyArray(j))
                    If (Subtraction) Then
                        OutputString += ((a + 10 - b) Mod 10).ToString()
                    Else
                        OutputString += ((a + b) Mod 10).ToString()
                    End If
                Else
                    OutputString += FullCharArray(i)
                End If
                j = (j + 1) Mod KeyLength
            Next
            Return OutputString
        Else
            Return RawText
        End If
    End Function

    Function XORBinaryStrings(ByVal Str1 As String, ByVal Str2 As String) As String
        If (Str1.Length = Str2.Length) Then
            Dim CharArray1() As Char = Str1.ToCharArray()
            Dim CharArray2() As Char = Str2.ToCharArray()
            Dim OutputString As String = ""
            Dim i, a, b As Integer
            For i = 0 To Str1.Length - 1
                a = Microsoft.VisualBasic.Val(CharArray1(i))
                b = Microsoft.VisualBasic.Val(CharArray2(i))
                OutputString += (a Xor b).ToString
            Next
            Return OutputString
        Else
            PostError("ERROR: XOR strings not the same length")
            Return "Error"
        End If
    End Function

    Function KeyXOR(ByVal RawText As String) As String
        Dim originalKey As String = ConvertNumbers(txtKey.Text)
        Dim oldKey() As Char = originalKey.ToCharArray()
        Dim newKey As String = ""
        Dim i, j, a, b As Integer

        'Convert key to binary if it starts with text
        For i = 0 To oldKey.Length - 1
            newKey += DecimalToBinary(Asc(oldKey(i)), 5)
        Next

        Dim KeyLength As Integer = newKey.Length
        If (KeyLength > 0) Then
            Dim OutputString As String = ""
            Dim FullKeyArray As Char() = newKey.ToCharArray()
            Dim FullCharArray As Char() = RawText.ToCharArray()
            j = 0
            For i = 0 To FullCharArray.Length - 1
                If (Char.IsDigit(FullCharArray(i)) And Char.IsDigit(FullKeyArray(j))) Then
                    a = Microsoft.VisualBasic.Val(FullCharArray(i))
                    b = Microsoft.VisualBasic.Val(FullKeyArray(j))
                    OutputString += MyXOR(a, b).ToString()
                Else
                    OutputString += FullCharArray(i)
                End If
                j = (j + 1) Mod KeyLength   'wrap around key
            Next
            Return OutputString
        Else
            Return RawText
        End If
    End Function

    Function MyXOR(ByVal num1 As Integer, ByVal num2 As Integer) As Integer
        If ((num1 = 0 And num2 = 0) Or (num1 <> 0 And num2 <> 0)) Then
            Return 0
        Else
            Return 1
        End If
    End Function

    Function FindNextBlank(ByVal curIndex As Integer, ByVal theArray() As Char) As Integer
        curIndex = Array.IndexOf(theArray, WallChar, curIndex)
        If (curIndex = -1) Then
            curIndex = 0
        End If
        curIndex = Array.IndexOf(theArray, WallChar, curIndex)
        Return curIndex
    End Function

    Function OutputTranslation(ByVal Translator As String()) As String
        Dim i As Integer
        Dim OutputString As String = ""
        OutputString += ControlChars.NewLine + ControlChars.NewLine
        OutputString += "Translation Guide: " + ControlChars.NewLine
        For i = 0 To Translator.Length - 1
            OutputString += Char.ToUpper(Chr(i + AlphaDiff)) + " = " + Translator(i) + ",  "
        Next
        Return OutputString
    End Function

    Function OutputTranslation(ByVal PlainText As String, ByVal CipherText As String) As String
        Dim i As Integer
        Dim OutputString As String = ""
        OutputString += ControlChars.NewLine + ControlChars.NewLine
        OutputString += "Translation Guide: " + ControlChars.NewLine
        Dim PlainChars() As Char = PlainText.ToCharArray()
        Dim CipherChars() As Char = CipherText.ToCharArray()
        For i = 0 To Math.Min(PlainChars.Length, CipherChars.Length) - 1
            OutputString += Char.ToUpper(PlainChars(i)) + " = " + Char.ToLower(CipherChars(i)) + ",  "
        Next
        Return OutputString
    End Function

    Function OutputTranslation(ByVal Translator As Char()) As String
        Dim i As Integer
        Dim OutputString As String = ""
        OutputString += ControlChars.NewLine + ControlChars.NewLine
        OutputString += "Translation Guide: " + ControlChars.NewLine
        For i = 0 To Translator.Length - 1
            OutputString += Char.ToUpper(Chr(i + AlphaDiff)) + " = " + Translator(i) + ",  "
        Next
        Return OutputString
    End Function

    Function GetAnswer(ByVal question As Integer) As Boolean
        Return (question = YES Or (question = MAYBE And randObj.Next(0, 2) = 0))
    End Function

    Function Swap(ByRef i As Integer, ByRef j As Integer)
        Dim temp As Integer = i
        i = j
        j = temp
    End Function

    Function Swap(ByRef i As Char, ByRef j As Char)
        Dim temp As Char = i
        i = j
        j = temp
    End Function

    Sub PostError(ByVal theError As String)
        MsgBox("Error: " + theError, MsgBoxStyle.Exclamation, "Error")
    End Sub

#End Region

    '==========='
    '| Ciphers |'
    '==========='

#Region " Alphabetical Squares "
    Function EncodeAlphabeticalSquares(ByVal RawText As String) As String
        RawText = SetTo25(RemoveNonLetters(RawText.ToLower()))
        Dim theKey As String = RemoveNonLetters(txtKey.Text.ToLower())
        Dim FullCharArray() As Char = RawText.ToCharArray()
        Dim OutputString As String = ""
        Dim i, index As Integer
        Dim currentChar As Char
        Dim outChar As Char = LetterToRemove
        Dim backupChar As Char = LetterToRemove
        Dim NumSqTable() As Char
        Dim AlphaArray() As Char = CreateAlphabetArray25()

        'Handle the key if present
        If (theKey <> "") Then
            NumSqTable = GenerateMapper25(theKey)
        Else
            NumSqTable = GenerateMapper25()
        End If

        For i = 0 To FullCharArray.Length - 1
            index = Array.IndexOf(AlphaArray, FullCharArray(i))
            If index = -1 Then
                PostError("Incorrect character encountered")
                Return "Error"
            Else
                'Swap current table value and "standing" value
                currentChar = NumSqTable(index)
                NumSqTable(index) = outChar
                outChar = currentChar
            End If
            OutputString += currentChar
        Next

        Return OutputString
    End Function

    Function DecodeAlphabeticalSquares(ByVal RawText As String) As String
        RawText = RemoveNonLetters(RawText.ToLower())
        Dim theKey As String = RemoveNonLetters(txtKey.Text.ToLower())
        Dim FullCharArray() As Char = RawText.ToCharArray()
        Dim OutputString As String = ""
        Dim i, j, index As Integer
        Dim currentChar, tempChar As Char
        Dim backupChar As Char = LetterToRemove
        Dim outChar As Char = LetterToRemove
        Dim NumSqTable() As Char
        Dim AlphaArray() As Char = CreateAlphabetArray25()

        'Handle the key if present
        If (theKey <> "") Then
            NumSqTable = GenerateMapper25(theKey)
        Else
            NumSqTable = GenerateMapper25()
        End If
        Dim BackupTable(NumSqTable.Length - 1) As Char
        Array.Copy(NumSqTable, BackupTable, NumSqTable.Length)

        For i = 0 To FullCharArray.Length - 1
            index = Array.IndexOf(NumSqTable, FullCharArray(i))
            If index = -1 Then
                PostError("Incorrect character encountered")
                Return "Error"
            Else
                'Swap current table value and "standing" value
                currentChar = AlphaArray(index)
                tempChar = NumSqTable(index)
                NumSqTable(index) = outChar
                outChar = tempChar
            End If
            OutputString += currentChar
        Next

        If (Verbose) Then
            OutputString += ControlChars.NewLine + ControlChars.NewLine
            OutputString += "Initial Grid: " + ControlChars.NewLine
            For i = 0 To 4
                For j = 0 To 4
                    OutputString += BackupTable((i * 5) + j) + " "
                Next
                OutputString += ControlChars.NewLine
            Next
            OutputString += ControlChars.NewLine
            OutputString += "Final Grid: " + ControlChars.NewLine
            For i = 0 To 4
                For j = 0 To 4
                    OutputString += NumSqTable((i * 5) + j) + " "
                Next
                OutputString += ControlChars.NewLine
            Next
        End If

        Return OutputString
    End Function
#End Region

#Region " Typewriter Wars "
    Function EncodeTypewriterWars(ByVal Rawtext As String, Optional ByVal Decode As Boolean = False) As String
        Dim PlainCodex As String = "-_=+qwertyuiop[{]}asdfghjkl;zxcvbnm,./"
        Dim CipherCodex As String = "{[}]',.pyfgcrl/?+=aoeuidhtns:qjkxbmwvz"
        Dim PlainArray() As Char = PlainCodex.ToCharArray()
        Dim CipherArray() As Char = CipherCodex.ToCharArray()
        Dim FullCharArray() As Char = Rawtext.ToLower()
        Dim OutputString As String = ""
        Dim index, i As Integer

        For i = 0 To FullCharArray.Length - 1
            If (Decode) Then
                index = Array.IndexOf(CipherArray, FullCharArray(i))
                If (index > 0) Then
                    OutputString += PlainArray(index)
                Else
                    OutputString += FullCharArray(i)
                End If
            Else
                index = Array.IndexOf(PlainArray, FullCharArray(i))
                If (index > 0) Then
                    OutputString += CipherArray(index)
                Else
                    OutputString += FullCharArray(i)
                End If
            End If
        Next

        If (Decode) Then
            OutputString += OutputTranslation(PlainCodex, CipherCodex)
        End If

        Return OutputString
    End Function
#End Region

#Region " Treasure Map "
    Function EncodeTreasureMap(ByVal RawText As String) As String
        Dim i, startpos, endpos, startrow, startcol, endrow, endcol, deltarow, deltacol, newrowstart, newcolstart, newrowend, newcolend As Integer
        Dim OutputString As String = ""
        RawText = SetTo25(RawText)
        Dim FullCharArray() As Char = RemoveNonLetters(RawText.Trim.ToLower)
        Dim RealWorld() As Char
        Dim TreasureMap() As Char
        Dim currentchar As Char = "a"

        'Handle the key if present
        Dim KeyArray() As String = RemoveWhiteSpace(txtKey.Text).Split(" ")
        If (KeyArray.Length > 1) Then
            RealWorld = GenerateMapper25(KeyArray(0))
            currentchar = KeyArray(0).Substring(KeyArray(0).Length - 1, 1)
            TreasureMap = GenerateMapper25(KeyArray(1))
        ElseIf (KeyArray.Length = 1 And KeyArray(0) <> "") Then
            RealWorld = GenerateMapper25(KeyArray(0))
            currentchar = KeyArray(0).Substring(KeyArray(0).Length - 1, 1)
            TreasureMap = GenerateMapper25()
        Else
            RealWorld = GenerateMapper25()
            TreasureMap = GenerateMapper25()
        End If

        'Initialize startpos to last character of key (or "a" if no key given)
        startpos = Array.IndexOf(RealWorld, currentchar)
        startrow = Math.Floor(startpos / MaxGridValue)
        startcol = startpos Mod MaxGridValue

        For i = 0 To FullCharArray.Length - 1

            endpos = Array.IndexOf(RealWorld, FullCharArray(i))
            endrow = Math.Floor(endpos / MaxGridValue)
            endcol = endpos Mod MaxGridValue

            deltarow = startrow - endrow
            deltacol = startcol - endcol
            If (deltarow < 0) Then
                newrowstart = randObj.Next(0, MaxGridValue + deltarow)
            Else
                newrowstart = randObj.Next(deltarow, MaxGridValue)
            End If
            If (deltacol < 0) Then
                newcolstart = randObj.Next(0, MaxGridValue + deltacol)
            Else
                newcolstart = randObj.Next(deltacol, MaxGridValue)
            End If
            newrowend = newrowstart - deltarow
            newcolend = newcolstart - deltacol
            OutputString += TreasureMap((newrowstart * MaxGridValue) + newcolstart) + TreasureMap((newrowend * MaxGridValue) + newcolend)
            'Prepare for next round
            startrow = endrow
            startcol = endcol
        Next

        Return OutputString
    End Function

    Function DecodeTreasureMap(ByVal RawText As String) As String
        Dim i, j, firstpos, secondpos, deltarow, deltacol, currentpos As Integer
        Dim OutputString As String = ""
        RawText = SetTo25(RawText)
        Dim FullCharArray() As Char = RemoveNonLetters(RawText.Trim.ToLower)
        Dim RealWorld() As Char
        Dim TreasureMap() As Char
        Dim currentchar As Char = "a"

        'Handle the key if present
        Dim KeyArray() As String = RemoveWhiteSpace(txtKey.Text).Split(" ")
        If (KeyArray.Length > 1) Then
            RealWorld = GenerateMapper25(KeyArray(0))
            currentchar = KeyArray(0).Substring(KeyArray(0).Length - 1, 1)
            TreasureMap = GenerateMapper25(KeyArray(1))
        ElseIf (KeyArray.Length = 1 And KeyArray(0) <> "") Then
            RealWorld = GenerateMapper25(KeyArray(0))
            currentchar = KeyArray(0).Substring(KeyArray(0).Length - 1, 1)
            TreasureMap = GenerateMapper25()
        Else
            RealWorld = GenerateMapper25()
            TreasureMap = GenerateMapper25()
        End If

        'Initialize startpos to last character of key
        currentpos = Array.IndexOf(RealWorld, currentchar)

        'Follow map to recreate message
        For i = 0 To FullCharArray.Length - 2 Step 2
            firstpos = Array.IndexOf(TreasureMap, FullCharArray(i))
            secondpos = Array.IndexOf(TreasureMap, FullCharArray(i + 1))
            currentpos = currentpos - (firstpos - secondpos)
            OutputString += RealWorld(currentpos)
        Next

        If (Verbose) Then
            OutputString += ControlChars.NewLine + ControlChars.NewLine
            OutputString += "World grid: " + ControlChars.NewLine
            For i = 0 To 4
                For j = 0 To 4
                    OutputString += RealWorld((i * 5) + j) + " "
                Next
                OutputString += ControlChars.NewLine
            Next
            OutputString += ControlChars.NewLine
            OutputString += "Map grid: " + ControlChars.NewLine
            For i = 0 To 4
                For j = 0 To 4
                    OutputString += TreasureMap((i * 5) + j) + " "
                Next
                OutputString += ControlChars.NewLine
            Next
        End If

        Return OutputString
    End Function

#End Region

#Region " Bacon's Children "

    Function EncodeBaconsChildren(ByVal RawText As String) As String
        RawText = ConvertNumbers(RawText.ToLower.Trim)
        Dim FullCharArray() As Char = RawText.ToCharArray()
        Dim OutputString As String = ""

        'Randomly select false title
        Dim theTitle As String = "Roll Call,Student Body,Prime Suspects,Current Payroll,Potential Recruits,Baby Names,Alpha Team,Guest List,Members,Top Contributers,Client List"
        Dim titleArray() As String = theTitle.Split(",")
        theTitle = titleArray(randObj.Next(0, titleArray.Length))
        OutputString += theTitle + ":" + ControlChars.NewLine

        'Fill names list
        Dim theNames As ArrayList = CreateNamesList()

        'Replace text
        Dim NameOptions As String
        Dim i As Integer
        For i = 0 To FullCharArray.Length - 1
            If (CharToDecimal(FullCharArray(i)) >= 0) Then
                NameOptions = theNames(CharToDecimal(FullCharArray(i)))
                Dim NameArray() As String = NameOptions.Split(" ")
                OutputString += NameArray(randObj.Next(0, NameArray.Length)) + " "
            End If
        Next

        Return OutputString

    End Function

    Function DecodeBaconsChildren(ByVal RawText As String) As String
        RawText = RawText.ToLower.Trim
        Dim OutputString As String = ""

        'Discard false title
        Dim index As Integer = RawText.IndexOf(":")
        If index > 0 Then
            RawText = RawText.Substring(index + 3, RawText.Length - index - 3)
        End If
        Dim FullCharArray() As Char = RawText.ToCharArray()

        'Convert names to binary
        Dim theBinaryName As String = ""
        Dim i As Integer
        For i = 0 To FullCharArray.Length - 1
            If (Char.IsLetter(FullCharArray(i))) Then
                If (Asc(FullCharArray(i)) - AlphaDiff < 13) Then
                    theBinaryName += "0"
                Else
                    theBinaryName += "1"
                End If
                If (theBinaryName.Length >= 5) Then
                    OutputString += Binary5ToASCIIString(theBinaryName)
                    theBinaryName = ""
                End If
            End If
        Next

        Return OutputString

    End Function
#End Region

#Region " Polyfair "

    Function GetNewPolyfairKey(ByVal row1 As Integer, ByVal col1 As Integer, ByVal row2 As Integer, ByVal col2 As Integer, ByVal theArray() As Char) As String
        Dim OutputString As String = ""

        'Find starting position (lowest ASCII value)
        Dim Corners(3) As Char
        Corners(0) = theArray((row1 * 5) + col1)
        Corners(1) = theArray((row1 * 5) + col2)
        Corners(2) = theArray((row2 * 5) + col1)
        Corners(3) = theArray((row2 * 5) + col2)
        Array.Sort(Corners)
        Dim StartChar As Char = Corners(0)
        Dim i, pos1, cur_row, cur_col As Integer
        pos1 = Array.IndexOf(theArray, StartChar)
        cur_row = Math.Floor(pos1 / 5)
        cur_col = pos1 Mod 5
        OutputString += StartChar

        For i = 0 To 3
            'Move clockwise around
            If ((cur_row > row1 Or cur_row > row2) And (cur_col > col1 Or cur_col > col2)) Then
                'in bottom right
                While (cur_row > row1 Or cur_row > row2)
                    'move up
                    cur_row -= 1
                    OutputString += theArray((cur_row * 5) + cur_col)
                End While
            ElseIf ((cur_row < row1 Or cur_row < row2) And (cur_col < col1 Or cur_col < col2)) Then
                'in top left
                While (cur_row < row1 Or cur_row < row2)
                    'move down
                    cur_row += 1
                    OutputString += theArray((cur_row * 5) + cur_col)
                End While
            ElseIf ((cur_row < row1 Or cur_row < row2) And (cur_col > col1 Or cur_col > col2)) Then
                'in top right
                While (cur_col > col1 Or cur_col > col2)
                    'move left
                    cur_col -= 1
                    OutputString += theArray((cur_row * 5) + cur_col)
                End While
            ElseIf ((cur_row > row1 Or cur_row > row2) And (cur_col < col1 Or cur_col < col2)) Then
                'in bottom left
                While (cur_col < col1 Or cur_col < col2)
                    'move right
                    cur_col += 1
                    OutputString += theArray((cur_row * 5) + cur_col)
                End While
            End If
        Next

        Return OutputString
    End Function

    Function EncodePolyfair(ByVal RawText As String, Optional ByVal Decode As Boolean = False) As String
        RawText = RemoveNonLetters(RawText.ToLower())
        RawText = PadToMultiple(RawText, 2, PADSTYLES.AlphaFrequency)
        RawText = SetTo25(RawText)
        Dim FullCharArray() As Char = RawText.ToCharArray()
        Dim OutputString As String = ""
        Dim i, j As Integer
        Dim pos1, pos2, row1, col1, row2, col2, newrow1, newcol1, newrow2, newcol2 As Integer
        Dim char1, char2 As Char
        Dim PolyfairTable() As Char
        Dim currentKey As String = RemoveNonLetters(txtKey.Text)

        If (currentKey = "") Then
            PostError("You must have a key.")
            Return ""
        End If

        For i = 0 To FullCharArray.Length - 1 Step 2
            If (Char.IsLetter(FullCharArray(i)) And Char.IsLetter(FullCharArray(i + 1))) Then
                'Replace double letter 
                If (FullCharArray(i) = FullCharArray(i + 1)) Then
                    If (LetterToRemove <> "x"c) Then
                        FullCharArray(i + 1) = "x"
                    Else
                        FullCharArray(i + 1) = "z"
                    End If
                End If

                SeedRandom()    'Always use same route
                PolyfairTable = GenerateMapper25(currentKey)

                pos1 = Array.IndexOf(PolyfairTable, Get25Char(FullCharArray(i)))
                row1 = Math.Floor(pos1 / 5)
                col1 = pos1 Mod 5
                pos2 = Array.IndexOf(PolyfairTable, Get25Char(FullCharArray(i + 1)))
                row2 = Math.Floor(pos2 / 5)
                col2 = pos2 Mod 5

                If (row1 = row2 And col1 = col2) Then
                    'Error: Should never happen
                    OutputString += "*"
                ElseIf (row1 = row2) Then
                    If (Decode) Then
                        'Move one up
                        newrow1 = (row1 + 5 - 1) Mod 5
                        newrow2 = (row2 + 5 - 1) Mod 5
                    Else
                        'Move one down
                        newrow1 = (row1 + 1) Mod 5
                        newrow2 = (row2 + 1) Mod 5
                    End If
                    OutputString += PolyfairTable((newrow1 * 5) + col1) + PolyfairTable((newrow2 * 5) + col2)
                    currentKey = GetNewPolyfairKey(row1, col1, newrow2, col2, PolyfairTable)
                ElseIf (col1 = col2) Then
                    If (Decode) Then
                        'Move one to the left
                        newcol1 = (col1 + 5 - 1) Mod 5
                        newcol2 = (col2 + 5 - 1) Mod 5
                    Else
                        'Move one to the right
                        newcol1 = (col1 + 1) Mod 5
                        newcol2 = (col2 + 1) Mod 5
                    End If
                    OutputString += PolyfairTable((row1 * 5) + newcol1) + PolyfairTable((row2 * 5) + newcol2)
                    currentKey = GetNewPolyfairKey(row1, col1, row2, newcol2, PolyfairTable)
                Else
                    'Rectangular coordinates
                    OutputString += PolyfairTable((row1 * 5) + col2) + PolyfairTable((row2 * 5) + col1)
                    currentKey = GetNewPolyfairKey(row1, col1, row2, col2, PolyfairTable)
                End If

            End If
        Next

        If (Verbose And Decode) Then
            SeedRandom()    'Always use same route
            PolyfairTable = GenerateMapper25(RemoveNonLetters(txtKey.Text))
            OutputString += ControlChars.NewLine + ControlChars.NewLine
            OutputString += "Initial Grid: " + ControlChars.NewLine
            For i = 0 To 4
                For j = 0 To 4
                    OutputString += PolyfairTable((i * 5) + j) + " "
                Next
                OutputString += ControlChars.NewLine
            Next
        End If

        Return OutputString

    End Function

#End Region

#Region " Trifid "

    Function EncodeTrifid(ByVal RawText As String) As String
        RawText = RemoveAllButSpaces(RawText.ToLower())
        RawText = PadToMultiple(RawText, 3, PADSTYLES.AlphaFrequency)
        Dim FullCharArray() As Char = RawText.ToCharArray()
        Dim OutputString As String = ""
        Dim i, j As Integer
        Dim pos1, row1, col1, depth1 As Integer
        Dim DepthString As String = ""
        Dim RowsString As String = ""
        Dim ColsString As String = ""
        Dim PolybiusCube() As Char

        PolybiusCube = GenerateMapper27()

        For i = 0 To FullCharArray.Length - 1
            If (Char.IsLetter(FullCharArray(i)) Or FullCharArray(i) = " ") Then
                'Find position in polybius square
                pos1 = Array.IndexOf(PolybiusCube, FullCharArray(i))
                depth1 = Math.Floor(pos1 / 9)
                row1 = Math.Floor((pos1 Mod 9) / 3)
                col1 = pos1 Mod 3

                'Divid into depth, row and column values
                DepthString += depth1.ToString
                RowsString += row1.ToString
                ColsString += col1.ToString
            End If
        Next
        Dim NumberArray() As Char = (DepthString + RowsString + ColsString).ToCharArray()
        For i = 0 To NumberArray.Length - 1 Step 3
            'Convert back to letters in polybius square
            OutputString += PolybiusCube((Microsoft.VisualBasic.Val(NumberArray(i)) * 9) + (Microsoft.VisualBasic.Val(NumberArray(i + 1)) * 3) + Microsoft.VisualBasic.Val(NumberArray(i + 2)))
        Next

        Return OutputString
    End Function

    Function DecodeTrifid(ByVal RawText As String) As String
        RawText = RemoveAllButSpaces(RawText.ToLower())
        Dim FullCharArray() As Char = RawText.ToCharArray()
        Dim OutputString As String = ""
        Dim i, j, k As Integer
        Dim pos1, row1, col1, depth1 As Integer
        Dim FullString As String = ""
        Dim DepthsString() As Char
        Dim RowsString() As Char
        Dim ColsString() As Char
        Dim PolybiusCube() As Char

        PolybiusCube = GenerateMapper27()

        For i = 0 To FullCharArray.Length - 1
            If (Char.IsLetter(FullCharArray(i)) Or FullCharArray(i) = " ") Then
                'Find position in polybius square
                pos1 = Array.IndexOf(PolybiusCube, FullCharArray(i))
                depth1 = Math.Floor(pos1 / 9)
                row1 = Math.Floor((pos1 Mod 9) / 3)
                col1 = pos1 Mod 3

                'Convert into two digit number
                FullString += depth1.ToString + row1.ToString + col1.ToString
            End If
        Next
        Dim Thirdway As Integer = FullString.Length / 3
        DepthsString = FullString.Substring(0, Thirdway).ToCharArray()
        RowsString = FullString.Substring(Thirdway, Thirdway).ToCharArray()
        ColsString = FullString.Substring(Thirdway * 2, Thirdway).ToCharArray()
        For i = 0 To RowsString.Length - 1
            'Convert back to letters in polybius square
            OutputString += PolybiusCube((Microsoft.VisualBasic.Val(DepthsString(i)) * 9) + (Microsoft.VisualBasic.Val(RowsString(i)) * 3) + Microsoft.VisualBasic.Val(ColsString(i)))
        Next

        If (Verbose) Then
            OutputString += ControlChars.NewLine + ControlChars.NewLine
            OutputString += "Cubic grid (shown as three square grids): " + ControlChars.NewLine
            For i = 0 To 2
                For j = 0 To 2
                    For k = 0 To 2
                        OutputString += PolybiusCube((i * 9) + (j * 3) + k) + " "
                    Next
                    OutputString += ControlChars.NewLine
                Next
                OutputString += ControlChars.NewLine
            Next
        End If

        Return OutputString
    End Function

#End Region

#Region " Bifid "

    Function EncodeBifid(ByVal RawText As String) As String
        RawText = RemoveNonLetters(RawText.ToLower())
        RawText = SetTo25(RawText)
        Dim FullCharArray() As Char = RawText.ToCharArray()
        Dim OutputString As String = ""
        Dim i, j As Integer
        Dim pos1, row1, col1 As Integer
        Dim RowsString As String = ""
        Dim ColsString As String = ""
        Dim PolybiusSq() As Char

        If (txtKey.Text = "") Then
            PolybiusSq = GenerateMapper25()
        Else
            PolybiusSq = GenerateMapper25(txtKey.Text)
        End If

        For i = 0 To FullCharArray.Length - 1
            If (Char.IsLetter(FullCharArray(i))) Then
                'Find position in polybius square
                pos1 = Array.IndexOf(PolybiusSq, Get25Char(FullCharArray(i)))
                row1 = Math.Floor(pos1 / 5)
                col1 = pos1 Mod 5

                'Divid into row values and column values
                RowsString += row1.ToString
                ColsString += col1.ToString
            End If
        Next
        Dim NumberArray() As Char = (RowsString + ColsString).ToCharArray()
        For i = 0 To NumberArray.Length - 1 Step 2
            'Convert back to letters in polybius square
            OutputString += PolybiusSq((Microsoft.VisualBasic.Val(NumberArray(i)) * 5) + Microsoft.VisualBasic.Val(NumberArray(i + 1)))
        Next

        Return OutputString
    End Function

    Function DecodeBifid(ByVal RawText As String) As String
        RawText = RemoveNonLetters(RawText.ToLower())
        RawText = SetTo25(RawText)
        Dim FullCharArray() As Char = RawText.ToCharArray()
        Dim OutputString As String = ""
        Dim i, j As Integer
        Dim pos1, row1, col1 As Integer
        Dim FullString As String = ""
        Dim RowsString() As Char
        Dim ColsString() As Char
        Dim PolybiusSq() As Char

        If (txtKey.Text = "") Then
            PolybiusSq = GenerateMapper25()
        Else
            PolybiusSq = GenerateMapper25(txtKey.Text)
        End If

        For i = 0 To FullCharArray.Length - 1
            If (Char.IsLetter(FullCharArray(i))) Then
                'Find position in polybius square
                pos1 = Array.IndexOf(PolybiusSq, Get25Char(FullCharArray(i)))
                row1 = Math.Floor(pos1 / 5)
                col1 = pos1 Mod 5

                'Convert into two digit number
                FullString += row1.ToString + col1.ToString
            End If
        Next
        Dim Halfway As Integer = FullString.Length / 2
        RowsString = FullString.Substring(0, Halfway).ToCharArray()
        ColsString = FullString.Substring(Halfway, Halfway).ToCharArray()
        For i = 0 To RowsString.Length - 1
            'Convert back to letters in polybius square
            OutputString += PolybiusSq((Microsoft.VisualBasic.Val(RowsString(i)) * 5) + Microsoft.VisualBasic.Val(ColsString(i)))
        Next

        If (Verbose) Then
            OutputString += ControlChars.NewLine + ControlChars.NewLine
            OutputString += "Grid: " + ControlChars.NewLine
            For i = 0 To 4
                For j = 0 To 4
                    OutputString += PolybiusSq((i * 5) + j) + " "
                Next
                OutputString += ControlChars.NewLine
            Next
        End If

        Return OutputString
    End Function

#End Region

#Region " Skip Rope "
    Function EncodeSkipRope(ByVal RawText As String) As String
        'This version used 8 bit ASCII (rather than 5) and is currently not used
        Dim BinaryKey As String = ASCIIStringToBinary(txtKey.Text.Trim)
        Dim BinaryMsg As String = ASCIIStringToBinary(RawText.Trim)
        Dim MsgChars() As Char = BinaryMsg.ToCharArray()
        Dim MsgLength As Integer = BinaryMsg.Length
        Dim BinaryOutput(MsgLength - 1) As Char

        'Initialize output
        Dim i As Integer
        For i = 0 To MsgLength - 1
            BinaryOutput(i) = WallChar
        Next

        'Set Key to use message and trim to same size
        BinaryKey = BinaryKey + BinaryMsg
        BinaryKey = BinaryKey.Substring(0, MsgLength)
        Dim KeyChars() As Char = BinaryKey.ToCharArray()

        Dim count As Integer = 0
        Dim hop As Char
        Dim currentIndex As Integer = 0
        While (count < MsgLength)
            'Find next open slot
            currentIndex = FindNextBlank(currentIndex + 1, BinaryOutput)
            If (KeyChars(count) = "1"c) Then 'Skip a blank
                currentIndex = FindNextBlank(currentIndex + 1, BinaryOutput)
            End If
            BinaryOutput(currentIndex) = MsgChars(count)
            count += 1
        End While

        Dim BinaryString As String = BinaryOutput
        Dim OutputString As String = BinaryToHexString(BinaryString)

        Return OutputString
    End Function

    Function DecodeSkipRope(ByVal RawText As String) As String
        'This version used 8 bit ASCII (rather than 5) and is currently not used
        Dim BinaryKey As String = ASCIIStringToBinary(txtKey.Text.Trim)
        Dim BinaryMsg As String = HexStringToBinary(RawText.Trim)
        Dim MsgChars() As Char = BinaryMsg.ToCharArray()
        Dim MsgLength As Integer = BinaryMsg.Length
        Dim WallHolder(MsgLength - 1) As Char
        Dim BinaryOutput As String = ""

        'Initialize WallHolder
        Dim i As Integer
        For i = 0 To MsgLength - 1
            WallHolder(i) = WallChar
        Next

        'Create key arraylist
        Dim KeyChars() As Char = BinaryKey.ToCharArray()
        Dim KeyArrayList As New ArrayList
        For i = 0 To BinaryKey.Length - 1
            KeyArrayList.Add(KeyChars(i))
        Next

        Dim count As Integer = 0
        Dim hop As Char
        Dim currentIndex As Integer = 0
        While (count < MsgLength)
            'Find next open slot
            currentIndex = FindNextBlank(currentIndex + 1, WallHolder)
            If (KeyArrayList(count) = "1"c) Then 'Skip a blank
                currentIndex = FindNextBlank(currentIndex + 1, WallHolder)
            End If
            WallHolder(currentIndex) = "0"
            BinaryOutput += MsgChars(currentIndex)
            KeyArrayList.Add(MsgChars(currentIndex))
            count += 1
        End While

        Dim OutputString As String = BinaryToASCIIString(BinaryOutput)

        Return OutputString
    End Function

    Function CreateSkipRopeKey(ByVal theKey As String, ByVal Msg() As Char) As ArrayList
        Dim KeyChars() As Char = ASCIIStringToBinary5(theKey.Trim).ToCharArray
        Dim OutputArrayList As New ArrayList(KeyChars)
        Dim i As Integer
        For i = 0 To Msg.Length - 1
            OutputArrayList.Add(KeyChars(i Mod KeyChars.Length))
            OutputArrayList.Add(Msg(i))
        Next
        Return OutputArrayList
    End Function

    Function EncodeSkipRope2(ByVal RawText As String) As String
        Dim BinaryMsg As String = ASCIIStringToBinary5(RawText.Trim)
        Dim MsgChars() As Char = BinaryMsg.ToCharArray()
        Dim MsgLength As Integer = BinaryMsg.Length
        Dim BinaryOutput(MsgLength - 1) As Char

        'Initialize output
        Dim i As Integer
        For i = 0 To MsgLength - 1
            BinaryOutput(i) = WallChar
        Next

        'Initialize key
        Dim KeyArrayList As ArrayList = CreateSkipRopeKey(txtKey.Text, MsgChars)

        Dim msgPos As Integer = 0
        Dim hops As Integer = 0
        Dim currentIndex As Integer = 0
        While (msgPos < MsgLength)
            'Find next slot that we have not read from
            hops = BinaryToDecimal(KeyArrayList(msgPos * 2)) + BinaryToDecimal(KeyArrayList(msgPos * 2 + 1))
            For i = 0 To hops
                'Hop over a number of blanks equal to two digits from the key
                currentIndex = FindNextBlank(currentIndex + 1, BinaryOutput)
            Next
            BinaryOutput(currentIndex) = MsgChars(msgPos)
            msgPos += 1
        End While

        Dim BinaryString As String = BinaryOutput
        Dim OutputString As String = Binary5ToASCIIString(BinaryString)

        Return OutputString
    End Function

    Function DecodeSkipRope2(ByVal RawText As String) As String
        Dim BinaryKey As String = ASCIIStringToBinary5(txtKey.Text.Trim)
        Dim BinaryMsg As String = ASCIIStringToBinary5(RawText.Trim)
        Dim MsgChars() As Char = BinaryMsg.ToCharArray()
        Dim MsgLength As Integer = BinaryMsg.Length
        Dim WallHolder(MsgLength - 1) As Char
        Dim BinaryOutput As String = ""

        'Initialize WallHolder
        Dim i As Integer
        For i = 0 To MsgLength - 1
            WallHolder(i) = WallChar
        Next

        'Initialize key arraylist (more will be added to it as we go)
        Dim KeyChars() As Char = BinaryKey.ToCharArray()
        Dim KeyArrayList As New ArrayList
        For i = 0 To BinaryKey.Length - 1
            KeyArrayList.Add(KeyChars(i))
        Next

        Dim msgPos As Integer = 0
        Dim hops As Integer
        Dim currentIndex As Integer = 0
        While (msgPos < MsgLength)
            'Find next open slot
            hops = BinaryToDecimal(KeyArrayList(msgPos * 2)) + BinaryToDecimal(KeyArrayList(msgPos * 2 + 1))
            For i = 0 To hops
                'Hop over a number of blanks equal to two digits from the key
                currentIndex = FindNextBlank(currentIndex + 1, WallHolder)
            Next
            WallHolder(currentIndex) = "0"
            BinaryOutput += MsgChars(currentIndex)
            'Feed back msg so far into key arraylist
            KeyArrayList.Add(KeyChars(msgPos Mod KeyChars.Length))
            KeyArrayList.Add(MsgChars(currentIndex))
            msgPos += 1
        End While

        Dim OutputString As String = Binary5ToASCIIString(BinaryOutput)

        Return OutputString
    End Function

#End Region

#Region " Voweliant "

    Function EncodeVoweliant(ByVal RawText As String) As String
        Dim theKey As String = txtKey.Text.Trim()
        If (theKey.Length >= ByteSize) Then
            Dim i, j As Integer
            theKey = theKey.Substring(0, ByteSize)
            Dim KeyVowels As String = ConvertToVowelBinary(theKey)
            Dim KeyASCIILength As Integer = theKey.Length
            theKey = ASCIIStringToBinary(theKey)

            'The message
            RawText = RawText.Trim()
            RawText = PadToMultiple(RawText, ByteSize, PADSTYLES.SpacesOnly)
            Dim theMessage As String = ASCIIStringToBinary(RawText)
            Dim MsgVowels As String = ConvertToVowelBinary(RawText)

            'Match lengths
            KeyVowels = RepeatToMatchLengths(KeyVowels, theKey)
            'Xor to get fullkey
            Dim FullKey As String = XORBinaryStrings(theKey, KeyVowels)

            'Divide message into 64 bit chunks
            Dim CurrentMsgBlock, LastMsgBlock As String
            Dim CurrentVwlBlock, ScrambledVwlBlock As String
            Dim BinaryOutput As String = ""
            Dim VowelChars(BlockBitSize - 1) As Char
            For i = 0 To (RawText.Length / ByteSize) - 1
                CurrentMsgBlock = theMessage.Substring(i * BlockBitSize, BlockBitSize)
                If (i = 0) Then
                    'Prime the pump
                    BinaryOutput += XORBinaryStrings(CurrentMsgBlock, FullKey)
                Else
                    CurrentVwlBlock = MsgVowels.Substring((i - 1) * ByteSize, ByteSize)
                    'Repeat eight times
                    CurrentVwlBlock = RepeatToMatchLengths(CurrentVwlBlock, CurrentMsgBlock)
                    CurrentVwlBlock = XORBinaryStrings(CurrentVwlBlock, FullKey)
                    'Run Voweliant Permutation
                    VowelChars = CurrentVwlBlock.ToCharArray
                    ScrambledVwlBlock = ""
                    For j = 0 To BlockBitSize - 1
                        ScrambledVwlBlock += VowelChars(VowelKeyTable(j))
                    Next
                    BinaryOutput += XORBinaryStrings(XORBinaryStrings(CurrentMsgBlock, ScrambledVwlBlock), LastMsgBlock)
                End If
                LastMsgBlock = CurrentMsgBlock
            Next

            Return BinaryToHexString(BinaryOutput)

        Else
            PostError("The key must be at eight characters long.")
            Return ""
        End If
    End Function

    Function DecodeVoweliant(ByVal RawText As String) As String
        Dim theKey As String = txtKey.Text.Trim()
        If (theKey.Length >= ByteSize) Then
            theKey = theKey.Substring(0, ByteSize)
            Dim KeyVowels As String = ConvertToVowelBinary(theKey)
            Dim KeyASCIILength As Integer = theKey.Length
            theKey = ASCIIStringToBinary(theKey)

            'The message
            Dim theMessage As String = HexStringToBinary(RawText)
            theMessage = PadToMultiple(theMessage, BlockBitSize, PADSTYLES.ZeroesOnly)

            'Match lengths
            KeyVowels = RepeatToMatchLengths(KeyVowels, theKey)
            'Xor to get fullkey
            Dim FullKey As String = XORBinaryStrings(theKey, KeyVowels)

            'Divide message into 64 bit chunks
            Dim CurrentMsgBlock, LastMsgBlock As String
            Dim CurrentVwlBlock, ScrambledVwlBlock, CurrentOutBlock As String
            Dim BinaryOutput As String = ""
            Dim VowelChars(BlockBitSize - 1) As Char
            Dim i, j As Integer
            For i = 0 To (theMessage.Length / BlockBitSize) - 1
                CurrentMsgBlock = theMessage.Substring(i * BlockBitSize, BlockBitSize)
                If (i = 0) Then
                    'Prime the pump
                    CurrentOutBlock = XORBinaryStrings(CurrentMsgBlock, FullKey)
                Else
                    CurrentOutBlock = XORBinaryStrings(XORBinaryStrings(CurrentMsgBlock, ScrambledVwlBlock), LastMsgBlock)
                End If
                LastMsgBlock = CurrentOutBlock
                CurrentVwlBlock = ConvertToVowelBinary(BinaryToASCIIString(CurrentOutBlock))
                CurrentVwlBlock = RepeatToMatchLengths(CurrentVwlBlock, CurrentMsgBlock)
                CurrentVwlBlock = XORBinaryStrings(CurrentVwlBlock, FullKey)
                'Run Voweliant Permutation
                VowelChars = CurrentVwlBlock.ToCharArray
                ScrambledVwlBlock = ""
                For j = 0 To BlockBitSize - 1
                    ScrambledVwlBlock += VowelChars(VowelKeyTable(j))
                Next
                BinaryOutput += CurrentOutBlock
            Next

            Dim OutputString As String = ""

            If (Verbose) Then

            End If

            OutputString += BinaryToASCIIString(BinaryOutput)

            Return OutputString

        Else
            PostError("The key must be at eight characters long.")
            Return ""
        End If

    End Function
#End Region

#Region " Route "
    Function EncodeRoute(ByVal RawText As String, Optional ByVal Decode As Boolean = False) As String
        RawText = RemoveNonLetters(RawText.ToLower())
        RawText = SetTo25(RawText)
        RawText = PadToMultiple(RawText, 25, PADSTYLES.AlphaFrequency)
        Dim WriteTable() As Char = GenerateMapper25("a", True)
        Dim ReadTable() As Char = GenerateMapper25("a", True)
        Dim TempArray(AlphaCount - 2) As Char

        Dim i, j As Integer
        Dim CurrentCharBlock() As Char
        Dim OutputString As String = ""
        For i = 0 To RawText.Length - 1 Step 25
            CurrentCharBlock = RawText.ToCharArray(i, 25)
            For j = 0 To WriteTable.Length - 1
                If (Decode) Then
                    TempArray(Get25ArrayValue(ReadTable(j))) = CurrentCharBlock(j)
                Else
                    TempArray(Get25ArrayValue(WriteTable(j))) = CurrentCharBlock(j)
                End If
            Next
            For j = 0 To ReadTable.Length - 1
                If (Decode) Then
                    OutputString += TempArray(Get25ArrayValue(WriteTable(j)))
                Else
                    OutputString += TempArray(Get25ArrayValue(ReadTable(j)))
                End If
            Next
        Next

        If (Verbose And Decode) Then
            OutputString += ControlChars.NewLine + ControlChars.NewLine
            OutputString += "Order to write into grid: " + ControlChars.NewLine
            For i = 0 To 4
                For j = 0 To 4
                    OutputString += WriteTable((i * 5) + j) + " "
                Next
                OutputString += ControlChars.NewLine
            Next
            OutputString += ControlChars.NewLine
            OutputString += "Order to read out of grid: " + ControlChars.NewLine
            For i = 0 To 4
                For j = 0 To 4
                    OutputString += ReadTable((i * 5) + j) + " "
                Next
                OutputString += ControlChars.NewLine
            Next
        End If

        Return OutputString
    End Function
#End Region

#Region " Four Square "
    Function EncodeFourSquare(ByVal RawText As String, Optional ByVal Decode As Boolean = False) As String
        RawText = RemoveNonLetters(RawText.ToLower())
        RawText = SetTo25(RawText)
        Dim FullCharArray() As Char = RawText.ToCharArray()
        Dim OutputString As String = ""
        Dim i, j As Integer
        'Dim theBigram As String = ""
        Dim pos1, pos2, row1, col1, row2, col2, newrow, newcol As Integer
        Dim char1, char2 As Char
        Dim FourSqTable1() As Char
        Dim FourSqTable2() As Char
        Dim RegularAlphabet() As Char = CreateAlphabetArray25()

        'Handle the key if present
        Dim KeyArray() As String = RemoveWhiteSpace(txtKey.Text).Split(" ")
        If (KeyArray.Length > 1) Then
            FourSqTable1 = GenerateMapper25(KeyArray(0))
            FourSqTable2 = GenerateMapper25(KeyArray(1))
        ElseIf (KeyArray.Length = 1 And KeyArray(0) <> "") Then
            FourSqTable1 = GenerateMapper25(KeyArray(0))
            FourSqTable2 = GenerateMapper25()
        Else
            FourSqTable1 = GenerateMapper25()
            FourSqTable2 = GenerateMapper25()
        End If

        For i = 0 To FullCharArray.Length - 2
            If (Char.IsLetter(FullCharArray(i)) And Char.IsLetter(FullCharArray(i + 1))) Then

                If (Decode) Then
                    pos1 = Array.IndexOf(FourSqTable1, Get25Char(FullCharArray(i)))
                    pos2 = Array.IndexOf(FourSqTable2, Get25Char(FullCharArray(i + 1)))
                Else
                    pos1 = Get25ArrayValue(FullCharArray(i))
                    pos2 = Get25ArrayValue(FullCharArray(i + 1))

                End If
                row1 = Math.Floor(pos1 / 5)
                col1 = pos1 Mod 5
                row2 = Math.Floor(pos2 / 5)
                col2 = pos2 Mod 5
                'Rectangular coordinates
                If (Decode) Then
                    OutputString += RegularAlphabet((row1 * 5) + col2) + RegularAlphabet((row2 * 5) + col1)
                Else
                    OutputString += FourSqTable1((row1 * 5) + col2) + FourSqTable2((row2 * 5) + col1)
                End If
            End If
            i += 1
        Next

        If (Verbose And Decode) Then
            OutputString += ControlChars.NewLine + ControlChars.NewLine
            OutputString += "Grids: " + ControlChars.NewLine
            For i = 0 To 4
                For j = 0 To 4
                    OutputString += RegularAlphabet((i * 5) + j) + " "
                Next
                OutputString += "   "
                For j = 0 To 4
                    OutputString += FourSqTable1((i * 5) + j) + " "
                Next
                OutputString += ControlChars.NewLine
            Next
            OutputString += ControlChars.NewLine
            For i = 0 To 4
                For j = 0 To 4
                    OutputString += FourSqTable2((i * 5) + j) + " "
                Next
                OutputString += "   "
                For j = 0 To 4
                    OutputString += RegularAlphabet((i * 5) + j) + " "
                Next
                OutputString += ControlChars.NewLine
            Next
        End If

        Return OutputString

    End Function

#End Region

#Region " Two Square "
    Function EncodeTwoSquare(ByVal RawText As String, Optional ByVal Decode As Boolean = False) As String
        RawText = RemoveNonLetters(RawText.ToLower())
        RawText = SetTo25(RawText)
        Dim FullCharArray() As Char = RawText.ToCharArray()
        Dim OutputString As String = ""
        Dim i, j As Integer
        Dim pos1, pos2, row1, col1, row2, col2, newrow, newcol As Integer
        Dim char1, char2 As Char
        Dim TwoSqTable1() As Char
        Dim TwoSqTable2() As Char

        'Handle the key if present
        Dim KeyArray() As String = RemoveWhiteSpace(txtKey.Text).Split(" ")
        If (KeyArray.Length > 1) Then
            TwoSqTable1 = GenerateMapper25(KeyArray(0))
            TwoSqTable2 = GenerateMapper25(KeyArray(1))
        ElseIf (KeyArray.Length = 1 And KeyArray(0) <> "") Then
            TwoSqTable1 = GenerateMapper25(KeyArray(0))
            TwoSqTable2 = GenerateMapper25()
        Else
            TwoSqTable1 = GenerateMapper25()
            TwoSqTable2 = GenerateMapper25()
        End If

        For i = 0 To FullCharArray.Length - 2
            If (Char.IsLetter(FullCharArray(i)) And Char.IsLetter(FullCharArray(i + 1))) Then

                pos1 = Array.IndexOf(TwoSqTable1, Get25Char(FullCharArray(i)))
                row1 = Math.Floor(pos1 / 5)
                col1 = pos1 Mod 5
                pos2 = Array.IndexOf(TwoSqTable2, Get25Char(FullCharArray(i + 1)))
                row2 = Math.Floor(pos2 / 5)
                col2 = pos2 Mod 5

                If (col1 = col2) Then
                    'Leave as is
                    OutputString += FullCharArray(i) + FullCharArray(i + 1)
                Else
                    'Rectangular coordinates
                    OutputString += TwoSqTable1((row1 * 5) + col2) + TwoSqTable2((row2 * 5) + col1)
                End If

            End If
            i += 1
        Next

        If (Verbose And Decode) Then
            OutputString += ControlChars.NewLine + ControlChars.NewLine
            OutputString += "Grids: " + ControlChars.NewLine
            For i = 0 To 4
                For j = 0 To 4
                    OutputString += TwoSqTable1((i * 5) + j) + " "
                Next
                OutputString += ControlChars.NewLine
            Next
            OutputString += ControlChars.NewLine
            For i = 0 To 4
                For j = 0 To 4
                    OutputString += TwoSqTable2((i * 5) + j) + " "
                Next
                OutputString += ControlChars.NewLine
            Next
        End If

        Return OutputString

    End Function

#End Region

#Region " Playfair "

    Function EncodePlayfair(ByVal RawText As String, Optional ByVal Decode As Boolean = False) As String
        RawText = RemoveNonLetters(RawText.ToLower())
        RawText = SetTo25(RawText)
        Dim FullCharArray() As Char = RawText.ToCharArray()
        Dim OutputString As String = ""
        Dim i, j As Integer
        'Dim theBigram As String = ""
        Dim pos1, pos2, row1, col1, row2, col2 As Integer
        Dim char1, char2 As Char
        Dim PlayfairTable() As Char

        If (txtKey.Text = "") Then
            PlayfairTable = GenerateMapper25()
        Else
            PlayfairTable = GenerateMapper25(txtKey.Text)
        End If

        For i = 0 To FullCharArray.Length - 2
            If (Char.IsLetter(FullCharArray(i)) And Char.IsLetter(FullCharArray(i + 1))) Then
                'Replace double letter 
                If (FullCharArray(i) = FullCharArray(i + 1)) Then
                    If (LetterToRemove <> "x"c) Then
                        FullCharArray(i + 1) = "x"
                    Else
                        FullCharArray(i + 1) = "z"
                    End If
                End If

                pos1 = Array.IndexOf(PlayfairTable, Get25Char(FullCharArray(i)))
                row1 = Math.Floor(pos1 / 5)
                col1 = pos1 Mod 5
                pos2 = Array.IndexOf(PlayfairTable, Get25Char(FullCharArray(i + 1)))
                row2 = Math.Floor(pos2 / 5)
                col2 = pos2 Mod 5

                If (row1 = row2 And col1 = col2) Then
                    'Error: Should never happen
                    OutputString += "*"
                ElseIf (row1 = row2) Then
                    If (Decode) Then
                        'Move one to the left
                        col1 = (col1 + 5 - 1) Mod 5
                        col2 = (col2 + 5 - 1) Mod 5
                    Else
                        'Move one to the right
                        col1 = (col1 + 1) Mod 5
                        col2 = (col2 + 1) Mod 5
                    End If
                    OutputString += PlayfairTable((row1 * 5) + col1) + PlayfairTable((row2 * 5) + col2)
                ElseIf (col1 = col2) Then
                    If (Decode) Then
                        'Move one up
                        row1 = (row1 + 5 - 1) Mod 5
                        row2 = (row2 + 5 - 1) Mod 5
                    Else
                        'Move one down
                        row1 = (row1 + 1) Mod 5
                        row2 = (row2 + 1) Mod 5
                    End If
                    OutputString += PlayfairTable((row1 * 5) + col1) + PlayfairTable((row2 * 5) + col2)
                Else
                    'Rectangular coordinates
                    OutputString += PlayfairTable((row1 * 5) + col2) + PlayfairTable((row2 * 5) + col1)
                End If

            End If
            i += 1
        Next

        If (Verbose And Decode) Then
            OutputString += ControlChars.NewLine + ControlChars.NewLine
            OutputString += "Grid: " + ControlChars.NewLine
            For i = 0 To 4
                For j = 0 To 4
                    OutputString += PlayfairTable((i * 5) + j) + " "
                Next
                OutputString += ControlChars.NewLine
            Next
        End If

        Return OutputString

    End Function

#End Region

#Region " Radiotelephony "

    Function EncodeRadiotelephony(ByVal RawText As String) As String
        RawText = RawText.ToLower()
        Dim FullCharArray() As Char = RawText.ToCharArray()
        Dim Telephony As String = "Alpha Bravo Charlie Delta Echo Foxtrot Golf Hotel India Juliett Kilo Lima Mike November Oscar Papa Quebec Romeo Sierra Tango Uniform Victor Whiskey Xray Yankee Zulu"
        Dim TelephonyArray() As String = Telephony.Split(" ")
        Dim OutputString As String = ""
        Dim i As Integer

        OutputString = ReplacePunctuation(OutputString)

        For i = 0 To FullCharArray.Length - 1
            If (Char.IsLetter(FullCharArray(i))) Then
                OutputString += TelephonyArray(Asc(FullCharArray(i)) - AlphaDiff) + " "
            ElseIf (Char.IsDigit(FullCharArray(i))) Then
                OutputString += ConvertNumbers(FullCharArray(i))
            Else
                OutputString += FullCharArray(i)
            End If
        Next

        Return OutputString
    End Function

    Function DecodeRadiotelephony(ByVal RawText As String) As String
        Dim Telephony As String = "Alpha Bravo Charlie Delta Echo Foxtrot Golf Hotel India Juliett Kilo Lima Mike November Oscar Papa Quebec Romeo Sierra Tango Uniform Victor Whiskey Xray Yankee Zulu"
        Dim TelephonyArray() As String = Telephony.Split(" ")
        Dim OutputString As String = ""
        Dim i As Integer

        For i = 0 To TelephonyArray.Length - 1
            RawText = RawText.Replace(TelephonyArray(i), Chr(i + AlphaDiff))
        Next
        RawText = RawText.Replace(" ", "")

        Return RawText
    End Function
#End Region

#Region " ADFGVX "
    Function Get_ADFGVX_Number(ByVal theValue As Integer) As Char
        Select Case theValue
            Case 0
                Return "A"c
            Case 1
                Return "D"c
            Case 2
                Return "F"c
            Case 3
                Return "G"c
            Case 4
                Return "V"c
            Case 5
                Return "X"c
            Case Else
                Return "*"c
        End Select
    End Function

    Function EncodeADFGVX(ByVal RawText As String) As String
        RawText = RemoveWhiteSpace(RawText.ToLower)
        Dim i, j, asciiValue As Integer
        Dim CharMapper As Char() = GenerateMapper36()
        Dim ADFGVXMapper(AlphaCount + NumeralCount - 1) As String
        Dim FullCharArray() As Char
        FullCharArray = RawText.ToCharArray
        Dim OutputString As String = ""

        'Setup letter pairs
        For i = 0 To 5
            For j = 0 To 5
                ADFGVXMapper((i * 6) + j) = Get_ADFGVX_Number(i) + Get_ADFGVX_Number(j)
            Next
        Next

        'Scramble letters
        For i = 0 To FullCharArray.Length - 1
            If (Char.IsLetter(FullCharArray(i))) Then
                asciiValue = Asc(FullCharArray(i)) - AlphaDiff
                FullCharArray(i) = CharMapper(asciiValue)
            ElseIf (Char.IsDigit(FullCharArray(i))) Then
                asciiValue = Asc(FullCharArray(i)) - NumeralDiff + AlphaCount
                FullCharArray(i) = CharMapper(asciiValue)
            End If
        Next

        'Replace with ADFGVX characters
        For i = 0 To FullCharArray.Length - 1
            If (Char.IsLetter(FullCharArray(i))) Then
                asciiValue = Asc(FullCharArray(i)) - AlphaDiff
                OutputString += ADFGVXMapper(asciiValue)
            ElseIf (Char.IsDigit(FullCharArray(i))) Then
                asciiValue = Asc(FullCharArray(i)) - NumeralDiff + AlphaCount
                OutputString += ADFGVXMapper(asciiValue)
            End If
        Next

        'Transposition
        OutputString = EncodeColumnar(OutputString)

        Return OutputString.ToUpper
    End Function

    Function DecodeADFGVX(ByVal RawText As String) As String
        RawText = RemoveWhiteSpace(RawText.ToLower)
        Dim i, j, index, asciiValue As Integer
        Dim alphaPair As String
        Dim CharMapper As Char() = GenerateMapper36()
        Dim ADFGVXMapper(AlphaCount + NumeralCount - 1) As String
        Dim OutputString As String = ""

        'Setup letter pairs
        For i = 0 To 5
            For j = 0 To 5
                ADFGVXMapper((i * 6) + j) = Get_ADFGVX_Number(i) + Get_ADFGVX_Number(j)
            Next
        Next

        'Transposition
        RawText = DecodeColumnar(RawText)
        Dim FullCharArray() As Char = RawText.ToCharArray

        'Replace ADFGVX with alphanumeric characters
        Dim MidwayString As String = ""
        For i = 0 To FullCharArray.Length - 2
            alphaPair = (FullCharArray(i) + FullCharArray(i + 1)).ToUpper()
            index = Array.IndexOf(ADFGVXMapper, alphaPair)
            If (index < AlphaCount) Then
                MidwayString += Chr(index + AlphaDiff)
                i += 1
            ElseIf (index >= 0) Then
                MidwayString += Chr(index + NumeralDiff - AlphaCount)
                i += 1
            Else
                'Error
                MidwayString += "*"
            End If
        Next

        'Unscramble letters
        FullCharArray = MidwayString.ToCharArray()
        For i = 0 To FullCharArray.Length - 1
            If (Char.IsLetterOrDigit(FullCharArray(i))) Then
                index = Array.IndexOf(CharMapper, FullCharArray(i))
                If (index >= 0) Then
                    If (index < AlphaCount) Then
                        OutputString += Chr(index + AlphaDiff)
                    Else
                        OutputString += Chr(index + NumeralDiff - AlphaCount)
                    End If
                Else
                    'Error
                    OutputString += "*"
                End If
            End If
        Next

        Return OutputString
    End Function

#End Region

#Region " Polybius Square "

    Function EncodePolybius(ByVal RawText As String) As String
        RawText = RemoveWhiteSpace(RawText.ToLower)
        RawText = ConvertNumbers(RawText)
        Dim OutputString As String = ""
        Dim i As Integer

        '26th letter, replacement
        RawText = RawText.Replace(LetterToRemove, Get25Char(Asc(LetterToRemove) - AlphaDiff))
        For i = 0 To PolybiusSquare.Length - 1
            RawText = RawText.Replace(Get25Char(i), PolybiusSquare(i))
        Next

        Return RawText
    End Function

    Function DecodePolybius(ByVal RawText As String) As String
        RawText = RemoveWhiteSpace(RawText.ToLower)
        Dim FullCharArray() As Char = RawText.ToCharArray()
        Dim OutputString As String = ""
        Dim NumberPair As String
        Dim i, index As Integer

        For i = 0 To RawText.Length - 1
            If (i + 1 < RawText.Length) Then
                NumberPair = FullCharArray(i) + FullCharArray(i + 1)
                index = Array.IndexOf(PolybiusSquare, NumberPair)
                If (index >= 0) Then
                    OutputString += Get25Char(index)
                    i += 1
                Else
                    OutputString += FullCharArray(i)
                End If
            End If
        Next

        If (Verbose) Then
            OutputString += ControlChars.NewLine + ControlChars.NewLine
            OutputString += "Polybius Square: " + ControlChars.NewLine
            OutputString += "  | 1 2 3 4 5 " + ControlChars.NewLine
            OutputString += "--+-----------" + ControlChars.NewLine
            index = 0
            For i = 0 To AlphaCount - 1
                If (Chr(i + AlphaDiff) <> LetterToRemove) Then
                    If (index Mod 5 = 0) Then
                        OutputString += ((index Mod 5) + 1).ToString + " | "
                    End If
                    OutputString += Char.ToUpper(Chr(i + AlphaDiff)) + " "
                    If (index Mod 5 = 4) Then
                        OutputString += ControlChars.NewLine
                    End If
                    index += 1
                End If
            Next
        End If

        Return OutputString
    End Function
#End Region

#Region " Columnar Transposition "
    Function EncodeColumnar(ByVal RawText As String) As String
        'Initialize string
        RawText = RemoveNonLetters(RawText.ToLower)
        Dim theKey() As Char = RemoveNonLetters(txtKey.Text.ToLower).ToCharArray()
        Dim KeyLength As Integer = theKey.Length

        If KeyLength > 0 Then
            'Pad text values
            RawText = PadToMultiple(RawText, KeyLength)

            'Initialize transposition array
            Dim TposArray(KeyLength - 1) As Integer
            Dim i, j, counter As Integer
            counter = 0
            For i = 0 To AlphaCount - 1
                For j = 0 To KeyLength - 1
                    If (i + AlphaDiff = Asc(theKey(j))) Then
                        TposArray(j) = counter
                        counter += 1
                    End If
                Next
            Next

            'Fill in rows
            Dim Rows As Integer = RawText.Length / KeyLength
            Dim GridArray(Rows - 1, KeyLength - 1) As Char
            Dim FullCharArray() As Char = RawText.ToCharArray()
            For i = 0 To Rows - 1
                For j = 0 To KeyLength - 1
                    GridArray(i, TposArray(j)) = FullCharArray((i * KeyLength) + j)
                Next
            Next

            'Read out columns
            Dim OutputString As String
            For i = 0 To KeyLength - 1
                For j = 0 To Rows - 1
                    OutputString += GridArray(j, i)
                Next
            Next

            Return OutputString
        Else
            PostError("You must specify a key.")
            Return "Error"
        End If
    End Function

    Function DecodeColumnar(ByVal RawText As String) As String
        'Initialize string
        RawText = RemoveNonLetters(RawText.ToLower)
        Dim theKey() As Char = RemoveNonLetters(txtKey.Text.ToLower).ToCharArray()
        Dim KeyLength As Integer = theKey.Length

        If KeyLength > 0 Then
            'Pad text values
            RawText = PadToMultiple(RawText, KeyLength)

            'Initialize transposition array
            Dim TposArray(KeyLength - 1) As Integer
            Dim i, j, counter As Integer
            counter = 0
            For i = 0 To AlphaCount - 1
                For j = 0 To KeyLength - 1
                    If (i + AlphaDiff = Asc(theKey(j))) Then
                        TposArray(counter) = j
                        counter += 1
                    End If
                Next
            Next

            'Fill in rows
            Dim Cols As Integer = RawText.Length / KeyLength
            Dim GridArray(KeyLength - 1, Cols - 1) As Char
            Dim FullCharArray() As Char = RawText.ToCharArray()
            For i = 0 To KeyLength - 1
                For j = 0 To Cols - 1
                    GridArray(TposArray(i), j) = FullCharArray((i * Cols) + j)
                Next
            Next

            'Read out columns
            Dim OutputString As String
            For i = 0 To Cols - 1
                For j = 0 To KeyLength - 1
                    OutputString += GridArray(j, i)
                Next
            Next

            Return OutputString
        Else
            PostError("You must specify a key.")
            Return "Error"
        End If
    End Function

#End Region

#Region " RC4 "

    Function EncodeRC4(ByVal RawText As String)
        'Convert ASCII text input to Binary
        Dim TextBits As String = ASCIIStringToBinary(RawText)

        'Run RC4
        Dim CipheredBits As String = RC4(TextBits)

        'Convert binary to hex
        Dim FinalOutput As String = BinaryToHexString(CipheredBits)

        Return FinalOutput  'Hex
    End Function

    Function DecodeRC4(ByVal RawText As String)
        'Convert hex input to Binary
        Dim TextBits As String = HexStringToBinary(RawText)

        'Run RC4
        Dim CipheredBits As String = RC4(TextBits)

        'Convert binary output to ascii for decode
        Dim FinalOutput As String = BinaryToASCIIString(CipheredBits)

        Return FinalOutput  'ASCII
    End Function

    Function RC4(ByVal TextBits As String) As String
        'Get Key
        Dim theKey As String = txtKey.Text.Trim()
        Dim MinKeyLength As Integer = 3
        Dim MaxKeyLength As Integer = 16
        If (theKey.Length < MinKeyLength) Then
            PostError("Your key is too short.")
            Return ""
        ElseIf (theKey.Length > MaxKeyLength) Then
            theKey = theKey.Substring(0, MaxKeyLength)
        End If
        Dim BitKey As String = ASCIIStringToBinary(theKey)
        Dim KeyArray() As Char = BitKey.ToCharArray()
        Dim BitKeyLength As Integer = KeyArray.Length

        'Initialize SBox
        Dim i, j, k As Integer
        For i = 0 To BoxSize - 1
            RCBox(i) = i
        Next
        j = 0
        For i = 0 To BoxSize - 1
            j = (i + RCBox(i) + Microsoft.VisualBasic.Val(KeyArray(i Mod BitKeyLength))) Mod BoxSize
            RCSwap(i, j)
        Next

        'Generate Fullkey stream
        Dim FullBinaryKey As String = ""
        i = 0
        j = 0
        For k = 0 To (TextBits.Length / ByteSize) - 1
            i = (i + 1) Mod BoxSize
            j = (j + RCBox(i)) Mod BoxSize
            RCSwap(i, j)
            FullBinaryKey += DecimalToBinary(RCBox((RCBox(i) + RCBox(j)) Mod BoxSize), ByteSize)
        Next

        'XOR Key and BinaryMsg
        Dim BinaryOutput As String = XORBinaryStrings(TextBits, FullBinaryKey)

        Return BinaryOutput
    End Function

    Sub RCSwap(ByVal i As Integer, ByVal j As Integer)
        Dim temp As Integer = RCBox(i)
        RCBox(i) = RCBox(j)
        RCBox(j) = temp
    End Sub
#End Region

#Region " DES "

    Function EncodeDES(ByVal RawText As String, ByVal KeyTotal As Integer) As String
        '===============================
        '|  INPUT: Text, OUTPUT: Hex   |
        '===============================

        Dim i As Integer
        'Pad message to a multiple of 64 bits (64 bits = 8 bytes = 8 chars)
        RawText = RawText.Trim()
        Dim thePadding As Integer = RawText.Length Mod ByteSize
        If (thePadding > 0) Then
            RawText = RawText.PadRight(RawText.Length + ByteSize - thePadding, " ")
        End If

        'Divide into message blocks and convert to binary
        Dim OriginalTextLength As Integer = RawText.Length
        Dim BinaryInput As String = ASCIIStringToBinary(RawText)

        'Initalize DES variables
        Dim BinaryOutput As String
        Dim KeyPeice As String
        Dim RepeatFirst As Boolean = False

        '2TDEA case
        If (KeyTotal = 2) Then
            RepeatFirst = True
            KeyTotal += 1
        End If

        For i = 0 To KeyTotal - 1
            'Get current key
            If (RepeatFirst And i = 2) Then
                KeyPeice = GetKeyByNumber(0) '2TDEA
            Else
                KeyPeice = GetKeyByNumber(i)
            End If

            'Run DES on binary with key
            BinaryOutput = DES(BinaryInput, KeyPeice)
            BinaryInput = BinaryOutput
        Next


        'Convert from Binary to Hex
        Dim HexOutput As String = ""
        For i = 0 To BinaryOutput.Length - 1 Step 4
            HexOutput += BinaryToHex(BinaryOutput.Substring(i, 4))
        Next

        Return HexOutput
    End Function

    Function DecodeDES(ByVal RawText As String, ByVal KeyTotal As Integer) As String
        '===============================
        '|  INPUT: Hex, OUTPUT: Text   |
        '===============================

        Dim i As Integer
        'Pad message to a multiple of 64 bits (64 bits = 8 bytes = 16 hex digits)
        RawText = RawText.Trim()
        Dim thePadding As Integer = RawText.Length Mod 16
        If (thePadding > 0) Then
            RawText = RawText.PadRight(RawText.Length + ByteSize - thePadding, " ")
        End If

        'Convert from hex to binary
        Dim BinaryInput As String = ""
        Try
            'Divide into message blocks and convert from hex to binary
            Dim OriginalTextLength As Integer = RawText.Length
            Dim MsgChar() As Char = RawText.ToCharArray()
            Dim HexPair As String
            For i = 0 To MsgChar.Length - 1 Step 2
                HexPair = RawText.Substring(i, 2)
                BinaryInput += HexToBinary(HexPair).PadLeft(8, "0")
            Next
        Catch ex As Exception
            PostError("Encoded value was not a hexidecimal value (digits must be 0-F) or was not the correct length.")
            Return "Error"
        End Try

        'Initalize DES variables
        Dim BinaryOutput As String
        Dim KeyPeice As String
        Dim RepeatFirst As Boolean = False

        '2TDEA case
        If (KeyTotal = 2) Then
            RepeatFirst = True
            KeyTotal += 1
        End If

        For i = KeyTotal - 1 To 0 Step -1
            If (RepeatFirst And i = 2) Then
                KeyPeice = GetKeyByNumber(0) '2TDEA
            Else
                KeyPeice = GetKeyByNumber(i)
            End If

            'Run DES on binary with key
            BinaryOutput = DES(BinaryInput, KeyPeice, True)
            BinaryInput = BinaryOutput
        Next

        'Convert from Binary to Text
        Dim TextOutput As String = BinaryToASCIIString(BinaryOutput)

        Return TextOutput
    End Function

    Function GetKeyByNumber(ByVal KeyNumber As Integer) As String
        'Find individual keys
        Dim KeysArray() As String = RemoveWhiteSpace(txtKey.Text).Split(" ")
        Dim StartKey As String = ""
        If (KeyNumber >= KeysArray.Length) Then
            PostError("You do not have enough keys.")
            Return ""
        Else
            StartKey = KeysArray(KeyNumber)
        End If

        Return StartKey
    End Function

    Function DES(ByVal RawText As String, ByVal KeyString As String, Optional ByVal Decode As Boolean = False) As String
        '====================================
        '|  INPUT: Binary, OUTPUT: Binary   |
        '====================================

        'Create Subkeys
        If (Not CreateDESSubkeys(KeyString)) Then
            PostError("You must have a key at least 8 characters long. Keys that are 8-15 digits long will be cropped to 8 digits evaluated as ascii while keys 16 digits long will be cropped to 16 digits evaluated as hexidecimal.")
            Return ""
        End If

        'Divide message into 64 bit chunks
        Dim CurrentBlock As String
        Dim BinaryOutput As String = ""
        Dim i As Integer
        For i = 0 To RawText.Length - 1 Step BlockBitSize '16 hex = 8 bytes = 64 bits
            Try
                CurrentBlock = RawText.Substring(i, BlockBitSize)
                BinaryOutput += ConvertDESBlock(CurrentBlock, Decode)
            Catch ex As Exception
                PostError("The encoded string has been tampered with.")
                Return ""
            End Try
        Next

        Return BinaryOutput
    End Function

    Function ConvertDESBlock(ByVal RawText As String, Optional ByVal Decode As Boolean = False) As String
        Dim i, j As Integer
        Dim FullCharArray() As Char = RawText.ToCharArray()

        'Run Initial Permutation
        Dim AfterIP(BlockBitSize - 1) As Char
        For i = 0 To BlockBitSize - 1
            AfterIP(i) = FullCharArray(IP(i) - 1)
        Next

        'Initialize messagehalves
        Dim LeftRights(RoundCount, BlockBitSize - 1) As Char
        For j = 0 To BlockBitSize - 1
            LeftRights(0, j) = AfterIP(j)
        Next

        'Begin rounds
        Dim OldLeft As String = ""
        Dim OldRight As String = ""
        Dim NewLeft As String = ""
        Dim NewRight As String = ""
        Dim CurrentSubkey As String = ""
        For i = 1 To RoundCount
            OldLeft = ""
            OldRight = ""
            NewLeft = ""
            NewRight = ""
            CurrentSubkey = ""
            For j = 0 To HalfBlock - 1
                'Left
                OldLeft += LeftRights(i - 1, j)
                'Right
                OldRight += LeftRights(i - 1, j + HalfBlock)
            Next

            'Reverse subkeys if necessary
            If Not (Decode) Then
                For j = 0 To SubKeySize - 1
                    CurrentSubkey += Subkeys(RoundCount - i, j)
                Next
            Else
                For j = 0 To SubKeySize - 1
                    CurrentSubkey += Subkeys(i - 1, j)
                Next
            End If

            'NewLeft
            NewLeft = OldRight
            'NewRight
            NewRight = XORBinaryStrings(OldLeft, FeistelDES(OldRight, CurrentSubkey))

            'Record new values into current round
            Dim LeftArray() As Char = NewLeft.ToCharArray()
            Dim RightArray() As Char = NewRight.ToCharArray()
            For j = 0 To HalfBlock - 1
                LeftRights(i, j) = LeftArray(j)
                LeftRights(i, j + HalfBlock) = RightArray(j)
            Next
        Next

        'Swap Left and Right on final round
        Dim BeforeFP(BlockBitSize - 1) As Char
        For i = 0 To HalfBlock - 1
            BeforeFP(i) = LeftRights(RoundCount, i + HalfBlock)
            BeforeFP(i + HalfBlock) = LeftRights(RoundCount, i)
        Next

        'Run Final Permutation
        Dim AfterFP(BlockBitSize - 1) As Char
        For i = 0 To BlockBitSize - 1
            AfterFP(i) = BeforeFP(FP(i) - 1)
        Next

        Dim OutputString As String = AfterFP

        Return OutputString
    End Function

    Function FeistelDES(ByVal MsgHalf As String, ByVal Subkey As String) As String
        Dim i, j As Integer

        'Expand MsgHalf
        Dim ExpandedMsg As String = ""
        Dim SmallCharArray() As Char = MsgHalf.ToCharArray()
        For i = 0 To SubKeySize - 1
            ExpandedMsg += SmallCharArray(Expansion(i) - 1)
        Next

        'Xor message-half and subkey
        Dim XORedString As String = XORBinaryStrings(ExpandedMsg, Subkey)

        'Divide into s-boxes
        Dim SBoxInput As String
        Dim SBox_x, SBox_y, LookupValue As Integer
        Dim CurrentSBox() As Integer
        Dim SboxedString As String = ""
        For i = 0 To SubKeySize - 1 Step SboxSize
            SBoxInput = XORedString.Substring(i, SboxSize)
            'Middle 4 bits
            SBox_x = BinaryToDecimal(SBoxInput.Substring(1, 4))
            'First and last bit
            SBox_y = BinaryToDecimal(SBoxInput.Substring(0, 1) + SBoxInput.Substring(5, 1))
            LookupValue = ((SBox_y * 16) + SBox_x)
            Select Case ((i / SboxSize) + 1)
                Case 1
                    CurrentSBox = S1
                Case 2
                    CurrentSBox = S2
                Case 3
                    CurrentSBox = S3
                Case 4
                    CurrentSBox = S4
                Case 5
                    CurrentSBox = S5
                Case 6
                    CurrentSBox = S6
                Case 7
                    CurrentSBox = S7
                Case 8
                    CurrentSBox = S8
            End Select
            SboxedString += DecimalToBinary(CurrentSBox(LookupValue)).PadLeft(4, "0")
        Next

        'Permute
        Dim PermutedMsg As String = ""
        Dim FullCharArray() As Char = SboxedString.ToCharArray()
        For i = 0 To HalfBlock - 1
            PermutedMsg += FullCharArray(Permutation(i) - 1)
        Next

        Return PermutedMsg
    End Function

    Function CreateDESSubkeys(ByVal theKey As String) As Boolean

        'Convert key to binary
        Dim i, j As Integer
        theKey = theKey.ToUpper().Trim()
        Dim KeyBinary As String = ""
        Dim KeyChars() As Char = theKey.ToCharArray()
        If (IsHexidecimal(theKey) And theKey.Length >= KeyLength) Then
            'Convert hexidecimal key to binary
            theKey = theKey.Substring(0, KeyLength)
            KeyBinary = HexToBinary(theKey)
        ElseIf (theKey.Length >= ByteSize) Then
            'Convert ascii key to binary
            theKey = theKey.Substring(0, ByteSize)
            For i = 0 To ByteSize - 1
                KeyBinary += DecimalToBinary(Asc(KeyChars(i))).PadLeft(ByteSize, "0")
            Next
        Else
            Return False
        End If

        KeyChars = KeyBinary.ToCharArray()
        'Initialize subkeys
        Dim LeftRights(RoundCount, KeyBitLength - 1) As Char
        For i = 0 To KeyBitHalf - 1
            'Left
            LeftRights(0, i) = KeyChars(PC1_Left(i) - 1)
            'Right
            LeftRights(0, i + KeyBitHalf) = KeyChars(PC1_Right(i) - 1)
        Next

        'Create subkeys
        Dim oldValue, rotatedj As Integer
        For i = 1 To RoundCount
            For j = 0 To KeyBitHalf - 1
                rotatedj = (j + KeySchedule(i - 1)) Mod KeyBitHalf
                'Left
                LeftRights(i, j) = LeftRights(i - 1, rotatedj)
                'Right
                LeftRights(i, j + KeyBitHalf) = LeftRights(i - 1, rotatedj + KeyBitHalf)
            Next
        Next

        'Scramble subkeys
        For i = 0 To RoundCount - 1
            For j = 0 To SubKeySize - 1
                Subkeys(i, j) = LeftRights(i + 1, PC2(j) - 1)
            Next
        Next

        Return True
    End Function

#End Region

#Region " Atbash "
    Function EncodeAtbash(ByVal RawText As String, Optional ByVal PrintVerbose As Boolean = False) As String
        RawText = RawText.ToLower()
        Dim FullCharArray As Char() = RawText.ToCharArray()
        Dim OutputString As String = ""
        Dim i As Integer
        For i = 0 To FullCharArray.Length - 1
            If (Char.IsLetter(FullCharArray(i))) Then
                OutputString += Chr(25 - Asc(FullCharArray(i)) + AlphaDiff + AlphaDiff)
            Else
                OutputString += FullCharArray(i)
            End If
        Next

        If (Verbose And PrintVerbose) Then
            Dim ReverseStr As String = ""
            For i = AlphaCount - 1 To 0 Step -1
                ReverseStr += Chr(i + AlphaDiff) + " "
            Next
            OutputString += OutputTranslation(ReverseStr.Trim().Split(" "))
        End If

        Return OutputString
    End Function
#End Region

#Region " Keyword "
    Function EncodeKeyword(ByVal RawText As String) As String
        Dim CharMapper(AlphaCount - 1) As Char
        Dim KeyString() As Char = txtKey.Text.ToCharArray()
        Dim KeyLength As Integer = KeyString.Length
        Dim RealLength As Integer = 0
        Dim Repeat As Integer = 0
        Dim i, asciiValue As Integer

        For i = 0 To CharMapper.Length - 1
            CharMapper(i) = "_"c
        Next

        'Fill in keyword
        For i = 0 To KeyLength - 1
            If (Array.IndexOf(CharMapper, KeyString(i)) < 0) Then
                CharMapper(i - Repeat) = KeyString(i)
                RealLength += 1
            Else
                Repeat += 1
            End If
        Next
        'Fill in rest of unused alphabet
        For i = 0 To AlphaCount - 1
            If (Array.IndexOf(CharMapper, Chr(i + AlphaDiff)) < 0) Then
                CharMapper(i + RealLength) = Chr(i + AlphaDiff)
            Else
                RealLength -= 1
            End If
        Next

        'Replace
        RawText = RawText.ToLower()
        Dim FullCharArray() As Char
        FullCharArray = RawText.ToCharArray
        For i = 0 To FullCharArray.Length - 1
            If (Char.IsLetter(FullCharArray(i))) Then
                asciiValue = Asc(FullCharArray(i)) - AlphaDiff
                FullCharArray(i) = CharMapper(asciiValue)
            End If
        Next

        Return FullCharArray

    End Function

    Function DecodeKeyword(ByVal RawText As String) As String
        Dim CharMapper(AlphaCount - 1) As Char
        Dim KeyString() As Char = txtKey.Text.ToCharArray()
        Dim KeyLength As Integer = KeyString.Length
        Dim RealLength As Integer = 0
        Dim Repeat As Integer = 0
        Dim i, asciiValue As Integer

        For i = 0 To CharMapper.Length - 1
            CharMapper(i) = "_"c
        Next

        'Fill in keyword
        For i = 0 To KeyLength - 1
            If (Array.IndexOf(CharMapper, KeyString(i)) < 0) Then
                CharMapper(i - Repeat) = KeyString(i)
                RealLength += 1
            Else
                Repeat += 1
            End If
        Next
        'Fill in rest of unused alphabet
        For i = 0 To AlphaCount - 1
            If (Array.IndexOf(CharMapper, Chr(i + AlphaDiff)) < 0) Then
                CharMapper(i + RealLength) = Chr(i + AlphaDiff)
            Else
                RealLength -= 1
            End If
        Next

        'Replace
        Dim FullCharArray() As Char
        FullCharArray = RawText.ToCharArray
        For i = 0 To FullCharArray.Length - 1
            If (Char.IsLetter(FullCharArray(i))) Then
                'Use stored mapping
                FullCharArray(i) = Chr(Array.IndexOf(CharMapper, FullCharArray(i)) + AlphaDiff)
            End If
        Next

        Dim OutputString As String = FullCharArray
        If (Verbose) Then
            OutputString += OutputTranslation(CharMapper)
        End If

        Return OutputString
    End Function
#End Region

#Region " Straddling Checkerboard "
    Function EncodeStraddling(ByVal RawText As String) As String
        RawText = ConvertNumbers(RawText)
        RawText = RawText.ToLower()
        Dim i As Integer
        Dim StraddlingCB As String() = GenerateStraddlingCheckerboard()
        For i = 0 To StraddlingCB.Length - 1
            If (i < AlphaCount) Then
                RawText = RawText.Replace(Chr(i + AlphaDiff), StraddlingCB(i))
            ElseIf (i = StraddlingCB.Length - 2) Then
                RawText = RawText.Replace(" ", StraddlingCB(i))
            Else
                RawText = RawText.Replace(".", StraddlingCB(i))
            End If

        Next

        'NonCarryAddition
        RawText = NonCarryAddition(RawText)

        Return RawText
    End Function

    Function DecodeStraddling(ByVal RawText As String) As String
        'NonCarryAddition
        RawText = NonCarryAddition(RawText, True)

        Dim i, j As Integer
        Dim StraddlingCB As String() = GenerateStraddlingCheckerboard()
        Dim FullCharArray As Char() = RawText.ToCharArray()
        Dim OutputString As String = ""
        Dim CharList As ArrayList = CreateAlphabetList()
        Dim TextLength = FullCharArray.Length
        CharList.Add(" ")
        CharList.Add(".")

        For i = 0 To TextLength - 1
            If (Array.IndexOf(StraddlingCB, (FullCharArray(i)).ToString()) >= 0) Then
                OutputString += CharList(Array.IndexOf(StraddlingCB, FullCharArray(i).ToString()))
            ElseIf (i + 1 < TextLength) Then
                If (Char.IsDigit(FullCharArray(i)) And Char.IsDigit(FullCharArray(i + 1))) Then
                    OutputString += CharList(Array.IndexOf(StraddlingCB, (FullCharArray(i) + FullCharArray(i + 1))))
                    i += 1
                Else
                    OutputString += FullCharArray(i)
                End If
            End If
        Next

        If (Verbose) Then   'Display chart and key
            Dim firstDigit1, firstDigit2, theChar, fullNum As String
            Dim theIndex As Integer
            firstDigit1 = "*"
            firstDigit2 = "*"
            'Determine first digits
            While (firstDigit1 = "*" Or firstDigit2 = "*")
                For i = 0 To StraddlingCB.Length - 1
                    If (StraddlingCB(i).Length > 1) Then
                        theChar = StraddlingCB(i).Substring(0, 1)
                        If (firstDigit1 = "*") Then
                            firstDigit1 = theChar
                        ElseIf (firstDigit1 = theChar) Then
                            'Do Nothing
                        Else
                            firstDigit2 = theChar
                        End If
                    End If
                Next
            End While
            OutputString += ControlChars.NewLine + ControlChars.NewLine
            OutputString += "Straddling Board: " + ControlChars.NewLine
            OutputString += "  | "
            For i = 0 To 9
                OutputString += i.ToString() + "  "
            Next
            OutputString += "|" + ControlChars.NewLine
            OutputString += "  |-------------------------------|" + ControlChars.NewLine
            OutputString += "  | "
            'FirstRow
            For j = 0 To 2
                If (j = 1) Then
                    OutputString += firstDigit1 + " | "
                ElseIf (j = 2) Then
                    OutputString += firstDigit2 + " | "
                End If
                For i = 0 To 9
                    fullNum = i.ToString()
                    If (j = 1) Then
                        fullNum = firstDigit1 + fullNum
                    ElseIf (j = 2) Then
                        fullNum = firstDigit2 + fullNum
                    End If
                    theIndex = Array.IndexOf(StraddlingCB, fullNum)
                    If (theIndex = 27) Then
                        OutputString += "."
                    ElseIf (theIndex = 26) Then
                        OutputString += " "
                    ElseIf (theIndex >= 0) Then
                        OutputString += Char.ToUpper(Chr(theIndex + AlphaDiff))
                    Else
                        OutputString += " "
                    End If
                    OutputString += "  "
                Next
                OutputString += "|" + ControlChars.NewLine
            Next
            OutputString += "  |-------------------------------|"

            OutputString += ControlChars.NewLine + ControlChars.NewLine
            OutputString += "Non-carrying addition key: "
            Dim KeyArray() As Char = txtKey.Text.ToCharArray()
            For i = 0 To KeyArray.Length - 1
                If (Char.IsDigit(KeyArray(i))) Then
                    OutputString += KeyArray(i)
                Else
                    OutputString += "0"
                End If
            Next
        End If

        Return OutputString
    End Function
#End Region

#Region " Rotating Grille "
    Function RotateGrilleCC(ByVal position As Integer, ByVal SideLength As Integer) As Integer
        'Convert x-y to coordinate system
        Dim row As Integer = Math.Floor(position / SideLength)
        Dim col As Integer = position Mod SideLength
        Dim y As Integer = row - Math.Floor(SideLength / 2)
        Dim x As Integer = col - Math.Floor(SideLength / 2)
        If (SideLength Mod 2 = 0 And x >= 0) Then
            x += 1
        End If
        If (SideLength Mod 2 = 0 And y >= 0) Then
            y += 1
        End If

        'Rotate
        If (x * y >= 0) Then
            x *= -1
        Else
            y *= -1
        End If
        Swap(x, y)

        'Convert back to position
        row = y + Math.Floor(SideLength / 2)
        col = x + Math.Floor(SideLength / 2)
        If (SideLength Mod 2 = 0 And row >= 0) Then
            row -= 1
        End If
        If (SideLength Mod 2 = 0 And col >= 0) Then
            col -= 1
        End If
        position = col + (row * SideLength)

        Return position
    End Function

    Function RotateGrilleCC(ByVal row As Integer, ByVal col As Integer, ByVal SideLength As Integer, ByVal RCount As Integer) As NumericPair
        If (RCount = 0) Then
            Return New NumericPair(row, col)
        End If
        'txtDecode.Text += "(" + row.ToString() + "," + col.ToString + ") "

        'Convert x-y to coordinate system
        Dim y As Integer = row - Math.Floor(SideLength / 2)
        Dim x As Integer = col - Math.Floor(SideLength / 2)
        If (SideLength Mod 2 = 0 And x >= 0) Then
            x += 1
        End If
        If (SideLength Mod 2 = 0 And y >= 0) Then
            y += 1
        End If

        'Rotate
        If (RCount = 1) Then
            Swap(x, y)
            x *= -1
        ElseIf (RCount = 2) Then
            x *= -1
            y *= -1
        ElseIf (RCount = 3) Then
            Swap(x, y)
            y *= -1
        Else
            PostError("Too many rotations!")
        End If

        'Convert back to position
        If (SideLength Mod 2 = 0 And x >= 0) Then
            x -= 1
        End If
        If (SideLength Mod 2 = 0 And y >= 0) Then
            y -= 1
        End If
        row = y + Math.Floor(SideLength / 2)
        col = x + Math.Floor(SideLength / 2)

        'txtDecode.Text += " = (" + row.ToString() + "," + col.ToString + "), "
        Dim position As New NumericPair(row, col)

        Return position
    End Function

    Function RotateMask(ByVal inMask(,) As Char) As Char(,)
        Dim outMask(,) As Char = inMask
        Dim i, j As Integer
        Dim sizeLength As Integer = Math.Sqrt(inMask.Length)
        Dim tempString As String = ""
        For i = 0 To sizeLength - 1
            For j = 0 To sizeLength - 1
                tempString += inMask(i, j)
            Next
        Next
        Dim FullCharArray() As Char = tempString.ToCharArray()
        Dim current As Integer = 0
        For j = 0 To sizeLength - 1
            For i = sizeLength - 1 To 0 Step -1
                outMask(i, j) = FullCharArray(current)
                current += 1
            Next
        Next

        Return outMask
    End Function

    Function EncodeRGrille(ByVal RawText As String) As String
        RawText = RemoveNonLetters(RawText)
        Dim TextLength As Integer = RawText.Length
        Dim SideSize As Integer = 2
        While (TextLength > Math.Pow(SideSize, 2))
            SideSize += 2
        End While
        Dim theMask(SideSize - 1, SideSize - 1) As Char
        RawText = PadFrequency(RawText, Math.Pow(SideSize, 2))
        TextLength = RawText.Length
        Dim FullCharArray As Char() = RawText.ToCharArray()

        'Initialize mask
        Dim i, j, k, x, y, rotation, currentPosition As Integer
        For i = 0 To SideSize - 1
            For j = 0 To SideSize - 1
                theMask(i, j) = WallChar
            Next
        Next
        i = TextLength

        'Create mask holes
        Dim HalfSize As Integer = Math.Floor(SideSize / 2)
        Dim thePair As New NumericPair
        For i = 0 To HalfSize - 1
            For j = 0 To HalfSize - 1
                x = i
                y = j
                rotation = randObj.Next(0, 4)
                thePair = RotateGrilleCC(x, y, SideSize, rotation)
                x = thePair.x
                y = thePair.y
                theMask(x, y) = "_"c
            Next
        Next

        'Fill in message
        Dim OutputChars(SideSize - 1, SideSize - 1) As Char
        currentPosition = 0
        Dim newMask(,) As Char = theMask
        For k = 0 To 3
            'Fill in holes on current rotation
            For i = 0 To SideSize - 1
                For j = 0 To SideSize - 1
                    If (newMask(i, j) = "_"c) Then
                        'Fill in hole through mask
                        If (currentPosition < FullCharArray.Length) Then
                            OutputChars(i, j) = FullCharArray(currentPosition)
                        End If
                        currentPosition += 1
                    End If
                Next
            Next
            newMask = RotateMask(newMask)
        Next

        Dim OutputString As String = ""
        For i = 0 To SideSize - 1
            For j = 0 To SideSize - 1
                OutputString += OutputChars(i, j)
            Next
            OutputString += ControlChars.NewLine
        Next

        Return OutputString.ToUpper()
    End Function

    Function DecodeRGrille(ByVal RawText As String) As String
        RawText = RemoveNonLetters(RawText)
        Dim TextLength As Integer = RawText.Length
        Dim SideSize As Integer = 2
        While (TextLength > Math.Pow(SideSize, 2))
            SideSize += 2
        End While
        Dim theMask(SideSize - 1, SideSize - 1) As Char
        TextLength = RawText.Length
        Dim FullCharArray As Char() = RawText.ToCharArray()

        'Initialize mask
        Dim i, j, k, x, y, rotation, currentPosition As Integer
        For i = 0 To SideSize - 1
            For j = 0 To SideSize - 1
                theMask(i, j) = WallChar
            Next
        Next
        i = TextLength

        'Create mask holes
        Dim HalfSize As Integer = Math.Floor(SideSize / 2)
        Dim thePair As New NumericPair
        For i = 0 To HalfSize - 1
            For j = 0 To HalfSize - 1
                x = i
                y = j
                rotation = randObj.Next(0, 4)
                thePair = RotateGrilleCC(x, y, SideSize, rotation)
                x = thePair.x
                y = thePair.y
                theMask(x, y) = "_"c
            Next
        Next

        'Read in through the mask
        Dim VerboseString As String = "Grille Masks at each of the four counterclockwise rotations: " + ControlChars.NewLine
        Dim OutputString As String = ""
        currentPosition = 0
        Dim newMask(,) As Char = theMask
        For k = 0 To 3
            'Read in through holes on current rotation
            For i = 0 To SideSize - 1
                For j = 0 To SideSize - 1
                    If (newMask(i, j) = "_"c And (i * SideSize) + j < FullCharArray.Length) Then
                        'Read through hole through mask
                        OutputString += FullCharArray((i * SideSize) + j)
                    End If
                    VerboseString += newMask(i, j)
                Next
                VerboseString += ControlChars.NewLine
            Next
            VerboseString += ControlChars.NewLine
            newMask = RotateMask(newMask)
        Next

        'Verbose Mode
        If (Verbose) Then
            OutputString += ControlChars.NewLine + ControlChars.NewLine
            OutputString += VerboseString
        End If

        Return OutputString
    End Function

#End Region

#Region " Grille "
    Function EncodeGrille(ByVal RawText As String) As String
        RawText = RemoveNonLetters(RawText)
        Dim FullCharArray As Char() = RawText.ToCharArray()
        Dim TextLength As Integer = RawText.Length
        OldLength = TextLength
        Dim SideSize As Integer = 1
        While (TextLength * 5 > Math.Pow(SideSize, 2))
            SideSize += 1
        End While
        Dim theMask(SideSize - 1, SideSize - 1) As Char

        'Initialize mask
        Dim i, j, k, x, y, currentPosition As Integer
        For i = 0 To SideSize - 1
            For j = 0 To SideSize - 1
                theMask(i, j) = WallChar
            Next
        Next
        i = TextLength

        'Create mask holes
        While (i > 0)
            x = randObj.Next(0, SideSize)
            y = randObj.Next(0, SideSize)
            If (theMask(x, y) = WallChar) Then
                theMask(x, y) = "_"c
                i -= 1
            End If
        End While

        'Fill in holes and replace wall characters
        Dim OutputString As String = ""
        currentPosition = 0
        For i = 0 To SideSize - 1
            For j = 0 To SideSize - 1
                If (theMask(i, j) = WallChar) Then
                    'Create new letter at proper frequency
                    OutputString = PadFrequency(OutputString, OutputString.Length + 1)
                ElseIf (theMask(i, j) = "_"c) Then
                    'Fill in hole through mask
                    OutputString += FullCharArray(currentPosition)
                    currentPosition += 1
                End If
            Next
            OutputString += ControlChars.NewLine
        Next
        Return OutputString.ToUpper()
    End Function

    Function DecodeGrille(ByVal RawText As String) As String
        RawText = RemoveNonLetters(RawText)
        Dim FullCharArray As Char() = RawText.ToCharArray()
        Dim TextLength As Integer = RawText.Length
        Dim SideSize As Integer = Math.Sqrt(TextLength)
        Dim theMask(SideSize - 1, SideSize - 1) As Char

        'Initialize mask
        Dim i, j, k, x, y, currentPosition As Integer
        For i = 0 To SideSize - 1
            For j = 0 To SideSize - 1
                theMask(i, j) = WallChar
            Next
        Next
        i = OldLength 'Preserved from last encode

        'Create mask holes
        If (i < theMask.Length) Then
            While (i > 0)
                x = randObj.Next(0, SideSize)
                y = randObj.Next(0, SideSize)
                If (theMask(x, y) = WallChar) Then
                    theMask(x, y) = "_"c
                    i -= 1
                End If
            End While
        End If

        'Read through holes
        Dim OutputString As String = ""
        For i = 0 To SideSize - 1
            For j = 0 To SideSize - 1
                If (theMask(i, j) = "_"c) Then
                    OutputString += FullCharArray((i * SideSize) + j)
                End If
            Next
        Next
        OutputString = OutputString.ToLower()

        'Verbose Mode
        If (Verbose) Then
            OutputString += ControlChars.NewLine + ControlChars.NewLine
            OutputString += "Grille mask: " + ControlChars.NewLine
            For i = 0 To SideSize - 1
                For j = 0 To SideSize - 1
                    OutputString += theMask(i, j)
                Next
                OutputString += ControlChars.NewLine
            Next
        End If

        Return OutputString
    End Function
#End Region

#Region " Scytale "
    Function EncodeScytale(ByVal RawText As String) As String
        Dim JumpFactor As Integer = numSeed.Value
        RawText = RawText.ToLower().Trim()
        Dim TextLength As Integer = RawText.Length

        If (JumpFactor > 1 And JumpFactor < TextLength / 2) Then
            If Not (TextLength Mod JumpFactor = 0) Then
                Dim PadAmount As Integer = JumpFactor - (TextLength Mod JumpFactor)
                RawText = PadRandom(RawText, TextLength + PadAmount)
            End If
            Dim FullCharArray() As Char = RawText.ToCharArray()
            Dim OutputString As String = ""
            Dim i, j As Integer

            'Loop through each starting position
            For j = 0 To JumpFactor - 1
                'Loop through string jumping the correct number of spaces
                For i = 0 To FullCharArray.Length - 1 Step JumpFactor
                    If (i + j < FullCharArray.Length) Then
                        OutputString += FullCharArray(i + j)
                    End If
                Next
            Next

            Return OutputString
        Else
            Return "Jump factor is too low or too high. Set it using the seed number box."
        End If
    End Function

    Function DecodeScytale(ByVal RawText As String) As String
        Dim JumpFactor As Integer
        If (numSeed.Value <= 0) Then
            PostError("Jump factor must be a digit greater than 0. Set it using the seed number box.")
            Return ""
        End If
        If (RawText.Length > 0) Then
            JumpFactor = (RawText.Length / numSeed.Value)
        Else
            PostError("You must have a message to decode")
            Return ""
        End If

        RawText = RawText.ToLower()

        If (JumpFactor > 1 And JumpFactor < RawText.Length / 2) Then
            Dim FullCharArray() As Char = RawText.ToCharArray()
            Dim OutputString As String = ""
            Dim i, j As Integer

            'Loop through each starting position
            For j = 0 To JumpFactor - 1
                'Loop through string jumping the correct number of spaces
                For i = 0 To FullCharArray.Length - 1 Step JumpFactor
                    If (i + j < FullCharArray.Length) Then
                        OutputString += FullCharArray(i + j)
                    End If
                Next
            Next

            If (Verbose) Then
                OutputString += ControlChars.NewLine + ControlChars.NewLine
                OutputString += "Jump factor to encrypt: " + numSeed.Value.ToString() + ControlChars.NewLine
                OutputString += "Jump factor to decrypt: " + JumpFactor.ToString()
            End If

            Return OutputString
        Else
            Return "Jump factor is too low or too high. Set it using the seed number box."
        End If
    End Function
#End Region

#Region " Autokey, Repeat Key and Progressive Key "
    Function EncodeTabulaKey(ByVal RawText As String, ByVal theKeyType As String) As String
        'Count keys and use either regular Tabula Recta or keyed or quit
        Dim KeyArray() As String = RemoveWhiteSpace(txtKey.Text).Split(" ")
        If (KeyArray.Length > 1) Then
            CreateKeyedTabulaRecta(KeyArray(1))
        ElseIf (KeyArray.Length = 1 And KeyArray(0) <> "") Then
            CreateTabulaRecta()
        Else
            PostError("A keyword must be selected.")
            Return "A keyword must be selected."
        End If

        Dim Keyword As String = RemoveNonLetters(KeyArray(0)).ToLower
        Dim KeyWordLength As Integer = Keyword.Length
        If (KeyWordLength > 0) Then
            RawText = RemoveNonLetters(RawText.ToLower())
            Dim i As Integer
            'Select method of key
            Select Case (theKeyType)
                Case KEYTYPES.Autokey
                    Keyword = Keyword + RawText
                Case KEYTYPES.Repeat
                    Keyword = RepeatToMatchLengths(Keyword, RawText)
                Case KEYTYPES.Progressive
                    Dim TempKeyArray() As Char = Keyword.ToCharArray()
                    Dim loopCount As Integer = 0
                    For i = 0 To RawText.Length - 1
                        'Rotate key letters by one every keyword
                        If (i Mod KeyWordLength = 0) Then
                            loopCount += 1
                        End If
                        Keyword += Chr((((Asc(TempKeyArray(i Mod KeyWordLength)) - AlphaDiff) + loopCount) Mod AlphaCount) + AlphaDiff)
                    Next
            End Select
            Dim OutputString As String = ""
            Dim FullCharArray As Char() = RawText.ToCharArray()
            Dim FullKeyArray As Char() = Keyword.ToCharArray()

            'Encode using tabula recta
            For i = 0 To FullCharArray.Length - 1
                If (Char.IsLetter(FullCharArray(i))) Then
                    OutputString += EncodeFromTabulaRecta(FullCharArray(i), FullKeyArray(i))
                Else
                    PostError("Impossible characters appeared in input string.")   'Error
                    Return ""
                End If
            Next

            Return OutputString
        Else
            Return "A keyword must be selected."
        End If

    End Function

    Function DecodeTabulaKey(ByVal RawText As String, ByVal theKeyType As String) As String
        'Count keys and use either regular Tabula Recta or keyed or quit
        Dim KeyArray() As String = RemoveWhiteSpace(txtKey.Text).Split(" ")
        If (KeyArray.Length > 1) Then
            CreateKeyedTabulaRecta(KeyArray(1))
        ElseIf (KeyArray.Length = 1 And KeyArray(0) <> "") Then
            CreateTabulaRecta()
        Else
            PostError("A keyword must be selected.")
            Return "A keyword must be selected."
        End If

        Dim Keyword As String = RemoveNonLetters(KeyArray(0)).ToLower
        Dim KeyWordLength As Integer = Keyword.Length
        If (KeyWordLength > 0) Then
            RawText = RemoveNonLetters(RawText.ToLower())
            Dim OutputString As String = ""
            Dim FullCharArray As Char() = RawText.ToCharArray()
            Dim PartKeyArray As Char() = Keyword.ToCharArray()
            Dim FullKeyArray(FullCharArray.Length + KeyWordLength - 1) As Char
            Dim i, index As Integer
            Dim current_char As Char

            'Select method of key
            Select Case (theKeyType)
                Case KEYTYPES.Autokey
                    For i = 0 To Math.Min(Keyword.Length, FullCharArray.Length) - 1
                        FullKeyArray(i) = PartKeyArray(i)
                    Next
                    index = i
                Case KEYTYPES.Repeat
                    Keyword = RepeatToMatchLengths(Keyword, RawText)
                    FullKeyArray = Keyword.ToCharArray()
                Case KEYTYPES.Progressive
                    Dim TempKeyArray() As Char = Keyword.ToCharArray()
                    Dim loopCount As Integer = 0
                    For i = 0 To RawText.Length - 1
                        'Rotate key letters by one every keyword
                        If (i Mod KeyWordLength = 0) Then
                            loopCount += 1
                        End If
                        Keyword += Chr((((Asc(TempKeyArray(i Mod KeyWordLength)) - AlphaDiff) + loopCount) Mod AlphaCount) + AlphaDiff)
                    Next
                    FullKeyArray = Keyword.ToCharArray()
            End Select


            For i = 0 To FullCharArray.Length - 1
                If (Char.IsLetter(FullCharArray(i))) Then
                    Select Case (theKeyType)
                        Case KEYTYPES.Autokey
                            current_char = DecodeFromTabulaRecta(FullCharArray(i), FullKeyArray(i))
                            OutputString += current_char
                            FullKeyArray(index) = current_char
                            index += 1
                        Case Else
                            OutputString += DecodeFromTabulaRecta(FullCharArray(i), FullKeyArray(i))
                    End Select
                Else
                    PostError("Impossible characters appeared in input string.")   'Error
                    Return ""
                End If
            Next

            If (Verbose) Then
                OutputString += ControlChars.NewLine + ControlChars.NewLine
                OutputString += "Total Key String: " + ControlChars.NewLine + FullKeyArray
                OutputString += ControlChars.NewLine + ControlChars.NewLine
                OutputString += "Tabula Recta: " + ControlChars.NewLine + GetTabulaRecta()
            End If

            Return OutputString
        Else
            Return "A keyword must be selected."
        End If

    End Function
#End Region

#Region " Vigenere " 'DEPRECATED (see EncodeTabulaKey)
    Function EncodeVigenere(ByVal RawText As String) As String
        CreateTabulaRecta()
        RawText = RawText.ToLower()
        Dim Keyword As String = RemoveNonLetters(txtKey.Text.ToLower)
        If (Keyword.Length > 0) Then
            Dim OutputString As String = ""
            Dim FullCharArray As Char() = RawText.ToCharArray()
            Dim FullKeyArray As Char() = Keyword.ToCharArray()

            Dim i, j, numValue As Integer
            j = 0
            For i = 0 To FullCharArray.Length - 1
                If (Char.IsLetter(FullCharArray(i))) Then
                    OutputString += EncodeFromTabulaRecta(FullCharArray(i), FullKeyArray(j))
                    j += 1
                    j = j Mod Keyword.Length
                Else
                    OutputString += FullCharArray(i)
                End If
            Next

            Return OutputString
        Else
            Return "A keyword must be selected."
        End If

    End Function

    Function DecodeVigenere(ByVal RawText As String) As String
        CreateTabulaRecta()
        RawText = RawText.ToLower()
        Dim Keyword As String = RemoveNonLetters(txtKey.Text.ToLower)
        If (Keyword.Length > 0) Then
            Dim OutputString As String = ""
            Dim FullCharArray As Char() = RawText.ToCharArray()
            Dim FullKeyArray As Char() = Keyword.ToCharArray()

            Dim i, j, numValue As Integer
            j = 0
            For i = 0 To FullCharArray.Length - 1
                If (Char.IsLetter(FullCharArray(i))) Then
                    OutputString += DecodeFromTabulaRecta(FullCharArray(i), FullKeyArray(j))
                    j += 1
                    j = j Mod Keyword.Length
                Else
                    OutputString += FullCharArray(i)
                End If
            Next

            If (Verbose) Then
                OutputString += ControlChars.NewLine + ControlChars.NewLine
                OutputString += "Keyword: " + txtKey.Text
            End If

            Return OutputString
        Else
            Return "A keyword must be selected."
        End If

    End Function
#End Region

#Region " Caeser "
    Function EncodeCaesar(ByVal RawText As String) As String
        'Get offset
        Dim offSet As Integer = numSeed.Value

        RawText = RawText.ToLower()

        Dim OutputString As String = ""
        Dim FullCharArray As Char() = RawText.ToCharArray()
        Dim i, numValue As Integer
        For i = 0 To FullCharArray.Length - 1
            If (Char.IsLetter(FullCharArray(i))) Then
                'If it is a letter, rotate the ascii value by offset
                numValue = CharToDecimal(FullCharArray(i))
                numValue = (numValue + offSet) Mod AlphaCount
                OutputString += DecimalToChar(numValue)
            Else
                OutputString += FullCharArray(i)
            End If
        Next

        Return OutputString

    End Function

    Function DecodeCaesar(ByVal RawText As String) As String
        Dim offSet As Integer = numSeed.Value

        RawText = RawText.ToLower()

        Dim OutputString As String = ""
        Dim FullCharArray As Char() = RawText.ToCharArray()
        Dim i, numValue As Integer
        For i = 0 To FullCharArray.Length - 1
            If (Char.IsLetter(FullCharArray(i))) Then
                'If it is a letter, reverse rotate the ascii value by offset
                numValue = CharToDecimal(FullCharArray(i))
                numValue = (numValue + (AlphaCount * offSet) - offSet) Mod AlphaCount
                OutputString += DecimalToChar(numValue)
            Else
                OutputString += FullCharArray(i)
            End If
        Next

        If (Verbose) Then
            OutputString += ControlChars.NewLine + ControlChars.NewLine
            OutputString += "Offset: " + numSeed.Value.ToString()
        End If

        Return OutputString

    End Function
#End Region

#Region " Fragmenter "
    Function EncodeFragmenter(ByVal RawText As String) As String

        RawText = RawText.ToLower()
        RawText = RemoveWhiteSpace(RawText)
        RawText = RawText.Replace(".", " .")
        RawText = RawText.Replace(",", " ,")
        RawText = RawText.Replace("?", " ?")
        RawText = RawText.Replace("!", " !")

        Dim OutputString As String = ""
        Dim FirstString, SecondString As String
        Dim theWords() As String = RawText.Split(" ")
        Dim WordList As New ArrayList
        Dim i, newLength As Integer
        For i = 0 To theWords.Length - 1
            WordList.Add(theWords(i))
        Next

        i = 0
        While (i < WordList.Count)
            newLength = 0
            If (WordList(i).Length >= 6) Then
                newLength = randObj.Next(1, WordList(i).Length - 2)
            ElseIf (WordList(i).Length >= 3 And randObj.Next(0, 2) = 0) Then
                newLength = randObj.Next(1, 3)
            Else
                OutputString += WordList(i) + " "
            End If
            If newLength > 0 Then
                FirstString = WordList(i).Substring(0, newLength)
                SecondString = WordList(i).Substring(newLength) 'Might break?
                If (Not IsShortWord(FirstString) And Not IsShortWord(SecondString)) Then
                    WordList(i) = FirstString
                    WordList.Insert(i + 1, SecondString)
                Else
                    OutputString += WordList(i) + " "
                    i += 1
                End If
            Else
                i += 1
            End If
        End While

        Return OutputString
    End Function

    Function DecodeFragmenter(ByVal RawText As String) As String
        Return "Fragmenter can't be decoded, since it relies on the human ability to distinguish words regardless of spacing."
    End Function

#End Region

#Region " Morse "

    Function EncodeMorse(ByVal RawText As String) As String
        RawText = RawText.ToLower()
        RawText = RawText.Replace(".", ".-.-.- ")
        RawText = RawText.Replace("a", ".- ")
        RawText = RawText.Replace("b", "-... ")
        RawText = RawText.Replace("c", "-.-. ")
        RawText = RawText.Replace("d", "-.. ")
        RawText = RawText.Replace("e", ". ")
        RawText = RawText.Replace("f", "..-. ")
        RawText = RawText.Replace("g", "--. ")
        RawText = RawText.Replace("h", ".... ")
        RawText = RawText.Replace("i", ".. ")
        RawText = RawText.Replace("j", ".--- ")
        RawText = RawText.Replace("k", "-.- ")
        RawText = RawText.Replace("l", ".-.. ")
        RawText = RawText.Replace("m", "-- ")
        RawText = RawText.Replace("n", "-. ")
        RawText = RawText.Replace("o", "--- ")
        RawText = RawText.Replace("p", ".--. ")
        RawText = RawText.Replace("q", "--.- ")
        RawText = RawText.Replace("r", ".-. ")
        RawText = RawText.Replace("s", "... ")
        RawText = RawText.Replace("t", "- ")
        RawText = RawText.Replace("u", "..- ")
        RawText = RawText.Replace("v", "...- ")
        RawText = RawText.Replace("w", ".-- ")
        RawText = RawText.Replace("x", "-..- ")
        RawText = RawText.Replace("y", "-.-- ")
        RawText = RawText.Replace("z", "--.. ")
        RawText = RawText.Replace("1", ".---- ")
        RawText = RawText.Replace("2", "..--- ")
        RawText = RawText.Replace("3", "...-- ")
        RawText = RawText.Replace("4", "....- ")
        RawText = RawText.Replace("5", "..... ")
        RawText = RawText.Replace("6", "-.... ")
        RawText = RawText.Replace("7", "--... ")
        RawText = RawText.Replace("8", "---.. ")
        RawText = RawText.Replace("9", "----. ")
        RawText = RawText.Replace("0", "----- ")
        RawText = RawText.Replace("?", "..--.. ")
        RawText = RawText.Replace("!", "..--. ")
        RawText = RawText.Replace(":", "---... ")
        RawText = RawText.Replace("=", "-...- ")
        RawText = RawText.Replace(",", "--..-- ")

        Return RawText
    End Function

    Function DecodeMorse(ByVal RawText As String) As String
        'Sixes
        RawText = RawText.Replace(".-.-.- ", "@")
        RawText = RawText.Replace("--..-- ", ",")
        RawText = RawText.Replace("---... ", ":")
        RawText = RawText.Replace("..--.. ", "?")

        'Fives
        RawText = RawText.Replace(".---- ", "1")
        RawText = RawText.Replace("..--- ", "2")
        RawText = RawText.Replace("...-- ", "3")
        RawText = RawText.Replace("....- ", "4")
        RawText = RawText.Replace("..... ", "5")
        RawText = RawText.Replace("-.... ", "6")
        RawText = RawText.Replace("--... ", "7")
        RawText = RawText.Replace("---.. ", "8")
        RawText = RawText.Replace("----. ", "9")
        RawText = RawText.Replace("----- ", "0")
        RawText = RawText.Replace("..--. ", "!")
        RawText = RawText.Replace("-...- ", "=")

        'Fours
        RawText = RawText.Replace("-... ", "b")
        RawText = RawText.Replace("-.-. ", "c")
        RawText = RawText.Replace("..-. ", "f")
        RawText = RawText.Replace(".... ", "h")
        RawText = RawText.Replace(".--- ", "j")
        RawText = RawText.Replace(".-.. ", "l")
        RawText = RawText.Replace(".--. ", "p")
        RawText = RawText.Replace("--.- ", "q")
        RawText = RawText.Replace("...- ", "v")
        RawText = RawText.Replace("-..- ", "x")
        RawText = RawText.Replace("-.-- ", "y")
        RawText = RawText.Replace("--.. ", "z")

        'Threes
        RawText = RawText.Replace("-.. ", "d")
        RawText = RawText.Replace("--. ", "g")
        RawText = RawText.Replace("-.- ", "k")
        RawText = RawText.Replace("--- ", "o")
        RawText = RawText.Replace(".-. ", "r")
        RawText = RawText.Replace("... ", "s")
        RawText = RawText.Replace("..- ", "u")
        RawText = RawText.Replace(".-- ", "w")

        'Twos
        RawText = RawText.Replace(".- ", "a")
        RawText = RawText.Replace(".. ", "i")
        RawText = RawText.Replace("-- ", "m")
        RawText = RawText.Replace("-. ", "n")

        'Ones
        RawText = RawText.Replace(". ", "e")
        RawText = RawText.Replace("- ", "t")

        RawText = RawText.Replace("@", ".")

        If (Verbose) Then
            Dim MorseString As String = ".- -... -.-. -.. . ..-. --. .... .. .--- -.- .-.. -- -. --- .--. --.- .-. ... - ..- ...- .-- -..- -.-- --.."
            Dim CharMapper() As String = MorseString.Split(" ")
            RawText += OutputTranslation(CharMapper)
        End If


        Return RawText
    End Function
#End Region

#Region " Grid 5 "
    Function EncodeGrid5(ByVal RawText As String) As String
        'Encodes into five-digit (0-31) binary and then puts all the letters for a word
        'in a vertical stack (thus making a 5xlength grid). The new binary numbers are
        'read down each column and translated back into decimal, thus turning every 
        'word into a five number sequence.

        RawText = RawText.ToLower()
        RawText = RemoveWhiteSpace(RawText)

        Dim OutputString As String = ""
        Dim BinaryStr As String

        'Initialize variables
        Dim NewWords(MaxBinarySize) As String
        Dim i, j, k As Integer
        Dim WordArray() As String
        Dim theWord() As Char
        'Divide into words
        WordArray = RawText.Split(" ")

        For i = 0 To WordArray.Length - 1
            If (WordArray(i).Length > 0) Then
                'Quick fix for short words that begin with early letters (letter combined)
                If (WordArray(i).Length <= 3) Then
                    If (WordArray(i).StartsWith("a")) Then
                        WordArray(i) = "a" + WordArray(i)
                    ElseIf (WordArray(i).StartsWith("b")) Then
                        WordArray(i) = "b" + WordArray(i)
                    ElseIf (WordArray(i).StartsWith("i")) Then
                        WordArray(i) = "i" + WordArray(i)
                    End If
                End If

                'Clear strings for new input
                theWord = WordArray(i).ToCharArray()
                For k = 0 To MaxBinarySize - 1
                    NewWords(k) = ""
                Next
                For j = 0 To theWord.Length - 1
                    'Create Binary numbers out of individual letters
                    BinaryStr = DecimalToBinary(CharToDecimal(theWord(j))).ToString()
                    'Ensure five digits
                    BinaryStr = BinaryStr.PadLeft(MaxBinarySize, "0")
                    Try
                        For k = 0 To MaxBinarySize - 1
                            NewWords(k) += BinaryStr.Substring(k, 1)
                        Next
                    Catch ex As Exception
                        PostError("Error parsing binary grid structure.")
                        Return "Error"
                    End Try
                Next
                For k = 0 To MaxBinarySize - 1
                    'Return all five binaries to decimal for display
                    OutputString += BinaryToDecimal(NewWords(k)).ToString() + " "
                Next
            End If
        Next

        Return OutputString
    End Function

    Function DecodeGrid5(ByVal RawText As String) As String
        Dim OutputString As String = ""
        Dim BinaryStr As String

        'Initialize variables
        Dim NewWords(MaxBinarySize) As String
        Dim i, j, k, m, currentLength, maxLength, wordLength As Integer
        Dim WordArray() As String
        Dim GridArray(,) As String
        Dim theWord() As Char

        'Clean out white space
        RawText = RemoveWhiteSpace(RawText)

        'Divide into words
        WordArray = RawText.Trim().Split(" ")

        'Try
        For m = 0 To WordArray.Length - 1 Step 5
            'Find length of word as a power of two
            maxLength = 0
            For k = 0 To MaxBinarySize - 1
                currentLength = WordArray(m + k)
                If (currentLength > maxLength) Then
                    maxLength = currentLength
                End If
            Next
            If (maxLength > 0) Then
                wordLength = Math.Ceiling(Math.Log(maxLength, 2))
            Else
                wordLength = 1
            End If

            'Create grid and write to it in horizontal rows
            ReDim GridArray(wordLength - 1, MaxBinarySize - 1)
            For j = 0 To MaxBinarySize - 1
                theWord = DecimalToBinary(Microsoft.VisualBasic.Val(WordArray(m + j))).PadLeft(wordLength, "0").ToCharArray()
                For i = 0 To wordLength - 1
                    GridArray(i, j) = theWord(i)
                Next
            Next
            'Read from grid in vertical columns for each letter
            For i = 0 To wordLength - 1
                BinaryStr = ""
                For j = 0 To MaxBinarySize - 1
                    BinaryStr += GridArray(i, j)
                Next
                OutputString += DecimalToChar(BinaryToDecimal(BinaryStr))
            Next
            OutputString += " "
        Next

        Return OutputString
        'Catch ex As Exception
        '    PostError("Coded string has been irreparably tampered with.")
        '    Return "Error"
        'End Try

    End Function
#End Region

#Region " ASCII "
    Function EncodeASCII(ByVal RawText As String) As String
        'Convert characters to ASCII

        Dim OutputString As String = ""
        Dim i As Integer
        Dim FullCharArray() As Char
        FullCharArray = RawText.ToCharArray

        For i = 0 To FullCharArray.Length - 1
            OutputString += Asc(FullCharArray(i)).ToString() + " "
        Next

        Return OutputString
    End Function

    Function DecodeASCII(ByVal RawText As String) As String
        RawText = RawText.Trim()
        Dim OutputString As String = ""
        Dim i As Integer
        Dim FullStringArray() As String
        FullStringArray = RawText.Split(" ")

        For i = 0 To FullStringArray.Length - 1
            If (Not FullStringArray(i) = " ") Then
                OutputString += Chr(FullStringArray(i)).ToString()
            End If
        Next

        If (Verbose) Then
            Dim CharMapper(AlphaCount - 1) As String
            For i = 0 To AlphaCount - 1
                CharMapper(i) = (i + AlphaDiff).ToString()
            Next
            OutputString += OutputTranslation(CharMapper)
        End If

        Return OutputString
    End Function
#End Region

#Region " Binary "
    Function EncodeBinary(ByVal RawText As String) As String
        'A = 0, B = 1, C = 10, D = 11, E = 100 and so on.

        RawText = ConvertNumbers(RawText.ToLower())
        Dim OutputString As String = ""
        Dim i As Integer
        Dim FullCharArray() As Char
        FullCharArray = RawText.ToCharArray

        For i = 0 To FullCharArray.Length - 1
            OutputString += DecimalToBinary(CharToDecimal(FullCharArray(i)), 5).ToString()
        Next

        OutputString = KeyXOR(OutputString)

        Return OutputString
    End Function

    Function DecodeBinary(ByVal RawText As String) As String
        RawText = KeyXOR(RawText)

        RawText = RawText.Trim()
        Dim OutputString As String = ""
        Dim i As Integer
        Dim FullCharArray() As Char = RawText.ToCharArray()
        Dim theBinaryName As String = ""

        For i = 0 To FullCharArray.Length - 1
            If (FullCharArray(i) = "0"c Or FullCharArray(i) = "1"c) Then
                theBinaryName += FullCharArray(i)
                If (theBinaryName.Length >= 5) Then
                    OutputString += Binary5ToASCIIString(theBinaryName)
                    theBinaryName = ""
                End If
            End If
        Next

        If (Verbose) Then
            Dim CharMapper(AlphaCount - 1) As String
            For i = 0 To AlphaCount - 1
                CharMapper(i) = DecimalToBinary(i, 5)
            Next
            OutputString += OutputTranslation(CharMapper)
            OutputString += ControlChars.NewLine + ControlChars.NewLine
            OutputString += "Binary Key: "
            Dim KeyString As String = ConvertNumbers(txtKey.Text)
            Dim oldKey() As Char = KeyString.ToCharArray()
            For i = 0 To oldKey.Length - 1
                OutputString += DecimalToBinary(CharToDecimal(oldKey(i)), 5)
            Next
        End If

        Return OutputString
    End Function
#End Region

#Region " Basic Numeric "
    Function EncodeBasicNumeric(ByVal RawText As String) As String
        'A = 1, B = 2 and so on.

        RawText = RemoveWhiteSpace(RawText.ToLower())
        Dim OutputString As String = ""
        Dim i As Integer
        Dim FullCharArray() As Char
        FullCharArray = RawText.ToCharArray

        For i = 0 To FullCharArray.Length - 1
            OutputString += CharToDecimal(FullCharArray(i)).ToString() + " "
        Next

        Return OutputString
    End Function

    Function DecodeBasicNumeric(ByVal RawText As String) As String
        RawText = RawText.Trim()
        Dim OutputString As String = ""
        Dim i As Integer
        Dim FullStringArray() As String
        FullStringArray = RawText.Split(" ")

        For i = 0 To FullStringArray.Length - 1
            If (Not FullStringArray(i) = " ") Then
                OutputString += DecimalToChar(FullStringArray(i)).ToString()
            End If
        Next

        If (Verbose) Then
            Dim CharMapper(AlphaCount - 1) As String
            For i = 0 To AlphaCount - 1
                CharMapper(i) = (i + 1).ToString()
            Next
            OutputString += OutputTranslation(CharMapper)
        End If

        Return OutputString
    End Function

#End Region

#Region " Alternator "

    Function EncodeAlternator(ByVal RawText As String) As String
        'Alternator encodes lowercase letters into lowercase, uppercase and numbers.
        'It works by taking a letter and following it with a number if the next letter
        'is within 9 of the first letter (in ascii/alphabet). If so, the second number
        'is replaced with the difference between them. If it was subtracted, the first
        'number is capitalized.

        'Begin by SingleSubstituting
        RawText = RawText.ToLower()
        'RawText = EncodeSingleSub(RawText)

        Dim i, j, asciiDiff As Integer
        Dim FullCharArray() As Char
        FullCharArray = RawText.ToCharArray
        For i = 0 To FullCharArray.Length - 2
            'Loop through the entire string
            If (Char.IsLetter(FullCharArray(i))) Then
                j = i + 1
                While (Not Char.IsLetter(FullCharArray(j)))
                    'Examine every two successive letters regardless of intervening
                    'white space, numbers and punctuation.
                    j = j + 1
                    If j >= FullCharArray.Length Then
                        Exit For    'End check
                    End If
                End While

                'Distance between two successive letters
                asciiDiff = Asc(FullCharArray(j)) - Asc(FullCharArray(i))

                If (asciiDiff >= 0 And asciiDiff <= 9) Then
                    'Positive jump
                    FullCharArray(j) = Chr(asciiDiff + NumeralDiff)
                    i = j
                ElseIf (asciiDiff < 0 And asciiDiff >= -9) Then
                    'Negative jump (capitalize first letter)
                    FullCharArray(j) = Chr(Math.Abs(asciiDiff) + NumeralDiff)
                    FullCharArray(i) = Char.ToUpper(FullCharArray(i))
                    i = j
                End If

            End If
        Next

        Return FullCharArray
    End Function

    Function DecodeAlternator(ByVal RawText As String) As String
        Dim i, j, asciiDiff As Integer
        Dim FullCharArray() As Char
        Dim checker As Boolean
        FullCharArray = RawText.ToCharArray
        'Loop through the entire string
        For i = 0 To FullCharArray.Length - 2
            If (Char.IsLetter(FullCharArray(i))) Then
                j = i + 1
                checker = True
                'Find letter is followed by number
                While (Not Char.IsNumber(FullCharArray(j)))
                    If (Char.IsLetter(FullCharArray(j))) Then
                        'Intervening letter
                        checker = False
                        Exit While
                    End If
                    j = j + 1
                    If j >= FullCharArray.Length Then
                        Exit For    'End Check
                    End If
                End While
                If checker Then
                    If (Char.IsUpper(FullCharArray(i))) Then
                        'Capitalized letter means jump backward
                        FullCharArray(i) = Char.ToLower(FullCharArray(i))
                        FullCharArray(j) = Chr(Asc(FullCharArray(i)) - (Asc(FullCharArray(j)) - NumeralDiff))
                    Else
                        'Lowercase letter means jump forward
                        FullCharArray(j) = Chr(Asc(FullCharArray(i)) + (Asc(FullCharArray(j)) - NumeralDiff))
                    End If
                End If

            End If
        Next

        Dim EndText As String = FullCharArray
        'EndText = DecodeSingleSub(EndText)
        Return EndText
    End Function

#End Region

#Region " Single Sub "

    Function EncodeSingleSub(ByVal RawText As String) As String
        Dim i, asciiValue As Integer
        Dim CharMapper As Char() = GenerateMapper26()

        'Replace
        RawText = RawText.ToLower()
        Dim FullCharArray() As Char
        FullCharArray = RawText.ToCharArray
        For i = 0 To FullCharArray.Length - 1
            If (Char.IsLetter(FullCharArray(i))) Then
                asciiValue = Asc(FullCharArray(i)) - AlphaDiff
                FullCharArray(i) = CharMapper(asciiValue)
            End If
        Next

        Return FullCharArray
    End Function

    Function DecodeSingleSub(ByVal RawText As String) As String
        Dim CharMapper As Char() = GenerateMapper26()
        Dim i, asciiValue, indexValue As Integer

        'Replace
        Dim FullCharArray() As Char
        FullCharArray = RawText.ToCharArray
        For i = 0 To FullCharArray.Length - 1
            If (Char.IsLetter(FullCharArray(i))) Then
                'Use stored mapping
                FullCharArray(i) = Chr(Array.IndexOf(CharMapper, FullCharArray(i)) + AlphaDiff)
            End If
        Next

        Dim OutputString As String = FullCharArray
        If (Verbose) Then
            OutputString += OutputTranslation(CharMapper)
        End If

        Return OutputString
    End Function
#End Region

#Region " Double Sub "

    Function EncodeDoubleSub(ByVal RawText As String) As String
        Dim i, asciiValue As Integer
        Dim CharMapper As Char(,) = GenerateMapper52()

        'Replace
        RawText = RawText.ToLower()
        Dim FullCharArray() As Char
        FullCharArray = RawText.ToCharArray
        For i = 0 To FullCharArray.Length - 1
            If (Char.IsLetter(FullCharArray(i))) Then
                asciiValue = Asc(FullCharArray(i)) - AlphaDiff
                FullCharArray(i) = CharMapper(asciiValue, randObj.Next(0, 2))
            End If
        Next

        Return FullCharArray
    End Function

    Function DecodeDoubleSub(ByVal RawText As String) As String
        Dim i, j, k, indexValue As Integer
        Dim CharMapper As Char(,) = GenerateMapper52()
        'Replace
        Dim FullCharArray() As Char
        FullCharArray = RawText.ToCharArray
        For i = 0 To FullCharArray.Length - 1
            If (Char.IsLetter(FullCharArray(i))) Then
                'Use stored mapping
                j = 0
                While (j < AlphaCount)
                    For k = 0 To 1
                        If (FullCharArray(i) = CharMapper(j, k)) Then
                            FullCharArray(i) = Chr(j + AlphaDiff)
                            Exit While
                        End If
                    Next
                    j += 1
                End While
            End If
        Next

        Dim OutputString As String = FullCharArray
        'If (Verbose) Then
        '    OutputString += OutputTranslation(CharMapper)
        'End If

        Return OutputString
    End Function
#End Region

#Region " Grouper "

    Function EncodeGrouper(ByVal RawText As String) As String
        'Setup alphabetic output segments
        Dim OutputMain As String = ""
        Dim OutputParen As String = ""
        Dim OutputBracket As String = ""
        Dim OutputBrace As String = ""
        Dim OutputArrow As String = ""
        Dim FullCharArray() As Char
        'Format text to prevent errors (remove control chars)
        RawText = RawText.ToLower()
        RawText = RawText.Replace("(", "")
        RawText = RawText.Replace(")", "")
        RawText = RawText.Replace("[", "")
        RawText = RawText.Replace("]", "")
        RawText = RawText.Replace("{", "")
        RawText = RawText.Replace("}", "")
        RawText = RawText.Replace("<", "")
        RawText = RawText.Replace(">", "")
        FullCharArray = RawText.ToCharArray()
        Dim TextLength As Integer = FullCharArray.Length - 1

        'Initialize loop data
        Dim currentChar As Char
        Dim i, nextMatch, nextParen, nextBracket, nextBrace, nextArrow As Integer
        nextParen = TextLength + 1
        nextBracket = TextLength + 1
        nextBrace = TextLength + 1
        nextArrow = TextLength + 1
        For i = 0 To TextLength - 1
            currentChar = FullCharArray(i)
            If (currentChar.CompareTo(" "c) = 0) Then
                'Replace blanks with "0"
                FullCharArray(i) = GrouperSpace
            ElseIf (currentChar.CompareTo(")"c) <> 0 And currentChar.CompareTo("]"c) <> 0 And currentChar.CompareTo("}"c) <> 0 And currentChar.CompareTo(">"c) <> 0) Then
                'Update positions that have been passed
                If i > nextParen Then
                    nextParen = Array.IndexOf(FullCharArray, ")"c, i + 1)
                    If (nextParen = -1) Then
                        nextParen = TextLength + 1
                    End If
                End If
                If i > nextBracket Then
                    nextBracket = Array.IndexOf(FullCharArray, "]"c, i + 1)
                    If (nextBracket = -1) Then
                        nextBracket = TextLength + 1
                    End If
                End If
                If i > nextBrace Then
                    nextBrace = Array.IndexOf(FullCharArray, "}"c, i + 1)
                    If (nextBrace = -1) Then
                        nextBrace = TextLength + 1
                    End If
                End If
                If i > nextArrow Then
                    nextArrow = Array.IndexOf(FullCharArray, ">"c, i + 1)
                    If (nextArrow = -1) Then
                        nextArrow = TextLength + 1
                    End If
                End If

                nextMatch = Array.IndexOf(FullCharArray, currentChar, i + 1)
                'Replace letters and update closest grouping characters
                If nextMatch = -1 Then
                    'Leave as current character
                ElseIf nextMatch < nextParen Then
                    FullCharArray(i) = "("
                    FullCharArray(nextMatch) = ")"
                    nextParen = nextMatch
                    OutputParen += currentChar
                ElseIf nextMatch < nextBracket Then
                    FullCharArray(i) = "["
                    FullCharArray(nextMatch) = "]"
                    nextBracket = nextMatch
                    OutputBracket += currentChar
                ElseIf nextMatch < nextBrace Then
                    FullCharArray(i) = "{"
                    FullCharArray(nextMatch) = "}"
                    nextBrace = nextMatch
                    OutputBrace += currentChar
                ElseIf nextMatch < nextArrow Then
                    FullCharArray(i) = "<"
                    FullCharArray(nextMatch) = ">"
                    nextArrow = nextMatch
                    OutputArrow += currentChar
                End If
            End If
        Next

        'Format Output
        Dim FullResult As String = ""
        FullResult += FullCharArray + " " + OutputParen + OutputBracket + OutputBrace + OutputArrow
        Return FullResult
    End Function

    Function DecodeGrouper(ByVal RawText As String) As String
        Dim EndText As String = ""
        Dim FullCharArray() As Char
        FullCharArray = RawText.ToCharArray()
        Dim Separator As Integer
        Separator = Array.IndexOf(FullCharArray, " "c) + 1
        If Separator >= 0 Then
            'Replace grouping characters with letters, by segment
            Separator = GrouperFillInChar("("c, ")"c, Separator, FullCharArray)
            Separator = GrouperFillInChar("["c, "]"c, Separator, FullCharArray)
            Separator = GrouperFillInChar("{"c, "}"c, Separator, FullCharArray)
            Separator = GrouperFillInChar("<"c, ">"c, Separator, FullCharArray)
        End If
        'Put spaces back in
        EndText = FullCharArray
        Try
            EndText = EndText.Substring(0, Array.IndexOf(FullCharArray, " "c))
        Catch ex As Exception
            'Someone messed with separation of first/second part
        End Try
        EndText = EndText.Replace(GrouperSpace, " ")
        Return EndText
    End Function

    Function GrouperFillInChar(ByVal Symbol As Char, ByVal ReverseSymbol As Char, ByVal Separator As Integer, ByRef FullCharArray As Char()) As Integer
        Dim i, opener, closer, stopper As Integer
        stopper = Array.IndexOf(FullCharArray, " "c)
        Dim charStack As New Stack
        i = -1
        'Loop through and find nested grouping pairs and replace with letters
        While (i < stopper)
            opener = Array.IndexOf(FullCharArray, Symbol, i + 1)
            closer = Array.IndexOf(FullCharArray, ReverseSymbol, i + 1)
            If (opener < 0 And closer < 0) Then
                Exit While
            ElseIf (opener >= 0 And opener < closer) Then
                'Open case ( [ { <
                If (Separator < FullCharArray.Length) Then
                    FullCharArray(opener) = FullCharArray(Separator)
                    charStack.Push(FullCharArray(Separator))
                    Separator += 1
                End If
                i = opener
            ElseIf (closer >= 0) Then
                'Close case ) ] } >
                If charStack.Count > 0 Then
                    FullCharArray(closer) = charStack.Pop()
                End If
                i = closer
            End If
        End While
        Return Separator
    End Function
#End Region

#Region " Maze Coder "

    Function EncodeMaze(ByVal RawText As String) As String

        'Setup recognized characters (all others will be lost)
        Dim i As Integer
        Dim CharList As ArrayList = CreateAlphabetList32()
        Dim CharArray(CharList.Count - 1) As Char
        For i = 0 To CharList.Count - 1
            CharArray(i) = CharList(i)
        Next

        'Initialize the maze
        Dim Width As Integer = 0
        Dim Height As Integer = 0
        Dim theMaze(Width, Height) As Char
        theMaze(0, 0) = StartMazeChar
        Dim x, y, direction, distance As Integer
        RawText = RawText.ToLower()
        RawText = "a" + RawText 'Always start by going one to the right
        Dim FullCharArray() As Char
        FullCharArray = RawText.ToCharArray
        x = 0
        y = 0

        'Expand maze
        For i = 0 To FullCharArray.Length - 1
            'Determine distance and direction of next movement
            direction = Array.IndexOf(CharArray, FullCharArray(i)) Mod 4
            distance = (Array.IndexOf(CharArray, FullCharArray(i)) \ 4) + 1
            If (direction >= 0) Then
                'Set direction character
                If Not (i = 0) Then
                    Select Case direction
                        Case 0
                            If (distance > 4) Then
                                distance -= 4
                                theMaze(x, y) = "E"c
                            Else
                                theMaze(x, y) = "e"c
                            End If
                        Case 1
                            If (distance > 4) Then
                                distance -= 4
                                theMaze(x, y) = "N"c
                            Else
                                theMaze(x, y) = "n"c
                            End If
                        Case 2
                            If (distance > 4) Then
                                distance -= 4
                                theMaze(x, y) = "W"c
                            Else
                                theMaze(x, y) = "w"c
                            End If
                        Case 3
                            If (distance > 4) Then
                                distance -= 4
                                theMaze(x, y) = "S"c
                            Else
                                theMaze(x, y) = "s"c
                            End If
                    End Select
                End If

                'Begin tunneling
                While (distance > 0)
                    distance -= 1
                    Select Case direction
                        Case 0
                            x += 1
                        Case 1
                            y -= 1
                        Case 2
                            x -= 1
                        Case 3
                            y += 1
                    End Select
                    theMaze = ExpandMaze(theMaze, Width, Height, x, y, distance)
                End While
            End If
        Next
        theMaze(x, y) = EndMazeChar

        'Format output as box
        Dim OutputString As String = ""
        Dim j As Integer
        For j = 0 To Height
            For i = 0 To Width
                OutputString += theMaze(i, j)
            Next
            OutputString += ControlChars.NewLine
        Next

        Return OutputString
    End Function

    Function DecodeMaze(ByVal RawText As String) As String

        'Setup recognized characters (all others will be lost)
        Dim i, j, k As Integer
        Dim CharList As ArrayList = CreateAlphabetList32()
        Dim CharArray(CharList.Count - 1) As Char
        For i = 0 To CharList.Count - 1
            CharArray(i) = CharList(i)
        Next

        'Pull out information and initialize
        Dim width, height, position, direction, distance, charValue As Integer
        Dim OutputString As String = ""
        Dim FullCharArray() As Char
        FullCharArray = RawText.ToCharArray
        width = RawText.IndexOf(Chr(13)) + 2
        height = (RawText.LastIndexOf(Chr(13)) + 1) / width
        position = RawText.IndexOf(StartMazeChar)

        'First char is a (go one step right)
        FullCharArray(position) = "_"c
        position += 1

        If (RawText.IndexOf(EndMazeChar) = -1) Then
            'No ending position found
            Exit Function
        End If

        'Solve Maze
        Dim currentChar As Char
        While (Not FullCharArray(position) = EndMazeChar)
            currentChar = FullCharArray(position)
            FullCharArray(position) = "_"c
            'Establish direction to start counting
            If (currentChar = WallChar) Then
                'Should never hit wall
                PostError("Error, maze was tampered with")
                Return ""
            ElseIf (Char.ToLower(currentChar) = "e"c) Then
                direction = 0
                position += 1
            ElseIf (Char.ToLower(currentChar) = "n"c) Then
                direction = 1
                position -= width
            ElseIf (Char.ToLower(currentChar) = "w"c) Then
                direction = 2
                position -= 1
            ElseIf (Char.ToLower(currentChar) = "s"c) Then
                direction = 3
                position += width
            End If

            'Start counting
            distance = 1
            While (FullCharArray(position) = " "c Or FullCharArray(position) = "_"c)
                If (FullCharArray(position) = " "c) Then
                    'Count only steps we haven't taken before
                    FullCharArray(position) = "_"c
                    distance += 1
                End If
                'Step onward
                Select Case direction
                    Case 0
                        position += 1
                    Case 1
                        position -= width
                    Case 2
                        position -= 1
                    Case 3
                        position += width
                End Select
            End While
            If (FullCharArray(position) = WallChar) Then
                'Should never hit wall
                PostError("Error, maze was tampered with")
                Return "Error"
            End If

            'Insert the next letter based on movement through maze
            charValue = ((distance - 1) * 4) + direction
            If (Char.IsUpper(currentChar)) Then
                charValue += 16
            End If
            OutputString += CharArray(charValue)
        End While

        'Verbose Mode
        If (Verbose) Then
            OutputString += ControlChars.NewLine + ControlChars.NewLine
            OutputString += "Legend: " + ControlChars.NewLine
            Dim letter As Char
            Dim dir As String
            For k = 1 To 2
                For j = 0 To 3
                    For i = 0 To 3
                        Select Case i
                            Case 0
                                letter = "e"
                                dir = "east"
                            Case 1
                                letter = "n"
                                dir = "north"
                            Case 2
                                letter = "w"
                                dir = "west"
                            Case 3
                                letter = "s"
                                dir = "south"
                        End Select
                        If (k = 2) Then
                            letter = Char.ToUpper(letter)
                        End If
                        OutputString += CharList(((j * 4) + i) * k) + " = " + letter + "(" + dir + ") by " + (j + 1).ToString + ",  "
                    Next
                    OutputString += ControlChars.NewLine
                Next
            Next

        End If

        Return OutputString
    End Function

    Function ExpandMaze(ByVal theMaze As Char(,), ByRef width As Integer, ByRef height As Integer, ByRef x As Integer, ByRef y As Integer, ByRef dist As Integer) As Char(,)
        Dim newMaze(,) As Char

        If x < 0 Then               'Add column on left
            ReDim newMaze(width + 1, height)
            Dim i, j As Integer
            For j = 0 To height
                'First char in each row gets a wall
                newMaze(0, j) = WallChar
                For i = 0 To width
                    'Everything else gets copied
                    newMaze(i + 1, j) = theMaze(i, j)
                Next
            Next
            width += 1
            x = 0
        ElseIf y < 0 Then           'Add Row on top
            ReDim newMaze(width, (height + 1))
            Dim i, j As Integer
            For j = 0 To height
                For i = 0 To width
                    If (j = 0) Then
                        'First row gets a wall
                        newMaze(i, j) = WallChar
                    End If
                    'Everything else gets copied
                    newMaze(i, j + 1) = theMaze(i, j)
                Next
            Next
            height += 1
            y = 0
        ElseIf x > width Then      'Add column on right
            ReDim newMaze(width + 1, height)
            Dim i, j As Integer
            For j = 0 To height
                For i = 0 To width
                    'Everything else gets copied
                    newMaze(i, j) = theMaze(i, j)
                Next
                'Last char in each row is a wall
                newMaze(i, j) = WallChar
            Next
            width += 1
        ElseIf y > height Then     'Add Row on bottom
            ReDim newMaze(width, (height + 1))
            Dim i, j As Integer
            For j = 0 To height + 1
                For i = 0 To width
                    If (j = height + 1) Then
                        'Last row gets a wall
                        newMaze(i, j) = WallChar
                    Else
                        'Everything else gets copied
                        newMaze(i, j) = theMaze(i, j)
                    End If
                Next
            Next
            height += 1
        Else
            newMaze = theMaze
        End If

        'Legal expansion
        If (newMaze(x, y).CompareTo(WallChar) = 0) Then
            newMaze(x, y) = " "c
        Else
            'Do not decrease distance
            dist += 1
        End If
        Return newMaze
    End Function
#End Region

#Region " Buttons "
    Private Sub ubOptions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubOptions.Click
        Dim OptionScreen As New Options
        If OptionScreen.ShowDialog() <> DialogResult.OK Then
            Me.DialogResult = DialogResult.No
            Me.Close()
        End If
        LoadOptions()
        UpdateOptions()
    End Sub

    Private Sub ubInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubInfo.Click
        SetInfo()
    End Sub

    Private Sub ubEncode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubEncode.Click
        InitialText = txtInitial.Text
        InitialSeed = numSeed.Value
        InitialCode = cbSystem.Text
        InitialKey = txtKey.Text
        SaveOptions()
        Encode()
    End Sub

    Private Sub ubDecode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubDecode.Click
        Decode()
    End Sub

    Private Sub ubRecipher_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubRecipher.Click
        txtInitial.Text = txtEncode.Text
    End Sub

    Private Sub ubRedecipher_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubRedecipher.Click
        txtEncode.Text = txtDecode.Text
    End Sub
#End Region

End Class
