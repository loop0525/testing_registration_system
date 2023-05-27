namespace Admin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            //初始化关闭主窗口功能
            treeView1.Enabled= false;
            

        }
        public bool loginState = false;
        SearchForm searchForm;
        LoginForm loginForm;
        SignForm signForm;
        UserForm userForm;
        CkeckRegForm ckeckRegForm;
        public void FormSwitch(int i)
        {
            switch(i)
            {
                case 0:
                    //加载查询信息窗口
                    if(searchForm == null)
                    {
                        searchForm = new SearchForm(this);
                        searchForm.MdiParent = this;
                        searchForm.Parent = this.splitContainer1.Panel2;
                    }
                    if (loginForm != null)
                        loginForm.Hide();
                    if (signForm != null)
                        signForm.Hide();
                    if (userForm != null)
                        userForm.Hide();
                    if (ckeckRegForm != null)
                        ckeckRegForm.Hide();

                    searchForm.Show();
                    break;
                case 1:
                    //加载登录注册窗口
                    if(loginForm == null)
                    {
                        loginForm = new LoginForm(this);
                        loginForm.MdiParent = this;
                        loginForm.Parent = this.splitContainer1.Panel2;
                    }

                    if (signForm != null)
                        signForm.Hide();
                    if (userForm != null)
                        userForm.Hide();
                    if (ckeckRegForm != null)
                        ckeckRegForm.Hide();
                    if (searchForm != null)
                        searchForm.Hide();

                    loginForm.Show();
                    break;
                case 2:

                    //加载注册窗口
                    if(signForm == null)
                    {
                        signForm = new SignForm(this);
                        signForm.MdiParent = this;
                        signForm.Parent = this.splitContainer1.Panel2;
                    }
                    if (loginForm != null)
                        loginForm.Hide();
                    if (userForm != null)
                        userForm.Hide();
                    if (ckeckRegForm != null)
                        ckeckRegForm.Hide();
                    if (searchForm != null)
                        searchForm.Hide();

                    signForm.Show();
                    break;
                case 3:
                    //加载登记信息窗口
                    if(userForm== null)
                    {
                        userForm = new UserForm(this);
                        userForm.MdiParent = this;
                        userForm.Parent = this.splitContainer1.Panel2;
                    }

                    if (loginForm != null)
                        loginForm.Hide();
                    if (ckeckRegForm != null)
                        ckeckRegForm.Hide();
                    if (searchForm != null)
                        searchForm.Hide();
                    if (signForm != null)
                        signForm.Hide();

                    userForm.Show();
                    break;
                case 4:
                    //加载核酸登记窗口
                    if(ckeckRegForm == null)
                    {
                        ckeckRegForm = new CkeckRegForm(this);
                        ckeckRegForm.MdiParent = this;
                        ckeckRegForm.Parent = this.splitContainer1.Panel2;
                    }
                    if (loginForm != null)
                        loginForm.Hide();
                    if (searchForm != null)
                        searchForm.Hide();
                    if (signForm != null)
                        signForm.Hide();
                    if (userForm != null)
                        userForm.Hide();

                    ckeckRegForm.Show();
                    break;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //FormSwitch(int i)
            //case 0:加载查询信息窗口             
            //case 1:加载登录窗口
            //case 2:加载注册窗口   
            //case 3:加载登记信息窗口
            //case 4:加载核酸登记窗口
            FormSwitch(1);

        }
        //退出系统
        private void btn_UserInfo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //树形菜单选择事件
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            foreach(TreeNode node in treeView1.Nodes)
            {
                //设置默认色
                node.BackColor= Color.White;   
                node.ForeColor= Color.Black;
            }
            //选中后背景色和前景色设置
            e.Node.BackColor = SystemColors.Highlight;
            e.Node.ForeColor = Color.White;

            if (e.Node.Text == "核酸登记")
            {
                FormSwitch(4);
            }
            else if(e.Node.Text == "查询信息")
            {
                FormSwitch(0);
            }
            else if(e.Node.Text == "登记信息")
            {
                FormSwitch(3);
            }
        }

    }
}