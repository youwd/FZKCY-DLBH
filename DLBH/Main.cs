using System;
using System.Windows.Forms;

using ESRI.ArcGIS.Controls;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.esriSystem;
using ESRI.ArcGIS.Geometry;
using ESRI.ArcGIS.SystemUI;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.Display;

namespace DLBH
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        private int flagSelect = 0;
        private int flag = 0;


        // 地图选择集窗体
        public static FormSelection formSelection;
        // 病害卡信息表
        public static FormDisease formDisease;
        // 缺陷信息表
        public static FormDefactInfo formDefactInfo;



        #region 文件模块管理
        /// <summary>
        /// 打开地图文档按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenDoc_Click(object sender, EventArgs e)
        {
            loadMapDocument();
        }

        /// <summary>
        /// 打开地图文档
        /// </summary>
        private void loadMapDocument()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "打开地图文档";
            openFileDialog.Filter = "map documents(*.mxd)|*.mxd";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                if (axMapControl1.CheckMxFile(filePath))
                {
                    axMapControl1.MousePointer = esriControlsMousePointer.esriPointerHourglass;
                    axMapControl1.LoadMxFile(filePath, 0, Type.Missing);
                    axMapControl1.MousePointer = esriControlsMousePointer.esriPointerDefault;
                    //loadEagleEyeDocument(filePath);
                    axMapControl1.Extent = axMapControl1.FullExtent;
                }
                else
                {
                    MessageBox.Show(filePath + "不是有效的地图文档");
                }
            }
        }
        #endregion


        #region 查询模块管理
        /// <summary>
        /// 框选道路病害卡按钮
        /// </summary>
        private void searchDLBH_Click(object sender, EventArgs e)
        {
            // 矩形查询
            flagSelect = 1;
            selectableLayer(flagSelect - 1);

        }
        /// <summary>
        /// 点状缺陷按钮
        /// </summary>
        private void searchDZQX_Click(object sender, EventArgs e)
        {

            flagSelect = 2;
            selectableLayer(flagSelect - 1);

        }

        /// <summary>
        /// 段状缺陷按钮
        /// </summary>
        private void searchDuanZQX_Click(object sender, EventArgs e)
        {
            flagSelect = 3;
            selectableLayer(flagSelect - 1);
        }

        /// <summary>
        /// 选择可选图层
        /// </summary>
        /// <param name="index">图层index</param>
        private void selectableLayer(int index)
        {
            ILayer iLayer;
            IFeatureLayer iFeatureLayer;
            // 设置所有图层不可选
            for (int i = 0; i < axMapControl1.LayerCount; i++)
            {
                iLayer = axMapControl1.get_Layer(i);
                iFeatureLayer = (IFeatureLayer)iLayer;
                iFeatureLayer.Selectable = false;
            }

            iLayer = axMapControl1.get_Layer(index);
            iFeatureLayer = (IFeatureLayer)iLayer;
            iFeatureLayer.Selectable = true;

            // 重置工具栏状态
            axMapControl1.CurrentTool = null;
        }

        /// <summary>
        /// 清除元素选择
        /// </summary>
        private void clearSelect_Click(object sender, EventArgs e)
        {
            flagSelect = 0;

            IActiveView pActiveView = (IActiveView)(axMapControl1.Map);
            pActiveView.PartialRefresh(esriViewDrawPhase.esriViewGeoSelection, axMapControl1.get_Layer(0), null);
            axMapControl1.Map.ClearSelection();
            pActiveView.PartialRefresh(esriViewDrawPhase.esriViewGeoSelection, axMapControl1.get_Layer(0), null);

        }
        #endregion


        /// <summary>
        /// 地图鼠标点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void axMapControl1_OnMouseDown(object sender, IMapControlEvents2_OnMouseDownEvent e)
        {

            if (flagSelect != 0)
            {
                axMapControl1.MousePointer = esriControlsMousePointer.esriPointerCrosshair;
                // 空间查询
                IGeometry selectGeo = null;
                selectGeo = axMapControl1.TrackRectangle();

                if (!selectGeo.IsEmpty)
                {
                    axMapControl1.Map.SelectByShape(selectGeo, null, false);
                    axMapControl1.Refresh(esriViewDrawPhase.esriViewGeoSelection, null, null);


                    // 选中元素操作
                    showSelectFeature(flagSelect - 1);

                }
            }

        }

        private void Main_Load(object sender, EventArgs e)
        {
            axMapControl1.LoadMxFile(Application.StartupPath + @"\World\World.mxd", 0, Type.Missing);
        }

        private void SaveDoc_Click(object sender, EventArgs e)
        {
            string sMxdFileName = axMapControl1.DocumentFilename;
            IMapDocument pMapDocument = new MapDocumentClass();
            if (axMapControl1.LayerCount == 0)
            {
                MessageBox.Show("地图文档为空，请先加载地图文档！");
            }
            else
            {
                try
                {
                    pMapDocument.New(sMxdFileName);
                    pMapDocument.ReplaceContents((IMxdContents)axMapControl1.Map as IMxdContents);
                    pMapDocument.Save(pMapDocument.UsesRelativePaths, true);
                    pMapDocument.Close();
                    MessageBox.Show("保存地图文档成功！");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("保存地图文档失败！" + ex.ToString());
                }

            }
        }

        private void axToolbarControl1_OnMouseDown(object sender, IToolbarControlEvents_OnMouseDownEvent e)
        {
            flagSelect = 0;
        }

        /// <summary>
        /// 选中元素展示
        /// </summary>
        private void showSelectFeature(int index)
        {
            IFeatureLayer featureLayer; //设置临时变量存储当前矢量图层
            string layerName;   //设置临时变量存储当前图层的名称
            IMap currentMap = axMapControl1.Map;

            //首先清空DataGridView中的行和列
            dataGridView.Columns.Clear();
            dataGridView.Rows.Clear();


            //通过IMap接口的SelectionCount属性可以获取被选择要素的数量
            labelMapSelectionCount.Text = "当前地图共选择了 " + currentMap.SelectionCount + " 个要素";

            IFeatureLayer currentFeatureLayer = (IFeatureLayer)axMapControl1.Map.Layer[index];
            //通过接口转换，使用IFeatureSelection接口获取图层的选择集
            IFeatureSelection featureSelection = currentFeatureLayer as IFeatureSelection;
            //通过ISelectionSet接口获取被选择的要素集合
            if (featureSelection == null) { return; }
            ISelectionSet selectionSet = featureSelection.SelectionSet;
            //通过ISelectionSet接口的Count属性可以获取被选择要素的数量


            //获取所有的属性字段
            IFields fields = currentFeatureLayer.FeatureClass.Fields;
            for (int i = 0; i < fields.FieldCount; i++)
            {
                //通过遍历添加列，使用字段的AliasName作为DataGridView中显示的列名
                dataGridView.Columns.Add(fields.get_Field(i).Name, fields.get_Field(i).AliasName);
            }

            //对选择集进行遍历，从而建立DataGridView中的行
            //定义ICursor接口的游标以遍历整个选择集
            ICursor cursor;
            //使用ISelectionSet接口的Search方法，使用null作为查询过滤器，cursor作为返回值获取整个选择集
            selectionSet.Search(null, false, out cursor);
            //进行接口转换，使用IFeatureCursor接口来获取选择集中的每个要素
            IFeatureCursor featureCursor = cursor as IFeatureCursor;
            //获取IFeature接口的游标中的第一个元素
            IFeature feature = featureCursor.NextFeature();
            //定义string类型的数组，以添加DataGridView中每一行的数据
            string[] strs;
            //当游标不为空时
            while (feature != null)
            {
                //string数组的大小为字段的个数
                strs = new string[fields.FieldCount];
                //对字段进行遍历
                for (int i = 0; i < fields.FieldCount; i++)
                {
                    //将当前要素的每个字段值放在数组的相应位置
                    strs[i] = feature.get_Value(i).ToString();
                }
                //在DataGridView中添加一行的数据
                dataGridView.Rows.Add(strs);
                //移动游标到下一个要素
                feature = featureCursor.NextFeature();
            }

            // 如果只选择到一个元素，则直接弹出信息框
            if (currentMap.SelectionCount ==1) {
                 dataGridView.Rows[0].Selected= true;
                showDetail();
            }
        }

        private void showSelectFeature2(IGeometry iGeometry)
        {
            ISimpleFillSymbol iFillSymbol;
            ISymbol iSymbol;
            IRgbColor iRgbColor;
            iFillSymbol = new SimpleFillSymbol();
            iFillSymbol.Style = esriSimpleFillStyle.esriSFSSolid;
            iFillSymbol.Outline.Width = 12;
            iRgbColor = new RgbColor();
            iRgbColor.Red = 0;
            iRgbColor.Green = 162;
            iRgbColor.Blue = 232;
            iFillSymbol.Color = iRgbColor;
            iSymbol = (ISymbol)iFillSymbol;
            iSymbol.ROP2 = esriRasterOpCode.esriROPNotXOrPen;
            axMapControl1.ActiveView.ScreenDisplay.SetSymbol(iSymbol);
            axMapControl1.FlashShape(iGeometry, 3, 200, iSymbol);
        }

        /// <summary>
        /// 地图移动事件，在状态栏显示坐标
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void axMapControl1_OnMouseMove(object sender, IMapControlEvents2_OnMouseMoveEvent e)
        {
            toolStripStatusLabel1.Text = String.Format("{0}, {1}  {2}", e.mapX.ToString("#######.##"), e.mapY.ToString("#######.##"), axMapControl1.MapUnits.ToString().Substring(4));
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            showDetail();
        }

        private void showDetail() {
            switch (flagSelect)
            {
                case 1:
                    if (formDisease == null)
                    {
                        formDisease = new FormDisease();
                        formDisease.Show();
                    }
                    formDisease.UpdateData(dataGridView.SelectedRows[0]);
                    break;
                case 2:
                case 3:
                    if (formDefactInfo == null)
                    {
                        formDefactInfo = new FormDefactInfo();
                        formDefactInfo.Show();
                    }
                    formDefactInfo.UpdateData(dataGridView.SelectedRows[0],flagSelect);
                    break;
                default:
                    break;
            }
        }

        private void NewDoc_Click(object sender, EventArgs e)
        {
            string sMxdFileName = axMapControl1.DocumentFilename;
            IMapDocument pMapDocument = new MapDocumentClass();
            DialogResult res = MessageBox.Show("是否保存当前地图文档?", "提示", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {

                try
                {
                    pMapDocument.New(sMxdFileName);
                    pMapDocument.ReplaceContents((IMxdContents)axMapControl1.Map as IMxdContents);
                    pMapDocument.Save(pMapDocument.UsesRelativePaths, true);
                    pMapDocument.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("保存地图文档失败！" + ex.ToString());
                }
            }
        }
    }
}
