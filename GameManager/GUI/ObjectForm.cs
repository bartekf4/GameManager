using GameManager.Data.Models;
using GameManager.DataHandlers;
using Object = GameManager.Data.Models.Object;

namespace GameManager.GUI;

public sealed partial class ObjectForm : Form
{
    private Category _category;
    private Thread _getImageThread;
    private Image _image;
    private bool _isKey;
    private string _name;

    private string _path;
    private byte[] _photo;

    private readonly List<ObjectProperty> _properties = new();

    private string _propertyName;

    private bool _validData;
    private int _value;

    public ObjectForm(Object? obj = null)
    {
        InitializeComponent();
        Painters.FillCategories(treeView, true);
        pictureBox.AllowDrop = true;
        AllowDrop = true;
        pictureBox.DragDrop += pictureBox_DragDrop;
        if (obj != null)
        {
            _properties = ObjectHandler.GetObjectsProperties(obj);
            if (_properties != null) Painters.FillProperties(listBox1, _properties);
            _image = Painters.ByteArrayToImage(obj.Photo);
            pictureBox.Image = _image;
            _name = obj.Name;
            textBox1.Text = _name;
            _category = obj.Category;
            treeView.Nodes.Find(_category.Name, true).First().Checked = true;
            AddObject_button.Text = @"Edit";
        }
    }

    private void checkBox1_CheckedChanged(object sender, EventArgs e)
    {
        _isKey = checkBox1.Checked;
    }

    private static byte[] ImageToByteArray(Image imageIn)
    {
        using var ms = new MemoryStream();
        imageIn.Save(ms, imageIn.RawFormat);
        return ms.ToArray();
    }

    private void LoadImage()

    {
        _image = new Bitmap(_path);
        _photo = ImageToByteArray(_image);
    }


    private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
    {
        if (e.Node != null) _category = (Category) e.Node.Tag;
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {
        _name = textBox1.Text;
    }

    private void propertyName_textBox_TextChanged(object sender, EventArgs e)
    {
        _propertyName = propertyName_textBox.Text;
    }

    private void valueProperty_textBox_TextChanged(object sender, EventArgs e)
    {
        _value = int.Parse(valueProperty_textBox.Text);
    }

    private void addProperty_button_Click(object sender, EventArgs e)
    {
        _properties.Add(new ObjectProperty {IsCore = _isKey, Name = _propertyName, Value = _value});
        listBox1.Items.Add(_properties.Last().ToString());
    }

    private void AddObject_button_Click(object sender, EventArgs e)
    {
        ObjectHandler.Add(_category,
            _name,
            UsersHandler.GetByName(Globals.CurrentUser)!, _photo,
            _properties);
    }


    private static bool GetFilename(out string filename, DragEventArgs e)
    {
        var ret = false;
        filename = string.Empty;
        if ((e.AllowedEffect & DragDropEffects.Copy) != DragDropEffects.Copy) return ret;
        if (((IDataObject) e.Data!).GetData("FileDrop") is not Array data) return ret;
        if (data.Length != 1 || data.GetValue(0) is not string) return ret;
        filename = ((string[]) data)[0];
        var ext = Path.GetExtension(filename).ToLower();
        if (ext is ".jpg" or ".png" or ".bmp") ret = true;

        return ret;
    }

    private void pictureBox_DragDrop(object sender, DragEventArgs e)
    {
        if (!_validData) return;
        while (_getImageThread.IsAlive)
        {
            Application.DoEvents();
            Thread.Sleep(0);
        }

        pictureBox.Image = _image;
    }

    private void pictureBox_DragEnter(object sender, DragEventArgs e)
    {
        _validData = GetFilename(out var filename, e);
        if (_validData)
        {
            _path = filename;
            _getImageThread = new Thread(LoadImage);
            _getImageThread.Start();
            e.Effect = DragDropEffects.Copy;
        }
        else
        {
            e.Effect = DragDropEffects.None;
        }
    }
}