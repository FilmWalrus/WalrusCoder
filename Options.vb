Public Class Options
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
    Friend WithEvents ubOK As System.Windows.Forms.Button
    Friend WithEvents ubCancel As System.Windows.Forms.Button
    Friend WithEvents cbAlwaysRemove As System.Windows.Forms.CheckBox
    Friend WithEvents cbVerbose As System.Windows.Forms.CheckBox
    Friend WithEvents cbAlwaysSub As System.Windows.Forms.CheckBox
    Friend WithEvents cbCryptanalysis As System.Windows.Forms.CheckBox
    Friend WithEvents gbDisplay As System.Windows.Forms.GroupBox
    Friend WithEvents gbAlphabets As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rbJ As System.Windows.Forms.RadioButton
    Friend WithEvents rbQ As System.Windows.Forms.RadioButton
    Friend WithEvents rbZ As System.Windows.Forms.RadioButton
    Friend WithEvents rbX As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents rbSymbols As System.Windows.Forms.RadioButton
    Friend WithEvents rbShort As System.Windows.Forms.RadioButton
    Friend WithEvents rbLong As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents numSpacing As System.Windows.Forms.NumericUpDown
    Friend WithEvents cbAlwaysConvertNumbers As System.Windows.Forms.CheckBox
    Friend WithEvents gbRoutes As System.Windows.Forms.GroupBox
    Friend WithEvents cbArch As System.Windows.Forms.CheckBox
    Friend WithEvents cbSpiral As System.Windows.Forms.CheckBox
    Friend WithEvents cbDiagonal As System.Windows.Forms.CheckBox
    Friend WithEvents cbZigzag As System.Windows.Forms.CheckBox
    Friend WithEvents cbRaster As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbSwirl As System.Windows.Forms.CheckBox
    Friend WithEvents cbInverse As System.Windows.Forms.CheckBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Vertical As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cbKnight As System.Windows.Forms.CheckBox
    Friend WithEvents rbVYes As System.Windows.Forms.RadioButton
    Friend WithEvents rbVNo As System.Windows.Forms.RadioButton
    Friend WithEvents rbVMaybe As System.Windows.Forms.RadioButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents rbRMaybe As System.Windows.Forms.RadioButton
    Friend WithEvents rbRNo As System.Windows.Forms.RadioButton
    Friend WithEvents rbRYes As System.Windows.Forms.RadioButton
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents rbCMaybe As System.Windows.Forms.RadioButton
    Friend WithEvents rbCNo As System.Windows.Forms.RadioButton
    Friend WithEvents rbCYes As System.Windows.Forms.RadioButton
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents rbPMaybe As System.Windows.Forms.RadioButton
    Friend WithEvents rbPNo As System.Windows.Forms.RadioButton
    Friend WithEvents rbPYes As System.Windows.Forms.RadioButton
    Friend WithEvents cbAlwaysRoute As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Options))
        Me.ubOK = New System.Windows.Forms.Button()
        Me.ubCancel = New System.Windows.Forms.Button()
        Me.cbAlwaysRemove = New System.Windows.Forms.CheckBox()
        Me.cbVerbose = New System.Windows.Forms.CheckBox()
        Me.cbAlwaysSub = New System.Windows.Forms.CheckBox()
        Me.cbCryptanalysis = New System.Windows.Forms.CheckBox()
        Me.gbDisplay = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.numSpacing = New System.Windows.Forms.NumericUpDown()
        Me.gbRoutes = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Vertical = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbInverse = New System.Windows.Forms.CheckBox()
        Me.cbSwirl = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbRaster = New System.Windows.Forms.CheckBox()
        Me.cbZigzag = New System.Windows.Forms.CheckBox()
        Me.cbDiagonal = New System.Windows.Forms.CheckBox()
        Me.cbSpiral = New System.Windows.Forms.CheckBox()
        Me.cbArch = New System.Windows.Forms.CheckBox()
        Me.cbAlwaysRoute = New System.Windows.Forms.CheckBox()
        Me.cbKnight = New System.Windows.Forms.CheckBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.rbVMaybe = New System.Windows.Forms.RadioButton()
        Me.rbVNo = New System.Windows.Forms.RadioButton()
        Me.rbVYes = New System.Windows.Forms.RadioButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.rbRMaybe = New System.Windows.Forms.RadioButton()
        Me.rbRNo = New System.Windows.Forms.RadioButton()
        Me.rbRYes = New System.Windows.Forms.RadioButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.rbCMaybe = New System.Windows.Forms.RadioButton()
        Me.rbCNo = New System.Windows.Forms.RadioButton()
        Me.rbCYes = New System.Windows.Forms.RadioButton()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.rbPMaybe = New System.Windows.Forms.RadioButton()
        Me.rbPNo = New System.Windows.Forms.RadioButton()
        Me.rbPYes = New System.Windows.Forms.RadioButton()
        Me.gbAlphabets = New System.Windows.Forms.GroupBox()
        Me.rbX = New System.Windows.Forms.RadioButton()
        Me.rbJ = New System.Windows.Forms.RadioButton()
        Me.rbQ = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rbZ = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.rbSymbols = New System.Windows.Forms.RadioButton()
        Me.rbShort = New System.Windows.Forms.RadioButton()
        Me.rbLong = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbAlwaysConvertNumbers = New System.Windows.Forms.CheckBox()
        Me.gbDisplay.SuspendLayout()
        CType(Me.numSpacing, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbRoutes.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.gbAlphabets.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ubOK
        '
        Me.ubOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ubOK.BackColor = System.Drawing.Color.Navy
        Me.ubOK.ForeColor = System.Drawing.Color.White
        Me.ubOK.Location = New System.Drawing.Point(328, 376)
        Me.ubOK.Name = "ubOK"
        Me.ubOK.Size = New System.Drawing.Size(72, 24)
        Me.ubOK.TabIndex = 3
        Me.ubOK.Text = "OK"
        Me.ubOK.UseVisualStyleBackColor = False
        '
        'ubCancel
        '
        Me.ubCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ubCancel.BackColor = System.Drawing.Color.Navy
        Me.ubCancel.ForeColor = System.Drawing.Color.White
        Me.ubCancel.Location = New System.Drawing.Point(240, 376)
        Me.ubCancel.Name = "ubCancel"
        Me.ubCancel.Size = New System.Drawing.Size(72, 24)
        Me.ubCancel.TabIndex = 4
        Me.ubCancel.Text = "Cancel"
        Me.ubCancel.UseVisualStyleBackColor = False
        '
        'cbAlwaysRemove
        '
        Me.cbAlwaysRemove.Location = New System.Drawing.Point(8, 16)
        Me.cbAlwaysRemove.Name = "cbAlwaysRemove"
        Me.cbAlwaysRemove.Size = New System.Drawing.Size(168, 24)
        Me.cbAlwaysRemove.TabIndex = 5
        Me.cbAlwaysRemove.Text = "Always remove non-letters"
        '
        'cbVerbose
        '
        Me.cbVerbose.Checked = True
        Me.cbVerbose.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbVerbose.Location = New System.Drawing.Point(8, 40)
        Me.cbVerbose.Name = "cbVerbose"
        Me.cbVerbose.Size = New System.Drawing.Size(168, 32)
        Me.cbVerbose.TabIndex = 7
        Me.cbVerbose.Text = "Show all keys, legends and charts when decoding"
        '
        'cbAlwaysSub
        '
        Me.cbAlwaysSub.Location = New System.Drawing.Point(8, 16)
        Me.cbAlwaysSub.Name = "cbAlwaysSub"
        Me.cbAlwaysSub.Size = New System.Drawing.Size(168, 24)
        Me.cbAlwaysSub.TabIndex = 6
        Me.cbAlwaysSub.Text = "Always run substitution first"
        '
        'cbCryptanalysis
        '
        Me.cbCryptanalysis.Checked = True
        Me.cbCryptanalysis.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbCryptanalysis.Location = New System.Drawing.Point(8, 72)
        Me.cbCryptanalysis.Name = "cbCryptanalysis"
        Me.cbCryptanalysis.Size = New System.Drawing.Size(168, 24)
        Me.cbCryptanalysis.TabIndex = 8
        Me.cbCryptanalysis.Text = "Show cryptanalysis tools"
        '
        'gbDisplay
        '
        Me.gbDisplay.Controls.Add(Me.cbAlwaysSub)
        Me.gbDisplay.Controls.Add(Me.cbVerbose)
        Me.gbDisplay.Controls.Add(Me.cbCryptanalysis)
        Me.gbDisplay.Controls.Add(Me.Label3)
        Me.gbDisplay.Controls.Add(Me.numSpacing)
        Me.gbDisplay.Location = New System.Drawing.Point(16, 16)
        Me.gbDisplay.Name = "gbDisplay"
        Me.gbDisplay.Size = New System.Drawing.Size(184, 136)
        Me.gbDisplay.TabIndex = 13
        Me.gbDisplay.TabStop = False
        Me.gbDisplay.Text = "Display"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 16)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Ciphertext Spacing:"
        '
        'numSpacing
        '
        Me.numSpacing.Location = New System.Drawing.Point(112, 104)
        Me.numSpacing.Name = "numSpacing"
        Me.numSpacing.Size = New System.Drawing.Size(56, 20)
        Me.numSpacing.TabIndex = 19
        '
        'gbRoutes
        '
        Me.gbRoutes.Controls.Add(Me.Label8)
        Me.gbRoutes.Controls.Add(Me.Label7)
        Me.gbRoutes.Controls.Add(Me.Label6)
        Me.gbRoutes.Controls.Add(Me.Vertical)
        Me.gbRoutes.Controls.Add(Me.Label5)
        Me.gbRoutes.Controls.Add(Me.cbInverse)
        Me.gbRoutes.Controls.Add(Me.cbSwirl)
        Me.gbRoutes.Controls.Add(Me.Label4)
        Me.gbRoutes.Controls.Add(Me.cbRaster)
        Me.gbRoutes.Controls.Add(Me.cbZigzag)
        Me.gbRoutes.Controls.Add(Me.cbDiagonal)
        Me.gbRoutes.Controls.Add(Me.cbSpiral)
        Me.gbRoutes.Controls.Add(Me.cbArch)
        Me.gbRoutes.Controls.Add(Me.cbAlwaysRoute)
        Me.gbRoutes.Controls.Add(Me.cbKnight)
        Me.gbRoutes.Controls.Add(Me.Panel1)
        Me.gbRoutes.Controls.Add(Me.Panel2)
        Me.gbRoutes.Controls.Add(Me.Panel3)
        Me.gbRoutes.Controls.Add(Me.Panel4)
        Me.gbRoutes.Location = New System.Drawing.Point(216, 16)
        Me.gbRoutes.Name = "gbRoutes"
        Me.gbRoutes.Size = New System.Drawing.Size(184, 272)
        Me.gbRoutes.TabIndex = 14
        Me.gbRoutes.TabStop = False
        Me.gbRoutes.Text = "Routes"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(8, 248)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 16)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Pair Swap"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(8, 224)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 16)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Checkered"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(8, 200)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 16)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Reversed"
        '
        'Vertical
        '
        Me.Vertical.Location = New System.Drawing.Point(8, 176)
        Me.Vertical.Name = "Vertical"
        Me.Vertical.Size = New System.Drawing.Size(56, 16)
        Me.Vertical.TabIndex = 23
        Me.Vertical.Text = "Vertical"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(76, 152)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 16)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Yes   No   Random"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cbInverse
        '
        Me.cbInverse.Location = New System.Drawing.Point(8, 128)
        Me.cbInverse.Name = "cbInverse"
        Me.cbInverse.Size = New System.Drawing.Size(72, 24)
        Me.cbInverse.TabIndex = 21
        Me.cbInverse.Text = "Inverse"
        '
        'cbSwirl
        '
        Me.cbSwirl.Location = New System.Drawing.Point(96, 104)
        Me.cbSwirl.Name = "cbSwirl"
        Me.cbSwirl.Size = New System.Drawing.Size(72, 24)
        Me.cbSwirl.TabIndex = 20
        Me.cbSwirl.Text = "Swirl"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(152, 16)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Route Customization"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cbRaster
        '
        Me.cbRaster.Checked = True
        Me.cbRaster.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbRaster.Location = New System.Drawing.Point(8, 56)
        Me.cbRaster.Name = "cbRaster"
        Me.cbRaster.Size = New System.Drawing.Size(72, 24)
        Me.cbRaster.TabIndex = 18
        Me.cbRaster.Text = "Raster"
        '
        'cbZigzag
        '
        Me.cbZigzag.Location = New System.Drawing.Point(96, 56)
        Me.cbZigzag.Name = "cbZigzag"
        Me.cbZigzag.Size = New System.Drawing.Size(64, 24)
        Me.cbZigzag.TabIndex = 17
        Me.cbZigzag.Text = "Zigzag"
        '
        'cbDiagonal
        '
        Me.cbDiagonal.Location = New System.Drawing.Point(8, 80)
        Me.cbDiagonal.Name = "cbDiagonal"
        Me.cbDiagonal.Size = New System.Drawing.Size(72, 24)
        Me.cbDiagonal.TabIndex = 16
        Me.cbDiagonal.Text = "Diagonal"
        '
        'cbSpiral
        '
        Me.cbSpiral.Location = New System.Drawing.Point(96, 80)
        Me.cbSpiral.Name = "cbSpiral"
        Me.cbSpiral.Size = New System.Drawing.Size(64, 24)
        Me.cbSpiral.TabIndex = 15
        Me.cbSpiral.Text = "Spiral"
        '
        'cbArch
        '
        Me.cbArch.Location = New System.Drawing.Point(8, 104)
        Me.cbArch.Name = "cbArch"
        Me.cbArch.Size = New System.Drawing.Size(72, 24)
        Me.cbArch.TabIndex = 14
        Me.cbArch.Text = "Archway"
        '
        'cbAlwaysRoute
        '
        Me.cbAlwaysRoute.Checked = True
        Me.cbAlwaysRoute.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbAlwaysRoute.Location = New System.Drawing.Point(8, 16)
        Me.cbAlwaysRoute.Name = "cbAlwaysRoute"
        Me.cbAlwaysRoute.Size = New System.Drawing.Size(168, 24)
        Me.cbAlwaysRoute.TabIndex = 13
        Me.cbAlwaysRoute.Text = "Always run routes on grids"
        '
        'cbKnight
        '
        Me.cbKnight.Location = New System.Drawing.Point(96, 128)
        Me.cbKnight.Name = "cbKnight"
        Me.cbKnight.Size = New System.Drawing.Size(84, 24)
        Me.cbKnight.TabIndex = 22
        Me.cbKnight.Text = "Knight Tour"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.rbVMaybe)
        Me.Panel1.Controls.Add(Me.rbVNo)
        Me.Panel1.Controls.Add(Me.rbVYes)
        Me.Panel1.Location = New System.Drawing.Point(80, 168)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(96, 24)
        Me.Panel1.TabIndex = 19
        '
        'rbVMaybe
        '
        Me.rbVMaybe.Checked = True
        Me.rbVMaybe.Location = New System.Drawing.Point(72, 6)
        Me.rbVMaybe.Name = "rbVMaybe"
        Me.rbVMaybe.Size = New System.Drawing.Size(16, 16)
        Me.rbVMaybe.TabIndex = 31
        Me.rbVMaybe.TabStop = True
        '
        'rbVNo
        '
        Me.rbVNo.Location = New System.Drawing.Point(40, 6)
        Me.rbVNo.Name = "rbVNo"
        Me.rbVNo.Size = New System.Drawing.Size(16, 16)
        Me.rbVNo.TabIndex = 29
        '
        'rbVYes
        '
        Me.rbVYes.Location = New System.Drawing.Point(8, 6)
        Me.rbVYes.Name = "rbVYes"
        Me.rbVYes.Size = New System.Drawing.Size(16, 16)
        Me.rbVYes.TabIndex = 27
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.rbRMaybe)
        Me.Panel2.Controls.Add(Me.rbRNo)
        Me.Panel2.Controls.Add(Me.rbRYes)
        Me.Panel2.Location = New System.Drawing.Point(80, 192)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(96, 24)
        Me.Panel2.TabIndex = 20
        '
        'rbRMaybe
        '
        Me.rbRMaybe.Checked = True
        Me.rbRMaybe.Location = New System.Drawing.Point(72, 6)
        Me.rbRMaybe.Name = "rbRMaybe"
        Me.rbRMaybe.Size = New System.Drawing.Size(16, 16)
        Me.rbRMaybe.TabIndex = 31
        Me.rbRMaybe.TabStop = True
        '
        'rbRNo
        '
        Me.rbRNo.Location = New System.Drawing.Point(40, 6)
        Me.rbRNo.Name = "rbRNo"
        Me.rbRNo.Size = New System.Drawing.Size(16, 16)
        Me.rbRNo.TabIndex = 29
        '
        'rbRYes
        '
        Me.rbRYes.Location = New System.Drawing.Point(8, 6)
        Me.rbRYes.Name = "rbRYes"
        Me.rbRYes.Size = New System.Drawing.Size(16, 16)
        Me.rbRYes.TabIndex = 27
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.rbCMaybe)
        Me.Panel3.Controls.Add(Me.rbCNo)
        Me.Panel3.Controls.Add(Me.rbCYes)
        Me.Panel3.Location = New System.Drawing.Point(80, 216)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(96, 24)
        Me.Panel3.TabIndex = 20
        '
        'rbCMaybe
        '
        Me.rbCMaybe.Location = New System.Drawing.Point(72, 6)
        Me.rbCMaybe.Name = "rbCMaybe"
        Me.rbCMaybe.Size = New System.Drawing.Size(16, 16)
        Me.rbCMaybe.TabIndex = 31
        '
        'rbCNo
        '
        Me.rbCNo.Checked = True
        Me.rbCNo.Location = New System.Drawing.Point(40, 6)
        Me.rbCNo.Name = "rbCNo"
        Me.rbCNo.Size = New System.Drawing.Size(16, 16)
        Me.rbCNo.TabIndex = 29
        Me.rbCNo.TabStop = True
        '
        'rbCYes
        '
        Me.rbCYes.Location = New System.Drawing.Point(8, 6)
        Me.rbCYes.Name = "rbCYes"
        Me.rbCYes.Size = New System.Drawing.Size(16, 16)
        Me.rbCYes.TabIndex = 27
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.rbPMaybe)
        Me.Panel4.Controls.Add(Me.rbPNo)
        Me.Panel4.Controls.Add(Me.rbPYes)
        Me.Panel4.Location = New System.Drawing.Point(80, 240)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(96, 24)
        Me.Panel4.TabIndex = 20
        '
        'rbPMaybe
        '
        Me.rbPMaybe.Location = New System.Drawing.Point(72, 6)
        Me.rbPMaybe.Name = "rbPMaybe"
        Me.rbPMaybe.Size = New System.Drawing.Size(16, 16)
        Me.rbPMaybe.TabIndex = 31
        '
        'rbPNo
        '
        Me.rbPNo.Checked = True
        Me.rbPNo.Location = New System.Drawing.Point(40, 6)
        Me.rbPNo.Name = "rbPNo"
        Me.rbPNo.Size = New System.Drawing.Size(16, 16)
        Me.rbPNo.TabIndex = 29
        Me.rbPNo.TabStop = True
        '
        'rbPYes
        '
        Me.rbPYes.Location = New System.Drawing.Point(8, 6)
        Me.rbPYes.Name = "rbPYes"
        Me.rbPYes.Size = New System.Drawing.Size(16, 16)
        Me.rbPYes.TabIndex = 27
        '
        'gbAlphabets
        '
        Me.gbAlphabets.Controls.Add(Me.rbX)
        Me.gbAlphabets.Controls.Add(Me.rbJ)
        Me.gbAlphabets.Controls.Add(Me.rbQ)
        Me.gbAlphabets.Controls.Add(Me.Label1)
        Me.gbAlphabets.Controls.Add(Me.rbZ)
        Me.gbAlphabets.Location = New System.Drawing.Point(16, 328)
        Me.gbAlphabets.Name = "gbAlphabets"
        Me.gbAlphabets.Size = New System.Drawing.Size(184, 72)
        Me.gbAlphabets.TabIndex = 15
        Me.gbAlphabets.TabStop = False
        Me.gbAlphabets.Text = "Alphabets"
        '
        'rbX
        '
        Me.rbX.Location = New System.Drawing.Point(96, 48)
        Me.rbX.Name = "rbX"
        Me.rbX.Size = New System.Drawing.Size(32, 16)
        Me.rbX.TabIndex = 13
        Me.rbX.Text = "X"
        '
        'rbJ
        '
        Me.rbJ.Checked = True
        Me.rbJ.Location = New System.Drawing.Point(16, 48)
        Me.rbJ.Name = "rbJ"
        Me.rbJ.Size = New System.Drawing.Size(32, 16)
        Me.rbJ.TabIndex = 10
        Me.rbJ.TabStop = True
        Me.rbJ.Text = "J"
        '
        'rbQ
        '
        Me.rbQ.Location = New System.Drawing.Point(56, 48)
        Me.rbQ.Name = "rbQ"
        Me.rbQ.Size = New System.Drawing.Size(32, 16)
        Me.rbQ.TabIndex = 11
        Me.rbQ.Text = "Q"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 24)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Character to drop for 25 letter alphabets"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'rbZ
        '
        Me.rbZ.Location = New System.Drawing.Point(136, 48)
        Me.rbZ.Name = "rbZ"
        Me.rbZ.Size = New System.Drawing.Size(32, 16)
        Me.rbZ.TabIndex = 12
        Me.rbZ.Text = "Z"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(152, 16)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Punctuation Type"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'rbSymbols
        '
        Me.rbSymbols.Checked = True
        Me.rbSymbols.Location = New System.Drawing.Point(16, 96)
        Me.rbSymbols.Name = "rbSymbols"
        Me.rbSymbols.Size = New System.Drawing.Size(72, 16)
        Me.rbSymbols.TabIndex = 15
        Me.rbSymbols.TabStop = True
        Me.rbSymbols.Text = "Symbols"
        '
        'rbShort
        '
        Me.rbShort.Location = New System.Drawing.Point(104, 96)
        Me.rbShort.Name = "rbShort"
        Me.rbShort.Size = New System.Drawing.Size(56, 16)
        Me.rbShort.TabIndex = 16
        Me.rbShort.Text = "Short"
        '
        'rbLong
        '
        Me.rbLong.Location = New System.Drawing.Point(104, 120)
        Me.rbLong.Name = "rbLong"
        Me.rbLong.Size = New System.Drawing.Size(56, 16)
        Me.rbLong.TabIndex = 17
        Me.rbLong.Text = "Long"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.rbShort)
        Me.GroupBox1.Controls.Add(Me.rbSymbols)
        Me.GroupBox1.Controls.Add(Me.rbLong)
        Me.GroupBox1.Controls.Add(Me.cbAlwaysConvertNumbers)
        Me.GroupBox1.Controls.Add(Me.cbAlwaysRemove)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 168)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(184, 144)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Abbreviations"
        '
        'cbAlwaysConvertNumbers
        '
        Me.cbAlwaysConvertNumbers.Location = New System.Drawing.Point(8, 40)
        Me.cbAlwaysConvertNumbers.Name = "cbAlwaysConvertNumbers"
        Me.cbAlwaysConvertNumbers.Size = New System.Drawing.Size(168, 24)
        Me.cbAlwaysConvertNumbers.TabIndex = 19
        Me.cbAlwaysConvertNumbers.Text = "Always spell out numbers"
        '
        'Options
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(416, 414)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbAlphabets)
        Me.Controls.Add(Me.gbRoutes)
        Me.Controls.Add(Me.gbDisplay)
        Me.Controls.Add(Me.ubCancel)
        Me.Controls.Add(Me.ubOK)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Options"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Options"
        Me.gbDisplay.ResumeLayout(False)
        CType(Me.numSpacing, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbRoutes.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.gbAlphabets.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region " New "
    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        cbAlwaysRemove.Checked = AlwaysRemove
        cbAlwaysSub.Checked = AlwaysSub
        cbAlwaysConvertNumbers.Checked = AlwaysConvertNumbers
        cbVerbose.Checked = Verbose
        cbCryptanalysis.Checked = ShowCryptanalysis
        If (LetterToRemove = "j"c) Then
            rbJ.Checked = True
        ElseIf (LetterToRemove = "q"c) Then
            rbQ.Checked = True
        ElseIf (LetterToRemove = "x"c) Then
            rbX.Checked = True
        ElseIf (LetterToRemove = "z"c) Then
            rbZ.Checked = True
        End If
        If (PunctuationType = LeavePunct) Then
            rbSymbols.Checked = True
        ElseIf (PunctuationType = ShortPunct) Then
            rbShort.Checked = True
        ElseIf (PunctuationType = LongPunct) Then
            rbLong.Checked = True
        End If
        numSpacing.Value = SpacingDistance

        'Routes
        cbAlwaysRoute.Checked = AlwaysRoute
        cbRaster.Checked = PathRaster
        cbZigzag.Checked = PathZigzag
        cbDiagonal.Checked = PathDiagonal
        cbSpiral.Checked = PathSpiral
        cbSwirl.Checked = PathSwirl
        cbInverse.Checked = PathInverse
        cbArch.Checked = PathArch
        cbKnight.Checked = PathKnight
        If (PathVertical = YES) Then
            rbVYes.Checked = True
        ElseIf (PathVertical = NO) Then
            rbVNo.Checked = True
        Else
            rbVMaybe.Checked = True
        End If
        If (PathReverse = YES) Then
            rbRYes.Checked = True
        ElseIf (PathReverse = NO) Then
            rbRNo.Checked = True
        Else
            rbRMaybe.Checked = True
        End If
        If (PathCheckerboard = YES) Then
            rbCYes.Checked = True
        ElseIf (PathCheckerboard = NO) Then
            rbCNo.Checked = True
        Else
            rbCMaybe.Checked = True
        End If
        If (PathSwapPairs = YES) Then
            rbPYes.Checked = True
        ElseIf (PathSwapPairs = NO) Then
            rbPNo.Checked = True
        Else
            rbPMaybe.Checked = True
        End If
    End Sub
#End Region

    Private Sub ubOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubOK.Click
        AlwaysRemove = cbAlwaysRemove.Checked
        AlwaysSub = cbAlwaysSub.Checked
        AlwaysConvertNumbers = cbAlwaysConvertNumbers.Checked
        Verbose = cbVerbose.Checked
        ShowCryptanalysis = cbCryptanalysis.Checked
        If (rbJ.Checked) Then
            LetterToRemove = "j"c
        ElseIf (rbQ.Checked) Then
            LetterToRemove = "q"c
        ElseIf (rbX.Checked) Then
            LetterToRemove = "x"c
        ElseIf (rbZ.Checked) Then
            LetterToRemove = "z"c
        End If

        If (rbSymbols.Checked) Then
            PunctuationType = LeavePunct
        ElseIf (rbShort.Checked) Then
            PunctuationType = ShortPunct
        ElseIf (rbLong.Checked) Then
            PunctuationType = LongPunct
        End If
        SpacingDistance = numSpacing.Value

        'Routes
        AlwaysRoute = cbAlwaysRoute.Checked
        PathRaster = cbRaster.Checked
        PathZigzag = cbZigzag.Checked
        PathDiagonal = cbDiagonal.Checked
        PathSpiral = cbSpiral.Checked
        PathSwirl = cbSwirl.Checked
        PathInverse = cbInverse.Checked
        PathArch = cbArch.Checked
        PathKnight = cbKnight.Checked
        If (rbVYes.Checked) Then
            PathVertical = YES
        ElseIf (rbVNo.Checked) Then
            PathVertical = NO
        Else
            PathVertical = MAYBE
        End If
        If (rbRYes.Checked) Then
            PathReverse = YES
        ElseIf (rbRNo.Checked) Then
            PathReverse = NO
        Else
            PathReverse = MAYBE
        End If
        If (rbCYes.Checked) Then
            PathCheckerboard = YES
        ElseIf (rbCNo.Checked) Then
            PathCheckerboard = NO
        Else
            PathCheckerboard = MAYBE
        End If
        If (rbPYes.Checked) Then
            PathSwapPairs = YES
        ElseIf (rbPNo.Checked) Then
            PathSwapPairs = NO
        Else
            PathSwapPairs = MAYBE
        End If

        SaveOptions()
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub ubCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubCancel.Click

    End Sub
End Class
