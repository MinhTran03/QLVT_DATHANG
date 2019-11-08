using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.XtraEditors.Registrator;
using System.ComponentModel;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.Utils;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.Utils.Drawing;

namespace QLVT_DATHANG
{
    [UserRepositoryItem("RegisterCustomIconTextEdit")]
    public class RepositoryItemCustomIconTextEdit : RepositoryItemTextEdit, IIconSelector
    {
        object imageList;
        int imageIndex;

        static RepositoryItemCustomIconTextEdit() { RegisterCustomIconTextEdit(); }

        public RepositoryItemCustomIconTextEdit()
        {
            imageList = null;
            ImageIndex = -1;
        }

        public const string CustomIconTextEditName = "CustomIconTextEdit";

        public override string EditorTypeName { get { return CustomIconTextEditName; } }

        public static void RegisterCustomIconTextEdit()
        {
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(CustomIconTextEditName,
              typeof(CustomIconTextEdit), typeof(RepositoryItemCustomIconTextEdit),
              typeof(TextEditViewInfo), new TextEditPainter(), true));
        }


        public override void Assign(RepositoryItem item)
        {
            base.Assign(item);
            RepositoryItemCustomIconTextEdit source = item as RepositoryItemCustomIconTextEdit;
            Events.AddHandler(_iconClick, source.Events[_iconClick]);
            Events.AddHandler(_onIconSelection, source.Events[_onIconSelection]);
            this.imageList = source.ImageList;
            this.imageIndex = source.ImageIndex;
        }
        static readonly object _iconClick = new object();
        static readonly object _onIconSelection = new object();

        public event IconClickEventHandler IconClick
        {
            add { this.Events.AddHandler(_iconClick, value); }
            remove { this.Events.RemoveHandler(_iconClick, value); }
        }
        protected internal virtual void RaiseIconClick(MouseEventArgs e)
        {
            IconClickEventHandler handler = (IconClickEventHandler)Events[_iconClick];
            if (handler != null) handler(GetEventSender(), e);
        }
        internal bool CanRaiseBeforeEditValueLoaded { get { return (IconClickEventHandler)Events[_iconClick] != null; } }

        public event OnIconSelectionEventHandler OnIconSelection
        {
            add { this.Events.AddHandler(_onIconSelection, value); }
            remove { this.Events.RemoveHandler(_onIconSelection, value); }
        }
        protected internal virtual void RaiseOnIconSelection(OnIconSelectionEventArgs e)
        {
            OnIconSelectionEventHandler handler = (OnIconSelectionEventHandler)Events[_onIconSelection];
            if (handler != null) handler(GetEventSender(), e);
        }


        [Description("Gets or sets the source of images to be displayed within the editor."), Category(CategoryName.Appearance), TypeConverter(typeof(DevExpress.Utils.Design.ImageCollectionImagesConverter))]
        public virtual object ImageList
        {
            get { return imageList; }
            set
            {
                if (ImageList == value) return;
                imageList = value;
                OnPropertiesChanged();
            }
        }

        [Description("Gets or sets the index of the image displayed on the editor."), Category(CategoryName.Appearance), DefaultValue(-1), Editor(typeof(DevExpress.Utils.Design.ImageIndexesEditor), typeof(System.Drawing.Design.UITypeEditor)), ImageList("ImageList")]
        public virtual int ImageIndex
        {
            get { return imageIndex; }
            set
            {
                if (ImageIndex == value) return;
                imageIndex = value;
                OnPropertiesChanged();
            }
        }

        public override BaseEditViewInfo CreateViewInfo()
        {
            return new CustomIconTextEditViewInfo(this);
        }
        public override BaseEditPainter CreatePainter()
        {
            return new CustomIconTextEditPainter();
        }
    }

    public delegate void IconClickEventHandler(object sender, MouseEventArgs e);
    public delegate void OnIconSelectionEventHandler(object sender, OnIconSelectionEventArgs e);
    public class OnIconSelectionEventArgs : EventArgs
    {
        int imageIndex;
        object imageList;
        public OnIconSelectionEventArgs(object iconCollection, int iconIndex)
        {
            this.imageList = iconCollection;
            this.imageIndex = iconIndex;
        }
        public virtual int ImageIndex
        {
            get { return imageIndex; }
            set { imageIndex = value; }
        }
        public virtual object ImageList
        {
            get { return imageList; }
            //set { imageList = value; }
        }
    }

    public class CustomIconTextEdit : TextEdit
    {
        static CustomIconTextEdit() { RepositoryItemCustomIconTextEdit.RegisterCustomIconTextEdit(); }

        public CustomIconTextEdit() : base() { }

        public override string EditorTypeName { get { return RepositoryItemCustomIconTextEdit.CustomIconTextEditName; } }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new RepositoryItemCustomIconTextEdit Properties { get { return base.Properties as RepositoryItemCustomIconTextEdit; } }

        protected override void OnMouseDown(System.Windows.Forms.MouseEventArgs e)
        {
            CustomIconTextEditViewInfo vi = ViewInfo as CustomIconTextEditViewInfo;
            if (vi.IsIconClick(e.Location))
            {
                int newX = e.X - vi.IconRect.Left;
                int newY = e.Y - vi.IconRect.Top;
                MouseEventArgs ee = new MouseEventArgs(e.Button, e.Clicks, newX, newY, e.Delta);
                Properties.RaiseIconClick(ee);
            }
            base.OnMouseDown(e);
        }
        public event IconClickEventHandler IconClick
        {
            add { this.Properties.IconClick += value; }
            remove { this.Properties.IconClick -= value; }
        }
    }

    public class CustomIconTextEditViewInfo : TextEditViewInfo
    {
        Rectangle fIconRect;
        int SeparatorWidth = 3;

        public CustomIconTextEditViewInfo(RepositoryItem item)
            : base(item)
        {
            fIconRect = Rectangle.Empty;
        }


        protected virtual internal bool IsIconClick(Point p)
        {
            if (p.X > IconRect.Left && p.X < IconRect.Right && p.Y > IconRect.Top && p.Y < IconRect.Bottom) return true;
            else return false;
        }

        public object ImageList
        {
            get { return Item.ImageList; }
        }

        public int ImageIndex
        {
            get { return Item.ImageIndex; }
        }

        public virtual new RepositoryItemCustomIconTextEdit Item
        {
            get { return base.Item as RepositoryItemCustomIconTextEdit; }
        }

        protected override void Assign(BaseControlViewInfo info)
        {
            base.Assign(info);
            CustomIconTextEditViewInfo be = info as CustomIconTextEditViewInfo;
            if (be == null) return;
            this.fIconRect = be.fIconRect;
        }

        public override Size CalcBestFit(Graphics g)
        {
            Size s = base.CalcBestFit(g);
            s.Width = s.Width + SeparatorWidth * 2 + GetImageSize().Width;
            return s;
        }

        protected internal virtual Rectangle IconRect
        {
            get { return fIconRect; }
            set { fIconRect = value; }
        }

        public override void Offset(int x, int y)
        {
            base.Offset(x, y);
            if (!fIconRect.IsEmpty) this.fIconRect.Offset(x, y);
        }

        protected override Rectangle CalcMaskBoxRect(Rectangle content, ref Rectangle contextImageBounds)
        {
            Rectangle r = base.CalcMaskBoxRect(content, ref contextImageBounds);
            r.Width = r.Width - GetImageSize().Width - SeparatorWidth;
            return r;
        }

        protected override void CalcContentRect(Rectangle bounds)
        {
            base.CalcContentRect(bounds);
            this.fIconRect = CalcIconRect(ContentRect);
        }

        protected virtual Rectangle CalcIconRect(Rectangle content)
        {
            Rectangle r = fMaskBoxRect;
            r.Size = GetImageSize();
            r.Location = new Point(fMaskBoxRect.Right + SeparatorWidth, content.Top + content.Height / 2 - r.Height / 2);
            return r;
        }

        protected Size GetImageSize()
        {
            ImageCollection ic = ImageList as ImageCollection;
            if (ic != null) return ic.ImageSize;
            return new Size(0, 0);
        }

        protected override int CalcMinHeightCore(Graphics g)
        {
            int imageHeight = 0;
            if (ImageList != null)
            {
                imageHeight = GetImageSize().Height;
                if (AllowDrawFocusRect)
                    imageHeight += (FocusRectThin + 1) * 2;
            }
            int fontHeight = base.CalcMinHeightCore(g);
            if (imageHeight > fontHeight) return imageHeight;
            else return fontHeight;
        }
    }

    public class CustomIconTextEditPainter : TextEditPainter
    {
        public CustomIconTextEditPainter() : base() { }

        protected override void DrawContent(ControlGraphicsInfoArgs info)
        {
            base.DrawContent(info);
            DrawIcon(info);
        }
       

        protected virtual void DrawIcon(ControlGraphicsInfoArgs info)
        {
            CustomIconTextEditViewInfo vi = info.ViewInfo as CustomIconTextEditViewInfo;
            OnIconSelectionEventArgs e = new OnIconSelectionEventArgs(vi.ImageList, vi.ImageIndex);
            vi.Item.RaiseOnIconSelection(e);
            if (e.ImageList != null && e.ImageIndex != -1)
                info.Cache.Paint.DrawImage(info.Cache, e.ImageList, e.ImageIndex, vi.IconRect, true);
            else
                info.Graphics.FillRectangle(info.Cache.GetSolidBrush(Color.White), vi.IconRect);
        }
    }

    public interface IIconSelector
    {
        event OnIconSelectionEventHandler OnIconSelection;
    }
}
