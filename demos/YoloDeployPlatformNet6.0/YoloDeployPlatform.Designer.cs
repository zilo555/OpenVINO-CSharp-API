namespace YoloDeployPlatform
{
    partial class YoloDeployPlatform
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            gb_model = new GroupBox();
            rb_yolov8_obb = new RadioButton();
            rb_yolov8_cls = new RadioButton();
            rb_yolov8_pose = new RadioButton();
            rb_yolov8_seg = new RadioButton();
            rb_yolo_world = new RadioButton();
            rb_yolov_seg = new RadioButton();
            rb_yolov9_det = new RadioButton();
            rb_yolov10_det = new RadioButton();
            rb_yolov8_det = new RadioButton();
            rb_yolov7_det = new RadioButton();
            rb_yolov5_cls = new RadioButton();
            rb_yolov6_det = new RadioButton();
            rb_yolov5_seg = new RadioButton();
            rb_yolov5_det = new RadioButton();
            btn_input_select = new Button();
            label4 = new Label();
            tb_input_path = new TextBox();
            cb_device = new ComboBox();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            panel3 = new Panel();
            btn_model_select = new Button();
            label2 = new Label();
            tb_model_path = new TextBox();
            panel2 = new Panel();
            tb_msg_image = new TextBox();
            label6 = new Label();
            btn_load_model = new Button();
            tc_operate = new TabControl();
            tabPage1 = new TabPage();
            btn_image_infer = new Button();
            tabPage2 = new TabPage();
            pb_video = new ProgressBar();
            btn_stop = new Button();
            btn_start = new Button();
            btn_video_infer = new Button();
            label7 = new Label();
            tb_msg_video = new TextBox();
            panel4 = new Panel();
            label8 = new Label();
            label9 = new Label();
            tb_score = new TextBox();
            tb_nms = new TextBox();
            groupBox1 = new GroupBox();
            label11 = new Label();
            tb_categ_num = new TextBox();
            tb_input_size = new TextBox();
            label10 = new Label();
            chb_time = new CheckBox();
            chb_fps = new CheckBox();
            panel5 = new Panel();
            gb_model.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            tc_operate.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(326, 9);
            label1.Name = "label1";
            label1.Size = new Size(1022, 45);
            label1.TabIndex = 1;
            label1.Text = "OpenVINO C# API Deploy YOLO Model Testing Platform";
            // 
            // gb_model
            // 
            gb_model.Controls.Add(rb_yolov8_obb);
            gb_model.Controls.Add(rb_yolov8_cls);
            gb_model.Controls.Add(rb_yolov8_pose);
            gb_model.Controls.Add(rb_yolov8_seg);
            gb_model.Controls.Add(rb_yolo_world);
            gb_model.Controls.Add(rb_yolov_seg);
            gb_model.Controls.Add(rb_yolov9_det);
            gb_model.Controls.Add(rb_yolov10_det);
            gb_model.Controls.Add(rb_yolov8_det);
            gb_model.Controls.Add(rb_yolov7_det);
            gb_model.Controls.Add(rb_yolov5_cls);
            gb_model.Controls.Add(rb_yolov6_det);
            gb_model.Controls.Add(rb_yolov5_seg);
            gb_model.Controls.Add(rb_yolov5_det);
            gb_model.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            gb_model.Location = new Point(26, 127);
            gb_model.Margin = new Padding(3, 4, 3, 4);
            gb_model.Name = "gb_model";
            gb_model.Padding = new Padding(3, 4, 3, 4);
            gb_model.Size = new Size(678, 187);
            gb_model.TabIndex = 4;
            gb_model.TabStop = false;
            gb_model.Text = "Model";
            // 
            // rb_yolov8_obb
            // 
            rb_yolov8_obb.AutoSize = true;
            rb_yolov8_obb.Location = new Point(364, 38);
            rb_yolov8_obb.Margin = new Padding(3, 4, 3, 4);
            rb_yolov8_obb.Name = "rb_yolov8_obb";
            rb_yolov8_obb.Size = new Size(145, 27);
            rb_yolov8_obb.TabIndex = 3;
            rb_yolov8_obb.Text = "YOLOv8Obb";
            rb_yolov8_obb.UseVisualStyleBackColor = true;
            // 
            // rb_yolov8_cls
            // 
            rb_yolov8_cls.AutoSize = true;
            rb_yolov8_cls.Location = new Point(365, 75);
            rb_yolov8_cls.Margin = new Padding(3, 4, 3, 4);
            rb_yolov8_cls.Name = "rb_yolov8_cls";
            rb_yolov8_cls.Size = new Size(136, 27);
            rb_yolov8_cls.TabIndex = 3;
            rb_yolov8_cls.Text = "YOLOv8Cls";
            rb_yolov8_cls.UseVisualStyleBackColor = true;
            // 
            // rb_yolov8_pose
            // 
            rb_yolov8_pose.AutoSize = true;
            rb_yolov8_pose.Location = new Point(192, 151);
            rb_yolov8_pose.Margin = new Padding(3, 4, 3, 4);
            rb_yolov8_pose.Name = "rb_yolov8_pose";
            rb_yolov8_pose.Size = new Size(149, 27);
            rb_yolov8_pose.TabIndex = 3;
            rb_yolov8_pose.Text = "YOLOv8Pose";
            rb_yolov8_pose.UseVisualStyleBackColor = true;
            // 
            // rb_yolov8_seg
            // 
            rb_yolov8_seg.AutoSize = true;
            rb_yolov8_seg.Location = new Point(192, 113);
            rb_yolov8_seg.Margin = new Padding(3, 4, 3, 4);
            rb_yolov8_seg.Name = "rb_yolov8_seg";
            rb_yolov8_seg.Size = new Size(140, 27);
            rb_yolov8_seg.TabIndex = 3;
            rb_yolov8_seg.Text = "YOLOv8Seg";
            rb_yolov8_seg.UseVisualStyleBackColor = true;
            // 
            // rb_yolo_world
            // 
            rb_yolo_world.AutoSize = true;
            rb_yolo_world.Location = new Point(523, 38);
            rb_yolo_world.Margin = new Padding(3, 4, 3, 4);
            rb_yolo_world.Name = "rb_yolo_world";
            rb_yolo_world.Size = new Size(140, 27);
            rb_yolo_world.TabIndex = 3;
            rb_yolo_world.Text = "YOLOWorld";
            rb_yolo_world.UseVisualStyleBackColor = true;
            // 
            // rb_yolov_seg
            // 
            rb_yolov_seg.AutoSize = true;
            rb_yolov_seg.Location = new Point(368, 151);
            rb_yolov_seg.Margin = new Padding(3, 4, 3, 4);
            rb_yolov_seg.Name = "rb_yolov_seg";
            rb_yolov_seg.Size = new Size(140, 27);
            rb_yolov_seg.TabIndex = 3;
            rb_yolov_seg.Text = "YOLOv9Seg";
            rb_yolov_seg.UseVisualStyleBackColor = true;
            // 
            // rb_yolov9_det
            // 
            rb_yolov9_det.AutoSize = true;
            rb_yolov9_det.Location = new Point(368, 113);
            rb_yolov9_det.Margin = new Padding(3, 4, 3, 4);
            rb_yolov9_det.Name = "rb_yolov9_det";
            rb_yolov9_det.Size = new Size(140, 27);
            rb_yolov9_det.TabIndex = 3;
            rb_yolov9_det.Text = "YOLOv9Det";
            rb_yolov9_det.UseVisualStyleBackColor = true;
            // 
            // rb_yolov10_det
            // 
            rb_yolov10_det.AutoSize = true;
            rb_yolov10_det.Location = new Point(523, 72);
            rb_yolov10_det.Margin = new Padding(3, 4, 3, 4);
            rb_yolov10_det.Name = "rb_yolov10_det";
            rb_yolov10_det.Size = new Size(150, 27);
            rb_yolov10_det.TabIndex = 3;
            rb_yolov10_det.Text = "YOLOv10Det";
            rb_yolov10_det.UseVisualStyleBackColor = true;
            // 
            // rb_yolov8_det
            // 
            rb_yolov8_det.AutoSize = true;
            rb_yolov8_det.Location = new Point(189, 75);
            rb_yolov8_det.Margin = new Padding(3, 4, 3, 4);
            rb_yolov8_det.Name = "rb_yolov8_det";
            rb_yolov8_det.Size = new Size(140, 27);
            rb_yolov8_det.TabIndex = 3;
            rb_yolov8_det.Text = "YOLOv8Det";
            rb_yolov8_det.UseVisualStyleBackColor = true;
            // 
            // rb_yolov7_det
            // 
            rb_yolov7_det.AutoSize = true;
            rb_yolov7_det.Location = new Point(189, 38);
            rb_yolov7_det.Margin = new Padding(3, 4, 3, 4);
            rb_yolov7_det.Name = "rb_yolov7_det";
            rb_yolov7_det.Size = new Size(140, 27);
            rb_yolov7_det.TabIndex = 3;
            rb_yolov7_det.Text = "YOLOv7Det";
            rb_yolov7_det.UseVisualStyleBackColor = true;
            // 
            // rb_yolov5_cls
            // 
            rb_yolov5_cls.AutoSize = true;
            rb_yolov5_cls.Location = new Point(23, 113);
            rb_yolov5_cls.Margin = new Padding(3, 4, 3, 4);
            rb_yolov5_cls.Name = "rb_yolov5_cls";
            rb_yolov5_cls.Size = new Size(136, 27);
            rb_yolov5_cls.TabIndex = 2;
            rb_yolov5_cls.Text = "YOLOv5Cls";
            rb_yolov5_cls.UseVisualStyleBackColor = true;
            // 
            // rb_yolov6_det
            // 
            rb_yolov6_det.AutoSize = true;
            rb_yolov6_det.Location = new Point(23, 151);
            rb_yolov6_det.Margin = new Padding(3, 4, 3, 4);
            rb_yolov6_det.Name = "rb_yolov6_det";
            rb_yolov6_det.Size = new Size(140, 27);
            rb_yolov6_det.TabIndex = 2;
            rb_yolov6_det.Text = "YOLOv6Det";
            rb_yolov6_det.UseVisualStyleBackColor = true;
            // 
            // rb_yolov5_seg
            // 
            rb_yolov5_seg.AutoSize = true;
            rb_yolov5_seg.Location = new Point(21, 75);
            rb_yolov5_seg.Margin = new Padding(3, 4, 3, 4);
            rb_yolov5_seg.Name = "rb_yolov5_seg";
            rb_yolov5_seg.Size = new Size(140, 27);
            rb_yolov5_seg.TabIndex = 1;
            rb_yolov5_seg.Text = "YOLOv5Seg";
            rb_yolov5_seg.UseVisualStyleBackColor = true;
            // 
            // rb_yolov5_det
            // 
            rb_yolov5_det.AutoSize = true;
            rb_yolov5_det.Checked = true;
            rb_yolov5_det.Location = new Point(19, 38);
            rb_yolov5_det.Margin = new Padding(3, 4, 3, 4);
            rb_yolov5_det.Name = "rb_yolov5_det";
            rb_yolov5_det.Size = new Size(140, 27);
            rb_yolov5_det.TabIndex = 0;
            rb_yolov5_det.TabStop = true;
            rb_yolov5_det.Text = "YOLOv5Det";
            rb_yolov5_det.UseVisualStyleBackColor = true;
            // 
            // btn_input_select
            // 
            btn_input_select.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_input_select.Location = new Point(631, 355);
            btn_input_select.Margin = new Padding(3, 4, 3, 4);
            btn_input_select.Name = "btn_input_select";
            btn_input_select.Size = new Size(113, 32);
            btn_input_select.TabIndex = 0;
            btn_input_select.Text = "Select";
            btn_input_select.UseVisualStyleBackColor = true;
            btn_input_select.Click += btn_input_select_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(26, 360);
            label4.Name = "label4";
            label4.Size = new Size(105, 23);
            label4.TabIndex = 2;
            label4.Text = "Input Path:";
            // 
            // tb_input_path
            // 
            tb_input_path.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tb_input_path.Location = new Point(161, 356);
            tb_input_path.Margin = new Padding(3, 4, 3, 4);
            tb_input_path.Name = "tb_input_path";
            tb_input_path.Size = new Size(455, 30);
            tb_input_path.TabIndex = 3;
            // 
            // cb_device
            // 
            cb_device.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cb_device.FormattingEnabled = true;
            cb_device.Items.AddRange(new object[] { "CPU", "GPU" });
            cb_device.Location = new Point(123, 601);
            cb_device.Margin = new Padding(3, 4, 3, 4);
            cb_device.Name = "cb_device";
            cb_device.Size = new Size(196, 30);
            cb_device.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(36, 604);
            label5.Name = "label5";
            label5.Size = new Size(75, 23);
            label5.TabIndex = 2;
            label5.Text = "Device:";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveBorder;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(783, 118);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(900, 500);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ActiveBorder;
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(783, 701);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(900, 500);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(761, 64);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(5, 1819);
            panel1.TabIndex = 6;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlDark;
            panel3.Location = new Point(3, 562);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(1324, 5);
            panel3.TabIndex = 6;
            // 
            // btn_model_select
            // 
            btn_model_select.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_model_select.Location = new Point(622, 87);
            btn_model_select.Margin = new Padding(3, 4, 3, 4);
            btn_model_select.Name = "btn_model_select";
            btn_model_select.Size = new Size(113, 35);
            btn_model_select.TabIndex = 0;
            btn_model_select.Text = "Select";
            btn_model_select.UseVisualStyleBackColor = true;
            btn_model_select.Click += btn_model_select_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(26, 93);
            label2.Name = "label2";
            label2.Size = new Size(114, 23);
            label2.TabIndex = 2;
            label2.Text = "Model Path:";
            // 
            // tb_model_path
            // 
            tb_model_path.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tb_model_path.Location = new Point(161, 88);
            tb_model_path.Margin = new Padding(3, 4, 3, 4);
            tb_model_path.Name = "tb_model_path";
            tb_model_path.Size = new Size(455, 30);
            tb_model_path.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlDark;
            panel2.Location = new Point(-15, 60);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(2155, 5);
            panel2.TabIndex = 6;
            // 
            // tb_msg_image
            // 
            tb_msg_image.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tb_msg_image.Location = new Point(19, 194);
            tb_msg_image.Margin = new Padding(3, 4, 3, 4);
            tb_msg_image.Multiline = true;
            tb_msg_image.Name = "tb_msg_image";
            tb_msg_image.ScrollBars = ScrollBars.Both;
            tb_msg_image.Size = new Size(708, 331);
            tb_msg_image.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(258, 138);
            label6.Name = "label6";
            label6.Size = new Size(272, 31);
            label6.TabIndex = 1;
            label6.Text = "Inference Information";
            // 
            // btn_load_model
            // 
            btn_load_model.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_load_model.Location = new Point(455, 585);
            btn_load_model.Margin = new Padding(3, 4, 3, 4);
            btn_load_model.Name = "btn_load_model";
            btn_load_model.Size = new Size(231, 58);
            btn_load_model.TabIndex = 0;
            btn_load_model.Text = "Load Model";
            btn_load_model.UseVisualStyleBackColor = true;
            btn_load_model.Click += btn_load_model_Click;
            // 
            // tc_operate
            // 
            tc_operate.Controls.Add(tabPage1);
            tc_operate.Controls.Add(tabPage2);
            tc_operate.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            tc_operate.Location = new Point(4, 678);
            tc_operate.Margin = new Padding(5);
            tc_operate.Name = "tc_operate";
            tc_operate.SelectedIndex = 0;
            tc_operate.Size = new Size(753, 585);
            tc_operate.TabIndex = 8;
            tc_operate.SelectedIndexChanged += tc_operate_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(tb_msg_image);
            tabPage1.Controls.Add(btn_image_infer);
            tabPage1.Location = new Point(4, 35);
            tabPage1.Margin = new Padding(5);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(5);
            tabPage1.Size = new Size(745, 546);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "  Image  ";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_image_infer
            // 
            btn_image_infer.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_image_infer.Location = new Point(300, 36);
            btn_image_infer.Margin = new Padding(3, 4, 3, 4);
            btn_image_infer.Name = "btn_image_infer";
            btn_image_infer.Size = new Size(171, 73);
            btn_image_infer.TabIndex = 0;
            btn_image_infer.Text = "Infer";
            btn_image_infer.UseVisualStyleBackColor = true;
            btn_image_infer.Click += btn_image_infer_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(pb_video);
            tabPage2.Controls.Add(btn_stop);
            tabPage2.Controls.Add(btn_start);
            tabPage2.Controls.Add(btn_video_infer);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(tb_msg_video);
            tabPage2.Location = new Point(4, 35);
            tabPage2.Margin = new Padding(5);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(5);
            tabPage2.Size = new Size(745, 546);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "  Video  ";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // pb_video
            // 
            pb_video.Location = new Point(59, 515);
            pb_video.Margin = new Padding(5);
            pb_video.Name = "pb_video";
            pb_video.Size = new Size(692, 39);
            pb_video.Step = 1;
            pb_video.Style = ProgressBarStyle.Continuous;
            pb_video.TabIndex = 12;
            pb_video.Value = 1;
            // 
            // btn_stop
            // 
            btn_stop.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_stop.Location = new Point(474, 39);
            btn_stop.Margin = new Padding(3, 4, 3, 4);
            btn_stop.Name = "btn_stop";
            btn_stop.Size = new Size(171, 49);
            btn_stop.TabIndex = 11;
            btn_stop.Text = "Stop";
            btn_stop.UseVisualStyleBackColor = true;
            btn_stop.Click += btn_stop_Click;
            // 
            // btn_start
            // 
            btn_start.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_start.Location = new Point(246, 39);
            btn_start.Margin = new Padding(3, 4, 3, 4);
            btn_start.Name = "btn_start";
            btn_start.Size = new Size(171, 49);
            btn_start.TabIndex = 11;
            btn_start.Text = "Start";
            btn_start.UseVisualStyleBackColor = true;
            btn_start.Click += btn_start_Click;
            // 
            // btn_video_infer
            // 
            btn_video_infer.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_video_infer.Location = new Point(36, 39);
            btn_video_infer.Margin = new Padding(3, 4, 3, 4);
            btn_video_infer.Name = "btn_video_infer";
            btn_video_infer.Size = new Size(171, 49);
            btn_video_infer.TabIndex = 11;
            btn_video_infer.Text = "Infer";
            btn_video_infer.UseVisualStyleBackColor = true;
            btn_video_infer.Click += btn_video_infer_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(258, 108);
            label7.Name = "label7";
            label7.Size = new Size(272, 31);
            label7.TabIndex = 9;
            label7.Text = "Inference Information";
            // 
            // tb_msg_video
            // 
            tb_msg_video.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tb_msg_video.Location = new Point(21, 140);
            tb_msg_video.Margin = new Padding(3, 4, 3, 4);
            tb_msg_video.Multiline = true;
            tb_msg_video.Name = "tb_msg_video";
            tb_msg_video.ScrollBars = ScrollBars.Both;
            tb_msg_video.Size = new Size(768, 365);
            tb_msg_video.TabIndex = 9;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ControlDark;
            panel4.Location = new Point(-3, 664);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(769, 5);
            panel4.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(3, 41);
            label8.Name = "label8";
            label8.Size = new Size(147, 22);
            label8.TabIndex = 2;
            label8.Text = "Score Threshold:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(1, 95);
            label9.Name = "label9";
            label9.Size = new Size(143, 22);
            label9.TabIndex = 2;
            label9.Text = "NMS Threshold:";
            // 
            // tb_score
            // 
            tb_score.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tb_score.Location = new Point(158, 36);
            tb_score.Margin = new Padding(3, 4, 3, 4);
            tb_score.Name = "tb_score";
            tb_score.Size = new Size(106, 30);
            tb_score.TabIndex = 3;
            tb_score.Text = "0.6";
            tb_score.TextAlign = HorizontalAlignment.Center;
            // 
            // tb_nms
            // 
            tb_nms.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tb_nms.Location = new Point(158, 91);
            tb_nms.Margin = new Padding(3, 4, 3, 4);
            tb_nms.Name = "tb_nms";
            tb_nms.Size = new Size(106, 30);
            tb_nms.TabIndex = 3;
            tb_nms.Text = "0.5";
            tb_nms.TextAlign = HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(tb_score);
            groupBox1.Controls.Add(tb_categ_num);
            groupBox1.Controls.Add(tb_nms);
            groupBox1.Controls.Add(tb_input_size);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label10);
            groupBox1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(26, 438);
            groupBox1.Margin = new Padding(5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5);
            groupBox1.Size = new Size(528, 133);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Inference Params";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(300, 93);
            label11.Name = "label11";
            label11.Size = new Size(94, 22);
            label11.TabIndex = 2;
            label11.Text = "Input Size:";
            // 
            // tb_categ_num
            // 
            tb_categ_num.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tb_categ_num.Location = new Point(403, 36);
            tb_categ_num.Margin = new Padding(3, 4, 3, 4);
            tb_categ_num.Name = "tb_categ_num";
            tb_categ_num.Size = new Size(106, 30);
            tb_categ_num.TabIndex = 3;
            tb_categ_num.Text = "80";
            tb_categ_num.TextAlign = HorizontalAlignment.Center;
            // 
            // tb_input_size
            // 
            tb_input_size.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tb_input_size.Location = new Point(400, 88);
            tb_input_size.Margin = new Padding(3, 4, 3, 4);
            tb_input_size.Name = "tb_input_size";
            tb_input_size.Size = new Size(106, 30);
            tb_input_size.TabIndex = 3;
            tb_input_size.Text = "640";
            tb_input_size.TextAlign = HorizontalAlignment.Center;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(291, 41);
            label10.Name = "label10";
            label10.Size = new Size(103, 22);
            label10.TabIndex = 2;
            label10.Text = "Categ Num:";
            // 
            // chb_time
            // 
            chb_time.AutoSize = true;
            chb_time.Checked = true;
            chb_time.CheckState = CheckState.Checked;
            chb_time.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            chb_time.Location = new Point(564, 474);
            chb_time.Margin = new Padding(5);
            chb_time.Name = "chb_time";
            chb_time.Size = new Size(171, 24);
            chb_time.TabIndex = 10;
            chb_time.Text = "Time Detection";
            chb_time.UseVisualStyleBackColor = true;
            chb_time.CheckedChanged += chb_time_CheckedChanged;
            // 
            // chb_fps
            // 
            chb_fps.AutoSize = true;
            chb_fps.Checked = true;
            chb_fps.CheckState = CheckState.Checked;
            chb_fps.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            chb_fps.Location = new Point(564, 536);
            chb_fps.Margin = new Padding(5);
            chb_fps.Name = "chb_fps";
            chb_fps.Size = new Size(111, 24);
            chb_fps.TabIndex = 10;
            chb_fps.Text = "FPS Draw";
            chb_fps.UseVisualStyleBackColor = true;
            chb_fps.CheckedChanged += chb_fps_CheckedChanged;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ControlDark;
            panel5.Location = new Point(764, 664);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(935, 5);
            panel5.TabIndex = 6;
            // 
            // YoloDeployPlatform
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1698, 1253);
            Controls.Add(chb_fps);
            Controls.Add(chb_time);
            Controls.Add(groupBox1);
            Controls.Add(tc_operate);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(cb_device);
            Controls.Add(gb_model);
            Controls.Add(tb_input_path);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(tb_model_path);
            Controls.Add(btn_load_model);
            Controls.Add(btn_input_select);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_model_select);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "YoloDeployPlatform";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "YoloDeployPlatform";
            Load += Form1_Load;
            gb_model.ResumeLayout(false);
            gb_model.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            tc_operate.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gb_model;
        private System.Windows.Forms.RadioButton rb_yolov7_det;
        private System.Windows.Forms.RadioButton rb_yolov6_det;
        private System.Windows.Forms.RadioButton rb_yolov5_seg;
        private System.Windows.Forms.RadioButton rb_yolov5_det;
        private System.Windows.Forms.RadioButton rb_yolov8_cls;
        private System.Windows.Forms.RadioButton rb_yolov8_pose;
        private System.Windows.Forms.RadioButton rb_yolov8_seg;
        private System.Windows.Forms.RadioButton rb_yolov8_det;
        private System.Windows.Forms.RadioButton rb_yolov8_obb;
        private System.Windows.Forms.RadioButton rb_yolov_seg;
        private System.Windows.Forms.RadioButton rb_yolov9_det;
        private System.Windows.Forms.ComboBox cb_device;
        private System.Windows.Forms.Button btn_input_select;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_input_path;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_model_select;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_model_path;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tb_msg_image;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_load_model;
        private System.Windows.Forms.RadioButton rb_yolo_world;
        private System.Windows.Forms.TabControl tc_operate;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_msg_video;
        private System.Windows.Forms.Button btn_image_infer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_score;
        private System.Windows.Forms.TextBox tb_nms;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_categ_num;
        private System.Windows.Forms.TextBox tb_input_size;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox chb_time;
        private System.Windows.Forms.CheckBox chb_fps;
        private System.Windows.Forms.RadioButton rb_yolov5_cls;
        private System.Windows.Forms.Button btn_video_infer;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.ProgressBar pb_video;
        private RadioButton rb_yolov10_det;
        private Panel panel5;
    }
}
