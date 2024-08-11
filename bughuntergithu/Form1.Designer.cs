namespace bughuntergithu
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            domain = new TextBox();
            title = new Label();
            label1 = new Label();
            panel1 = new Panel();
            button1 = new Button();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            words = new ListBox();
            label2 = new Label();
            label3 = new Label();
            extension = new ListBox();
            label4 = new Label();
            filename = new ListBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // domain
            // 
            domain.Location = new Point(504, 81);
            domain.Multiline = true;
            domain.Name = "domain";
            domain.Size = new Size(348, 30);
            domain.TabIndex = 0;
            // 
            // title
            // 
            title.AutoSize = true;
            title.BackColor = Color.DarkGreen;
            title.Font = new Font("Snap ITC", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            title.ForeColor = Color.Red;
            title.Location = new Point(471, 9);
            title.Name = "title";
            title.Size = new Size(381, 63);
            title.TabIndex = 3;
            title.Text = "GitHub Dork";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(372, 82);
            label1.Name = "label1";
            label1.Size = new Size(126, 29);
            label1.TabIndex = 4;
            label1.Text = "domain :";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkRed;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.ForeColor = Color.DarkRed;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(297, 538);
            panel1.TabIndex = 6;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(73, 482);
            button1.Name = "button1";
            button1.Size = new Size(100, 25);
            button1.TabIndex = 9;
            button1.Text = "my linkedin";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Magneto", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.ActiveCaptionText;
            label11.Location = new Point(12, 421);
            label11.Name = "label11";
            label11.Size = new Size(235, 58);
            label11.TabIndex = 8;
            label11.Text = "a0ibx00";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Constantia", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Red;
            label10.Location = new Point(3, 395);
            label10.Name = "label10";
            label10.Size = new Size(51, 26);
            label10.TabIndex = 7;
            label10.Text = "by : ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Constantia", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Red;
            label9.Location = new Point(3, 244);
            label9.Name = "label9";
            label9.Size = new Size(85, 26);
            label9.TabIndex = 6;
            label9.Text = "Using : ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label8.ForeColor = SystemColors.ActiveCaptionText;
            label8.Location = new Point(3, 270);
            label8.Name = "label8";
            label8.Size = new Size(269, 40);
            label8.TabIndex = 5;
            label8.Text = "1. write the domain.\r\n2. click on any word to go in browser.";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Constantia", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(0, 9);
            label7.Name = "label7";
            label7.Size = new Size(271, 26);
            label7.TabIndex = 4;
            label7.Text = "GitHub Dork Search Tool :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Red;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(3, 321);
            label6.Name = "label6";
            label6.Size = new Size(258, 40);
            label6.TabIndex = 3;
            label6.Text = "Note:  Make sure you use the same \r\nbrowser that has the GitHub token.";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(3, 35);
            label5.Name = "label5";
            label5.Size = new Size(296, 200);
            label5.TabIndex = 2;
            label5.Text = resources.GetString("label5.Text");
            // 
            // words
            // 
            words.BackColor = Color.Wheat;
            words.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            words.FormattingEnabled = true;
            words.ItemHeight = 17;
            words.Items.AddRange(new object[] { "\"password\"", "\"access_key\"", "\"access_token\"", "\"amazonaws\"", "\"api.googlemaps AIza\"", "\"api_key\"", "\"api_secret\"", "\"apidocs\"", "\"apikey\"", "\"apiSecret\"", "\"app_key\"", "\"app_secret\"", "\"appkey\"", "\"appkeysecret\"", "\"application_key\"", "\"appsecret\"", "\"appspot\"", "\"auth\"", "\"auth_token\"", "\"authorizationToken\"", "\"aws_access\"", "\"aws_access_key_id\"", "\"aws_key\"", "\"aws_secret\"", "\"aws_token\"", "\"AWSSecretKey\"", "\"bashrc password\"", "\"bucket_password\"", "\"client_secret\"", "\"cloudfront\"", "\"codecov_token\"", "\"config\"", "\"conn.login\"", "\"connectionstring\"", "\"consumer_key\"", "\"credentials\"", "\"database_password\"", "\"db_password\"", "\"db_username\"", "\"dbpasswd\"", "\"dbpassword\"", "\"dbuser\"", "\"dot-files\"", "\"dotfiles\"", "\"encryption_key\"", "\"fabricApiSecret\"", "\"fb_secret\"", "\"firebase\"", "\"ftp\"", "\"gh_token\"", "\"github_key\"", "\"github_token\"", "\"gitlab\"", "\"gmail_password\"", "\"gmail_username\"", "\"herokuapp\"", "\"internal\"", "\"irc_pass\"", "\"JEKYLL_GITHUB_TOKEN\"", "\"key\"", "\"keyPassword\"", "\"ldap_password\"", "\"ldap_username\"", "\"login\"", "\"mailchimp\"", "\"mailgun\"", "\"master_key\"", "\"mydotfiles\"", "\"mysql\"", "\"node_env\"", "\"npmrc _auth\"", "\"oauth_token\"", "\"pass\"", "\"passwd\"", "\"password\"", "\"passwords\"", "\"pem private\"", "\"preprod\"", "\"private_key\"", "\"prod\"", "\"pwd\"", "\"pwds\"", "\"rds.amazonaws.com password\"", "\"redis_password\"", "\"root_password\"", "\"secret\"", "\"secret.password\"", "\"secret_access_key\"", "\"secret_key\"", "\"secret_token\"", "\"secrets\"", "\"secure\"", "\"security_credentials\"", "\"send.keys\"", "\"send_keys\"", "\"sendkeys\"", "\"SF_USERNAME salesforce\"", "\"sf_username\"", "\"site.com\" FIREBASE_API_JSON=", "\"site.com\" vim_settings.xml", "\"slack_api\"", "\"slack_token\"", "\"sql_password\"", "\"ssh\"", "\"ssh2_auth_password\"", "\"sshpass\"", "\"staging\"", "\"stg\"", "\"storePassword\"", "\"stripe\"", "\"swagger\"", "\"testuser\"", "\"token\"", "\"x-api-key\"", "\"xoxb \"", "\"xoxp\"", "remove password", "root", "admin", "log", "trash", "token", "FTP_PORT", "FTP_PASSWORD", "DB_DATABASE=", "DB_HOST=", "DB_PORT=", "DB_PASSWORD=", "DB_PW=", "DB_USER=" });
            words.Location = new Point(303, 165);
            words.Name = "words";
            words.Size = new Size(207, 361);
            words.TabIndex = 7;
            words.SelectedIndexChanged += words_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Snap ITC", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(303, 129);
            label2.Name = "label2";
            label2.Size = new Size(181, 27);
            label2.TabIndex = 8;
            label2.Text = "select word :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Snap ITC", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(524, 129);
            label3.Name = "label3";
            label3.Size = new Size(244, 27);
            label3.TabIndex = 10;
            label3.Text = "select extension :";
            // 
            // extension
            // 
            extension.BackColor = Color.Wheat;
            extension.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            extension.FormattingEnabled = true;
            extension.ItemHeight = 17;
            extension.Items.AddRange(new object[] { "extension:avastlic ", "extension:bat", "extension:cfg", "extension:env", "extension:exs", "extension:ini", "extension:json ", "extension:pem", "extension:pem private", "extension:ppk", "extension:ppk private", "extension:properties", "extension:sh", "extension:sls", "extension:sql", "extension:sql mysql dump", "extension:sql mysql dump password", "extension:yaml " });
            extension.Location = new Point(531, 166);
            extension.Name = "extension";
            extension.Size = new Size(237, 361);
            extension.TabIndex = 9;
            extension.SelectedIndexChanged += extension_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Snap ITC", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(831, 129);
            label4.Name = "label4";
            label4.Size = new Size(139, 27);
            label4.TabIndex = 12;
            label4.Text = "filename :";
            // 
            // filename
            // 
            filename.BackColor = Color.Wheat;
            filename.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            filename.FormattingEnabled = true;
            filename.ItemHeight = 17;
            filename.Items.AddRange(new object[] { "filename:.bash_history", "filename:.bash_history ", "filename:.bash_profile ", "filename:.bashrc", "filename:.bashrc", "filename:.cshrc", "filename:.dockercfg ", "filename:.env ", "filename:.esmtprc_password", "filename:.ftpconfig", "filename:.git-credentials", "filename:.history", "filename:.htpasswd", "filename:.netrc_password", "filename:.npmrc_auth", "filename:.pgpass", "filename:.remote-sync.json", "filename:.s3cfg", "filename:.sh_history", "filename:.tugboat", "filename:_netrc_password", "filename:apikey", "filename:bash", "filename:bash_history", "filename:bash_profile", "filename:bashrc", "filename:beanstalkd.yml", "filename:CCCam.cfg", "filename:composer.json", "filename:config", "filename:config_irc_pass", "filename:config.json ", "filename:config.php ", "filename:configuration.php ", "filename:connections", "filename:connections.xml", "filename:constants", "filename:credentials", "filename:aws_access_key_id", "filename:cshrc", "filename:database", "filename:dbeaver-data-sources.xml", "filename:deployment-config.json", "filename:dhcpd.conf", "filename:dockercfg", "filename:environment", "filename:express.conf", "filename:express.conf path:.openshift", "filename:filezilla.xml", "filename:filezilla.xml_Pass", "filename:git-credentials", "filename:gitconfig", "filename:global", "filename:history", "filename:htpasswd", "filename:hub_oauth_token", "filename:id_dsa", "filename:id_rsa", "filename:id_dsa", "filename:idea14.key", "filename:known_hosts", "filename:logins.json", "filename:makefile", "filename:master.key ", "filename:netrc", "filename:npmrc", "filename:pass", "filename:passwd ", "filename:pgpass", "filename:prod.exs", "filename:prod.exs ", "filename:prod.secret.exs", "filename:proftpdpasswd", "filename:recentservers.xml", "filename:recentservers.xml Pass", "filename:robomongo.json", "filename:s3cfg", "filename:secrets.yml ", "filename:server.cfg", "filename:server.cfg ", "filename:settings", "filename:settings.py ", "filename:sftp-config.json", "filename:sftp.json ", "filename:shadow", "filename:shadow ", "filename:spec", "filename:sshd_config", "filename:token", "filename:tugboat", "filename:ventrilo_srv.ini", "filename:WebServers.xml", "filename:wp-config", "filename:wp-config.php", "filename:zhrc" });
            filename.Location = new Point(774, 166);
            filename.Name = "filename";
            filename.Size = new Size(310, 361);
            filename.TabIndex = 11;
            filename.SelectedIndexChanged += filename_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1096, 530);
            Controls.Add(label4);
            Controls.Add(filename);
            Controls.Add(label3);
            Controls.Add(extension);
            Controls.Add(label2);
            Controls.Add(words);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(title);
            Controls.Add(domain);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox domain;
        private Label title;
        private Label label1;
        private Panel panel1;
        private ListBox words;
        private Label label2;
        private Label label3;
        private ListBox extension;
        private Label label4;
        private ListBox filename;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label9;
        private Label label8;
        private Label label11;
        private Label label10;
        private Button button1;
    }
}
