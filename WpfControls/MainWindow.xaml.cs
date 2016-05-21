using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.ComponentModel;

namespace WpfApplication1
{
    // ListView item
    public class LvItem
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Color { get; set; }
    };

    // A helper to draw a sort direction indicator
    public class SortAdorner : Adorner
    {
        private static Geometry ascGeometry =
                Geometry.Parse("M 0 4 L 3.5 0 L 7 4 Z");

        private static Geometry descGeometry =
                Geometry.Parse("M 0 0 L 3.5 4 L 7 0 Z");

        public ListSortDirection Direction { get; private set; }

        public SortAdorner(UIElement element, ListSortDirection dir)
            : base(element)
        {
            this.Direction = dir;
        }

        protected override void OnRender(DrawingContext drawingContext)
        {
            base.OnRender(drawingContext);

            if (AdornedElement.RenderSize.Width < 20)
                return;

            TranslateTransform transform = new TranslateTransform
                    (
                            AdornedElement.RenderSize.Width - 15,
                            (AdornedElement.RenderSize.Height - 5) / 2
                    );
            drawingContext.PushTransform(transform);

            Geometry geometry = ascGeometry;
            if (this.Direction == ListSortDirection.Descending)
                geometry = descGeometry;
            drawingContext.DrawGeometry(Brushes.Black, null, geometry);

            drawingContext.Pop();
        }
    }

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Populate the list
            this.lvVegs.Items.Add(
                new LvItem { Id = 1, Name = "Tomatoe", Color = "Red" });
            this.lvVegs.Items.Add(
                new LvItem { Id = 2, Name = "Cucumber", Color = "Green" });
            this.lvVegs.Items.Add(
                new LvItem { Id = 3, Name = "Reddish", Color = "Purple" });
            this.lvVegs.Items.Add(
                new LvItem { Id = 4, Name = "Cauliflower", Color = "White" });
            this.lvVegs.Items.Add(
                new LvItem { Id = 5, Name = "Cupsicum", Color = "Yellow" });
            this.lvVegs.Items.Add(
                new LvItem { Id = 6, Name = "Cupsicum", Color = "Red" });
            this.lvVegs.Items.Add(
                new LvItem { Id = 7, Name = "Cupsicum", Color = "Green" });


        }

        private void MyButton_Click_1(object sender, RoutedEventArgs e)
        {
            //TODO:
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
           //TODO:
        }

        private void button1_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            switch (e.ClickCount)
            {
                case 1:
                    label1.Content = "LeftClick";
                    break;
                case 2:
                    label1.Content = "DoubleClick";
                    break;
                default:
                    label1.Content = "TestLabel";
                    break;
            }
        }

        private void button1_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            label1.Content = "RightClick";
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void ToggleButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            label1.Content = "ApplyClick";
        }


        // TreeView drag-n-drop implementation
        // https://social.msdn.microsoft.com/Forums/vstudio/en-US/49560344-281d-42ac-b683-c07ec9bd96fc/treeview-drag-drop-issue?forum=wpf
        private Point _lastMouseDown;
        private TreeViewItem draggedItem, _target;

        private void TreeView_MouseDown (object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                _lastMouseDown = e.GetPosition(tv);
            }
        }
        private void treeView_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.LeftButton == MouseButtonState.Pressed)
                {
                    Point currentPosition = e.GetPosition(tv);

                    if ((Math.Abs(currentPosition.X - _lastMouseDown.X) > 10.0) ||
                        (Math.Abs(currentPosition.Y - _lastMouseDown.Y) > 10.0))
                    {
                        draggedItem = (TreeViewItem)tv.SelectedItem;
                        if (draggedItem != null)
                        {
                            DragDropEffects finalDropEffect = 
                                DragDrop.DoDragDrop(tv,
                                                    tv.SelectedValue,
                                                    DragDropEffects.Move);
                            //Checking target is not null and item is
                            //dragging(moving)
                            if ((finalDropEffect == DragDropEffects.Move) &&
                                (_target != null))
                            {
                                // A Move drop was accepted
                                string strItem = draggedItem.Header.ToString();
                                if (!strItem.Equals(_target.Header.ToString()))
                                {
                                    CopyItem(draggedItem, _target);
                                    _target = null;
                                    draggedItem = null;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
            }
        }
        private void treeView_DragOver(object sender, DragEventArgs e)
        {
            try
            {
                Point currentPosition = e.GetPosition(tv);

                if ((Math.Abs(currentPosition.X - _lastMouseDown.X) > 10.0) ||
                    (Math.Abs(currentPosition.Y - _lastMouseDown.Y) > 10.0))
                {
                    // Verify that this is a valid drop and then store the drop target
                    TreeViewItem item = GetNearestContainer
                    (e.OriginalSource as UIElement);
                    if (CheckDropTarget(draggedItem, item))
                    {
                        e.Effects = DragDropEffects.Move;
                    }
                    else
                    {
                        e.Effects = DragDropEffects.None;
                    }
                }
                e.Handled = true;
            }
            catch (Exception)
            {
            }
        }
        private void treeView_Drop(object sender, DragEventArgs e)
        {
            try
            {
                e.Effects = DragDropEffects.None;
                e.Handled = true;

                // Verify that this is a valid drop and then store the drop target
                TreeViewItem TargetItem = 
                    GetNearestContainer(e.OriginalSource as UIElement);
                if (TargetItem != null && draggedItem != null)
                {
                    _target = TargetItem;
                    e.Effects = DragDropEffects.Move;
                }
            }
            catch (Exception)
            {
            }
        }
        private bool CheckDropTarget(TreeViewItem _sourceItem, TreeViewItem _targetItem)
        {
            //Check whether the target item is meeting your condition
            bool _isEqual = false;
            if (!_sourceItem.Header.ToString().Equals(_targetItem.Header.ToString()))
            {
                _isEqual = true;
            }
            return _isEqual;

        }
        private void CopyItem(TreeViewItem _sourceItem, TreeViewItem _targetItem)
        {

            //Asking user wether he want to drop the dragged TreeViewItem here or not
            //if (! MessageBox.Show("Would you like to drop " + _sourceItem.Header.ToString() + " into " + _targetItem.Header.ToString() + "", "", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            //{
            //    return;
            //}
            try
            {
                //adding dragged TreeViewItem in target TreeViewItem
                addChild(_sourceItem, _targetItem);

                //finding Parent TreeViewItem of dragged TreeViewItem 
                TreeViewItem ParentItem = FindVisualParent<TreeViewItem>(_sourceItem);
                // if parent is null then remove from TreeView else remove from Parent TreeViewItem
                if (ParentItem == null)
                {
                    tv.Items.Remove(_sourceItem);
                }
                else
                {
                    ParentItem.Items.Remove(_sourceItem);
                }
            }
            catch
            {

            }

        }
        public void addChild(TreeViewItem _sourceItem, TreeViewItem _targetItem)
        {
            // add item in target TreeViewItem 
            TreeViewItem item1 = new TreeViewItem();
            item1.Header = _sourceItem.Header;
            _targetItem.Items.Add(item1);
            foreach (TreeViewItem item in _sourceItem.Items)
            {
                addChild(item, item1);
            }
        }
        static TObject FindVisualParent<TObject>(UIElement child) where TObject : UIElement
        {
            if (child == null)
            {
                return null;
            }

            UIElement parent = VisualTreeHelper.GetParent(child) as UIElement;

            while (parent != null)
            {
                TObject found = parent as TObject;
                if (found != null)
                {
                    return found;
                }
                else
                {
                    parent = VisualTreeHelper.GetParent(parent) as UIElement;
                }
            }

            return null;
        }

        private TreeViewItem GetNearestContainer(UIElement element)
        {
            // Walk up the element tree to the nearest tree view item.
            TreeViewItem container = element as TreeViewItem;
            while ((container == null) && (element != null))
            {
                element = VisualTreeHelper.GetParent(element) as UIElement;
                container = element as TreeViewItem;
            }
            return container;
        }

        private void TreeViewItem_Selected(object sender, RoutedEventArgs e)
        {

        }

        // ListView columns sort
        // http://www.wpf-tutorial.com/listview-control/listview-how-to-column-sorting/
        private GridViewColumnHeader listViewSortCol = null;
        private SortAdorner listViewSortAdorner = null;
        private void lvUsersColumnHeader_Click(object sender, RoutedEventArgs e)
        {
            GridViewColumnHeader column = (sender as GridViewColumnHeader);
            string sortBy = column.Tag.ToString();
            if (listViewSortCol != null)
            {
                AdornerLayer.GetAdornerLayer(listViewSortCol).Remove(listViewSortAdorner);
                lvVegs.Items.SortDescriptions.Clear();
            }

            ListSortDirection newDir = ListSortDirection.Ascending;
            if (listViewSortCol == column && listViewSortAdorner.Direction == newDir)
                newDir = ListSortDirection.Descending;

            listViewSortCol = column;
            listViewSortAdorner = new SortAdorner(listViewSortCol, newDir);
            AdornerLayer.GetAdornerLayer(listViewSortCol).Add(listViewSortAdorner);
            lvVegs.Items.SortDescriptions.Add(new SortDescription(sortBy, newDir));
        }


    } // public partial class MainWindow 
} // namespace WpfApplication1
