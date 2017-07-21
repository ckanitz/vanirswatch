/*
 * Created by SharpDevelop.
 * User: Sacer
 * Date: 12.07.2017
 * Time: 14:41
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Vanirs_Watch
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btn_close;
		private System.Windows.Forms.Button btn_minimize;
		private System.Windows.Forms.Label programName;
		private System.Windows.Forms.Label lbl_charname;
		private System.Windows.Forms.Label lbl_class;
		private System.Windows.Forms.Label static_hp;
		private System.Windows.Forms.Label static_sp;
		private System.Windows.Forms.Label static_baselv;
		private System.Windows.Forms.Label static_joblv;
		private System.Windows.Forms.Label lbl_hp_current;
		private System.Windows.Forms.Label lbl_sp_current;
		private System.Windows.Forms.Label lbl_bexp_current;
		private System.Windows.Forms.Label lbl_jexp_current;
		private System.Windows.Forms.Label static_zeny;
		private System.Windows.Forms.Label lbl_bexp_hour;
		private System.Windows.Forms.Label lbl_jexp_hour;
		private System.Windows.Forms.Label lbl_zeny_current;
		private System.Windows.Forms.Label lbl_weight_current;
		private System.Windows.Forms.Button btn_start;
		private System.Windows.Forms.Button btn_reset;
		private System.Windows.Forms.Label static_weight;
		private System.Windows.Forms.Panel hp_bar;
		private System.Windows.Forms.Panel sp_bar;
		private System.Windows.Forms.Panel base_bar;
		private System.Windows.Forms.Panel job_bar;
		private System.Windows.Forms.Label lbl_blvl;
		private System.Windows.Forms.Label lbl_jlvl;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.btn_close = new System.Windows.Forms.Button();
			this.btn_minimize = new System.Windows.Forms.Button();
			this.programName = new System.Windows.Forms.Label();
			this.lbl_charname = new System.Windows.Forms.Label();
			this.lbl_class = new System.Windows.Forms.Label();
			this.static_hp = new System.Windows.Forms.Label();
			this.static_sp = new System.Windows.Forms.Label();
			this.static_baselv = new System.Windows.Forms.Label();
			this.static_joblv = new System.Windows.Forms.Label();
			this.lbl_hp_current = new System.Windows.Forms.Label();
			this.lbl_sp_current = new System.Windows.Forms.Label();
			this.lbl_bexp_current = new System.Windows.Forms.Label();
			this.lbl_jexp_current = new System.Windows.Forms.Label();
			this.static_zeny = new System.Windows.Forms.Label();
			this.lbl_bexp_hour = new System.Windows.Forms.Label();
			this.lbl_jexp_hour = new System.Windows.Forms.Label();
			this.lbl_zeny_current = new System.Windows.Forms.Label();
			this.lbl_weight_current = new System.Windows.Forms.Label();
			this.btn_start = new System.Windows.Forms.Button();
			this.btn_reset = new System.Windows.Forms.Button();
			this.static_weight = new System.Windows.Forms.Label();
			this.hp_bar = new System.Windows.Forms.Panel();
			this.sp_bar = new System.Windows.Forms.Panel();
			this.base_bar = new System.Windows.Forms.Panel();
			this.job_bar = new System.Windows.Forms.Panel();
			this.lbl_blvl = new System.Windows.Forms.Label();
			this.lbl_jlvl = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btn_close
			// 
			this.btn_close.BackColor = System.Drawing.Color.Transparent;
			this.btn_close.FlatAppearance.BorderSize = 0;
			this.btn_close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.btn_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_close.Image = global::Vanirs_Watch.assets.images.btn_close;
			this.btn_close.Location = new System.Drawing.Point(264, 3);
			this.btn_close.Margin = new System.Windows.Forms.Padding(0);
			this.btn_close.MaximumSize = new System.Drawing.Size(10, 10);
			this.btn_close.MinimumSize = new System.Drawing.Size(9, 9);
			this.btn_close.Name = "btn_close";
			this.btn_close.Size = new System.Drawing.Size(10, 10);
			this.btn_close.TabIndex = 0;
			this.btn_close.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
			this.btn_close.UseVisualStyleBackColor = false;
			this.btn_close.Click += new System.EventHandler(this.Btn_closeClick);
			// 
			// btn_minimize
			// 
			this.btn_minimize.BackColor = System.Drawing.Color.Transparent;
			this.btn_minimize.FlatAppearance.BorderSize = 0;
			this.btn_minimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.btn_minimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.btn_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_minimize.Image = global::Vanirs_Watch.assets.images.btn_minimize;
			this.btn_minimize.Location = new System.Drawing.Point(250, 3);
			this.btn_minimize.Margin = new System.Windows.Forms.Padding(0);
			this.btn_minimize.MaximumSize = new System.Drawing.Size(10, 10);
			this.btn_minimize.MinimumSize = new System.Drawing.Size(9, 9);
			this.btn_minimize.Name = "btn_minimize";
			this.btn_minimize.Size = new System.Drawing.Size(10, 10);
			this.btn_minimize.TabIndex = 1;
			this.btn_minimize.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
			this.btn_minimize.UseVisualStyleBackColor = false;
			this.btn_minimize.Click += new System.EventHandler(this.Btn_minimizeClick);
			// 
			// programName
			// 
			this.programName.BackColor = System.Drawing.Color.Transparent;
			this.programName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.programName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.programName.Location = new System.Drawing.Point(7, 1);
			this.programName.Name = "programName";
			this.programName.Size = new System.Drawing.Size(198, 12);
			this.programName.TabIndex = 9999;
			this.programName.Text = "Vanirs Watch v1.0.2 BETA";
			// 
			// lbl_charname
			// 
			this.lbl_charname.BackColor = System.Drawing.Color.Transparent;
			this.lbl_charname.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.lbl_charname.ForeColor = System.Drawing.Color.Black;
			this.lbl_charname.Location = new System.Drawing.Point(10, 27);
			this.lbl_charname.Name = "lbl_charname";
			this.lbl_charname.Size = new System.Drawing.Size(264, 18);
			this.lbl_charname.TabIndex = 10000;
			this.lbl_charname.Text = "Character";
			// 
			// lbl_class
			// 
			this.lbl_class.BackColor = System.Drawing.Color.Transparent;
			this.lbl_class.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.lbl_class.ForeColor = System.Drawing.Color.Black;
			this.lbl_class.Location = new System.Drawing.Point(10, 42);
			this.lbl_class.Name = "lbl_class";
			this.lbl_class.Size = new System.Drawing.Size(264, 18);
			this.lbl_class.TabIndex = 10001;
			this.lbl_class.Text = "ClassName";
			// 
			// static_hp
			// 
			this.static_hp.BackColor = System.Drawing.Color.Transparent;
			this.static_hp.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.static_hp.ForeColor = System.Drawing.Color.Black;
			this.static_hp.Location = new System.Drawing.Point(10, 68);
			this.static_hp.Name = "static_hp";
			this.static_hp.Size = new System.Drawing.Size(26, 18);
			this.static_hp.TabIndex = 10002;
			this.static_hp.Text = "HP";
			// 
			// static_sp
			// 
			this.static_sp.BackColor = System.Drawing.Color.Transparent;
			this.static_sp.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.static_sp.ForeColor = System.Drawing.Color.Black;
			this.static_sp.Location = new System.Drawing.Point(10, 83);
			this.static_sp.Name = "static_sp";
			this.static_sp.Size = new System.Drawing.Size(24, 18);
			this.static_sp.TabIndex = 10003;
			this.static_sp.Text = "SP";
			// 
			// static_baselv
			// 
			this.static_baselv.BackColor = System.Drawing.Color.Transparent;
			this.static_baselv.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.static_baselv.ForeColor = System.Drawing.Color.Black;
			this.static_baselv.Location = new System.Drawing.Point(20, 102);
			this.static_baselv.Name = "static_baselv";
			this.static_baselv.Size = new System.Drawing.Size(54, 18);
			this.static_baselv.TabIndex = 10004;
			this.static_baselv.Text = "Base Lv";
			// 
			// static_joblv
			// 
			this.static_joblv.BackColor = System.Drawing.Color.Transparent;
			this.static_joblv.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.static_joblv.ForeColor = System.Drawing.Color.Black;
			this.static_joblv.Location = new System.Drawing.Point(20, 131);
			this.static_joblv.Name = "static_joblv";
			this.static_joblv.Size = new System.Drawing.Size(54, 18);
			this.static_joblv.TabIndex = 10005;
			this.static_joblv.Text = "Job Lv";
			// 
			// lbl_hp_current
			// 
			this.lbl_hp_current.BackColor = System.Drawing.Color.Transparent;
			this.lbl_hp_current.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.lbl_hp_current.ForeColor = System.Drawing.Color.Black;
			this.lbl_hp_current.Location = new System.Drawing.Point(162, 68);
			this.lbl_hp_current.Name = "lbl_hp_current";
			this.lbl_hp_current.Size = new System.Drawing.Size(122, 18);
			this.lbl_hp_current.TabIndex = 10006;
			this.lbl_hp_current.Text = "000% 00000/00000";
			// 
			// lbl_sp_current
			// 
			this.lbl_sp_current.BackColor = System.Drawing.Color.Transparent;
			this.lbl_sp_current.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.lbl_sp_current.ForeColor = System.Drawing.Color.Black;
			this.lbl_sp_current.Location = new System.Drawing.Point(162, 83);
			this.lbl_sp_current.Name = "lbl_sp_current";
			this.lbl_sp_current.Size = new System.Drawing.Size(122, 18);
			this.lbl_sp_current.TabIndex = 10007;
			this.lbl_sp_current.Text = "000% 00000/00000";
			// 
			// lbl_bexp_current
			// 
			this.lbl_bexp_current.BackColor = System.Drawing.Color.Transparent;
			this.lbl_bexp_current.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.lbl_bexp_current.ForeColor = System.Drawing.Color.Black;
			this.lbl_bexp_current.Location = new System.Drawing.Point(199, 102);
			this.lbl_bexp_current.Name = "lbl_bexp_current";
			this.lbl_bexp_current.Size = new System.Drawing.Size(55, 18);
			this.lbl_bexp_current.TabIndex = 10008;
			this.lbl_bexp_current.Text = "000.0%";
			// 
			// lbl_jexp_current
			// 
			this.lbl_jexp_current.BackColor = System.Drawing.Color.Transparent;
			this.lbl_jexp_current.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.lbl_jexp_current.ForeColor = System.Drawing.Color.Black;
			this.lbl_jexp_current.Location = new System.Drawing.Point(199, 131);
			this.lbl_jexp_current.Name = "lbl_jexp_current";
			this.lbl_jexp_current.Size = new System.Drawing.Size(55, 18);
			this.lbl_jexp_current.TabIndex = 10009;
			this.lbl_jexp_current.Text = "000.0%";
			// 
			// static_zeny
			// 
			this.static_zeny.BackColor = System.Drawing.Color.Transparent;
			this.static_zeny.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.static_zeny.ForeColor = System.Drawing.Color.Black;
			this.static_zeny.Location = new System.Drawing.Point(10, 165);
			this.static_zeny.Name = "static_zeny";
			this.static_zeny.Size = new System.Drawing.Size(33, 18);
			this.static_zeny.TabIndex = 10010;
			this.static_zeny.Text = "Zeny:";
			// 
			// lbl_bexp_hour
			// 
			this.lbl_bexp_hour.BackColor = System.Drawing.Color.Transparent;
			this.lbl_bexp_hour.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.lbl_bexp_hour.ForeColor = System.Drawing.Color.Black;
			this.lbl_bexp_hour.Location = new System.Drawing.Point(94, 116);
			this.lbl_bexp_hour.Name = "lbl_bexp_hour";
			this.lbl_bexp_hour.Size = new System.Drawing.Size(174, 18);
			this.lbl_bexp_hour.TabIndex = 10012;
			this.lbl_bexp_hour.Text = "000.000.000 EXP/h";
			// 
			// lbl_jexp_hour
			// 
			this.lbl_jexp_hour.BackColor = System.Drawing.Color.Transparent;
			this.lbl_jexp_hour.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.lbl_jexp_hour.ForeColor = System.Drawing.Color.Black;
			this.lbl_jexp_hour.Location = new System.Drawing.Point(94, 144);
			this.lbl_jexp_hour.Name = "lbl_jexp_hour";
			this.lbl_jexp_hour.Size = new System.Drawing.Size(174, 19);
			this.lbl_jexp_hour.TabIndex = 10013;
			this.lbl_jexp_hour.Text = "000.000.000 EXP/h";
			// 
			// lbl_zeny_current
			// 
			this.lbl_zeny_current.BackColor = System.Drawing.Color.Transparent;
			this.lbl_zeny_current.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.lbl_zeny_current.ForeColor = System.Drawing.Color.Black;
			this.lbl_zeny_current.Location = new System.Drawing.Point(42, 165);
			this.lbl_zeny_current.Name = "lbl_zeny_current";
			this.lbl_zeny_current.Size = new System.Drawing.Size(120, 18);
			this.lbl_zeny_current.TabIndex = 10014;
			this.lbl_zeny_current.Text = "000.000.000";
			// 
			// lbl_weight_current
			// 
			this.lbl_weight_current.BackColor = System.Drawing.Color.Transparent;
			this.lbl_weight_current.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.lbl_weight_current.ForeColor = System.Drawing.Color.Black;
			this.lbl_weight_current.Location = new System.Drawing.Point(51, 181);
			this.lbl_weight_current.Name = "lbl_weight_current";
			this.lbl_weight_current.Size = new System.Drawing.Size(120, 18);
			this.lbl_weight_current.TabIndex = 10015;
			this.lbl_weight_current.Text = "000.000.000";
			// 
			// btn_start
			// 
			this.btn_start.BackColor = System.Drawing.Color.Transparent;
			this.btn_start.BackgroundImage = global::Vanirs_Watch.assets.images.btn_blank;
			this.btn_start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btn_start.FlatAppearance.BorderSize = 0;
			this.btn_start.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.btn_start.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.btn_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_start.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.btn_start.ForeColor = System.Drawing.Color.Black;
			this.btn_start.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btn_start.Location = new System.Drawing.Point(165, 170);
			this.btn_start.Margin = new System.Windows.Forms.Padding(0);
			this.btn_start.Name = "btn_start";
			this.btn_start.Size = new System.Drawing.Size(54, 21);
			this.btn_start.TabIndex = 10016;
			this.btn_start.Text = "START";
			this.btn_start.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btn_start.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
			this.btn_start.UseVisualStyleBackColor = false;
			this.btn_start.Click += new System.EventHandler(this.Btn_startClick);
			// 
			// btn_reset
			// 
			this.btn_reset.BackColor = System.Drawing.Color.Transparent;
			this.btn_reset.BackgroundImage = global::Vanirs_Watch.assets.images.btn_blank;
			this.btn_reset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btn_reset.FlatAppearance.BorderSize = 0;
			this.btn_reset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.btn_reset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_reset.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.btn_reset.ForeColor = System.Drawing.Color.Black;
			this.btn_reset.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btn_reset.Location = new System.Drawing.Point(227, 170);
			this.btn_reset.Margin = new System.Windows.Forms.Padding(0);
			this.btn_reset.Name = "btn_reset";
			this.btn_reset.Size = new System.Drawing.Size(44, 21);
			this.btn_reset.TabIndex = 10017;
			this.btn_reset.Text = "RESET";
			this.btn_reset.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btn_reset.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
			this.btn_reset.UseVisualStyleBackColor = false;
			this.btn_reset.Click += new System.EventHandler(this.btn_resetClick);
			// 
			// static_weight
			// 
			this.static_weight.BackColor = System.Drawing.Color.Transparent;
			this.static_weight.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.static_weight.ForeColor = System.Drawing.Color.Black;
			this.static_weight.Location = new System.Drawing.Point(10, 181);
			this.static_weight.Name = "static_weight";
			this.static_weight.Size = new System.Drawing.Size(42, 18);
			this.static_weight.TabIndex = 10018;
			this.static_weight.Text = "Weight:";
			// 
			// hp_bar
			// 
			this.hp_bar.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.hp_bar.Location = new System.Drawing.Point(60, 72);
			this.hp_bar.Margin = new System.Windows.Forms.Padding(0);
			this.hp_bar.Name = "hp_bar";
			this.hp_bar.Size = new System.Drawing.Size(100, 5);
			this.hp_bar.TabIndex = 10019;
			// 
			// sp_bar
			// 
			this.sp_bar.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.sp_bar.Location = new System.Drawing.Point(60, 87);
			this.sp_bar.Margin = new System.Windows.Forms.Padding(0);
			this.sp_bar.Name = "sp_bar";
			this.sp_bar.Size = new System.Drawing.Size(100, 5);
			this.sp_bar.TabIndex = 10020;
			// 
			// base_bar
			// 
			this.base_bar.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.base_bar.Location = new System.Drawing.Point(96, 107);
			this.base_bar.Margin = new System.Windows.Forms.Padding(0);
			this.base_bar.Name = "base_bar";
			this.base_bar.Size = new System.Drawing.Size(100, 5);
			this.base_bar.TabIndex = 10021;
			// 
			// job_bar
			// 
			this.job_bar.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.job_bar.Location = new System.Drawing.Point(96, 136);
			this.job_bar.Margin = new System.Windows.Forms.Padding(0);
			this.job_bar.Name = "job_bar";
			this.job_bar.Size = new System.Drawing.Size(100, 5);
			this.job_bar.TabIndex = 10022;
			// 
			// lbl_blvl
			// 
			this.lbl_blvl.BackColor = System.Drawing.Color.Transparent;
			this.lbl_blvl.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.lbl_blvl.ForeColor = System.Drawing.Color.Black;
			this.lbl_blvl.Location = new System.Drawing.Point(69, 102);
			this.lbl_blvl.Name = "lbl_blvl";
			this.lbl_blvl.Size = new System.Drawing.Size(24, 18);
			this.lbl_blvl.TabIndex = 10023;
			this.lbl_blvl.Text = "00";
			// 
			// lbl_jlvl
			// 
			this.lbl_jlvl.BackColor = System.Drawing.Color.Transparent;
			this.lbl_jlvl.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.lbl_jlvl.ForeColor = System.Drawing.Color.Black;
			this.lbl_jlvl.Location = new System.Drawing.Point(69, 131);
			this.lbl_jlvl.Name = "lbl_jlvl";
			this.lbl_jlvl.Size = new System.Drawing.Size(24, 18);
			this.lbl_jlvl.TabIndex = 10024;
			this.lbl_jlvl.Text = "00";
			// 
			// MainForm
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackgroundImage = global::Vanirs_Watch.assets.images.window;
			this.ClientSize = new System.Drawing.Size(280, 203);
			this.ControlBox = false;
			this.Controls.Add(this.lbl_jlvl);
			this.Controls.Add(this.lbl_blvl);
			this.Controls.Add(this.job_bar);
			this.Controls.Add(this.base_bar);
			this.Controls.Add(this.sp_bar);
			this.Controls.Add(this.hp_bar);
			this.Controls.Add(this.static_weight);
			this.Controls.Add(this.btn_reset);
			this.Controls.Add(this.btn_start);
			this.Controls.Add(this.lbl_weight_current);
			this.Controls.Add(this.lbl_zeny_current);
			this.Controls.Add(this.lbl_jexp_hour);
			this.Controls.Add(this.lbl_bexp_hour);
			this.Controls.Add(this.static_zeny);
			this.Controls.Add(this.lbl_jexp_current);
			this.Controls.Add(this.lbl_bexp_current);
			this.Controls.Add(this.lbl_sp_current);
			this.Controls.Add(this.lbl_hp_current);
			this.Controls.Add(this.static_joblv);
			this.Controls.Add(this.static_baselv);
			this.Controls.Add(this.static_sp);
			this.Controls.Add(this.static_hp);
			this.Controls.Add(this.lbl_class);
			this.Controls.Add(this.lbl_charname);
			this.Controls.Add(this.programName);
			this.Controls.Add(this.btn_minimize);
			this.Controls.Add(this.btn_close);
			this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.Color.Transparent;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = global::Vanirs_Watch.assets.images.icon;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.Text = "Vanirs Watch";
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainFormMouseDown);
			this.ResumeLayout(false);

		}
	}
}
