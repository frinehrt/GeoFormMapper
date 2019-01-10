using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ShapeExtractor;
using SharpMap;
using SharpMap.Data;
using SharpMap.CoordinateSystems;
using SharpMap.Data.Providers;
using SharpMap.Extensions;
using SharpMap.Forms.ToolBar;
using GeoAPI.Geometries;
using NDbfReader;

namespace GeoFormMapper
{
    public partial class frmGeoMap : Form
    {
        private Dictionary<string, clsMapInformation> _dictMaps = null;

        public frmGeoMap()
        {
            InitializeComponent();

            var gss = GeoAPI.GeometryServiceProvider.Instance;
            var css = new SharpMap.CoordinateSystems.CoordinateSystemServices(
                new ProjNet.CoordinateSystems.CoordinateSystemFactory(),
                new ProjNet.CoordinateSystems.Transformations.CoordinateTransformationFactory(),
                SharpMap.Converters.WellKnownText.SpatialReference.GetAllReferenceSystems());

            GeoAPI.GeometryServiceProvider.Instance = gss;
            SharpMap.Session.Instance
                .SetGeometryServices(gss)
                .SetCoordinateSystemServices(css)
                .SetCoordinateSystemRepository(css);
        }

        private void AddShapeExtractorLayer(string pstrShapeExtractorFileName)
        {
            ShapeExtractor.ShapeExtractor oShapeExtractor = new ShapeExtractor.ShapeExtractor(pstrShapeExtractorFileName);
            oShapeExtractor.ShapeZipFile.Extract();
            string strFileName = oShapeExtractor.ShapeZipFile.Contents.First(x => x.Value.IsShapeFile).Value.ExtractedFile.FullName;
            clsMapInformation oMI = new clsMapInformation();
            oMI.MapSource = enmMapSource.ShapeExtractorFile;
            oMI.MapName = Path.GetFileNameWithoutExtension(pstrShapeExtractorFileName);
            oMI.SourcePathName = pstrShapeExtractorFileName;
            //fdr add to dictionary
            //fdr read stzyles
            AddShapeFileLayer(strFileName,true);
        }


        private void AddShapeFileLayer(string pstrShapeFileName,bool pblnFromExtractor=false)
        {
            string strLayerName = Path.GetFileNameWithoutExtension(pstrShapeFileName);
            SharpMap.Layers.VectorLayer oVectorLayer = new SharpMap.Layers.VectorLayer(strLayerName);

            oVectorLayer.DataSource = new SharpMap.Data.Providers.ShapeFile(pstrShapeFileName, true);

            if (!pblnFromExtractor)
            {
                clsMapInformation oMI = new clsMapInformation();
                oMI.MapSource = enmMapSource.ShapeFile;
                oMI.MapName = Path.GetFileNameWithoutExtension(pstrShapeFileName);
                oMI.SourcePathName = pstrShapeFileName;
                //fdr add to dictionary
                //fdr read stzyles
            }

            ////Create the style for Land
            //SharpMap.Styles.VectorStyle oLandStype = new SharpMap.Styles.VectorStyle();
            //oLandStype.Fill = new System.Drawing.SolidBrush(System.Drawing.Color.FromArgb(232, 232, 232));

            ////Create the style for Water
            //SharpMap.Styles.VectorStyle oWaterStyle = new SharpMap.Styles.VectorStyle();
            //oWaterStyle.Fill = new System.Drawing.SolidBrush(System.Drawing.Color.FromArgb(198, 198, 255));

            ////Create the theme items
            //Dictionary<string, SharpMap.Styles.IStyle> dictStyles = new Dictionary<string, SharpMap.Styles.IStyle>();
            //dictStyles.Add("land", oLandStype);
            //dictStyles.Add("water",oWaterStyle);

            ////Assign the theme
            //oVectorLayer.Theme = new SharpMap.Rendering.Thematics.UniqueValuesTheme<string>("class", dictStyles, oLandStype);

            ctlMapBox.Map.Layers.Add(oVectorLayer);
            ctlMapBox.Map.ZoomToExtents();
            ctlMapBox.Refresh();
        }

        private void ctlButtonOpenShapeFile_Click(object sender, EventArgs e)
        {
            if (ctlOpenFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string strFileName = ctlOpenFileDialog.FileName;
                if (Path.GetExtension(strFileName).ToLower() == ".shp")
                {
                    AddShapeFileLayer(strFileName);
                }
                if (Path.GetExtension(strFileName).ToLower() == ".zip")
                {
                    AddShapeExtractorLayer(strFileName,true);
                }
            }
        }

        private void frmGeoMap_Load(object sender, EventArgs e)
        {
            _dictMaps = new Dictionary<string, clsMapInformation>();
            ctlMapZoom.Enabled = true;
        }

        private void frmGeoMap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_dictMaps != null && _dictMaps.Any(x => x.Value.ShapeExtractorInfo != null))
            {
                foreach (KeyValuePair<string, clsMapInformation> kvp in _dictMaps.Where(x => x.Value.ShapeExtractorInfo != null))
                {
                    kvp.Value.ShapeExtractorInfo.Dispose();
                }
            }
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            if (ctlOpenFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string strFileName = ctlOpenFileDialog.FileName;
                if (Path.GetExtension(strFileName).ToLower() == ".shp")
                {
                    AddShapeFileLayer(strFileName);
                }
                if (Path.GetExtension(strFileName).ToLower() == ".zip")
                {
                    AddShapeExtractorLayer(strFileName);
                }
            }
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {

        }

        //private void LoadShapeFile(string pstrFileName)
        //{
        //    var ds = new SharpMap.Data.Providers.ShapeFile(pstrFileName);
        //    var lay = new SharpMap.Layers.VectorLayer(System.IO.Path.GetFileNameWithoutExtension(pstrFileName), ds);
        //    if (ds.CoordinateSystem != null)
        //    {
        //        GeoAPI.CoordinateSystems.Transformations.ICoordinateTransformationFactory fact =
        //            new ProjNet.CoordinateSystems.Transformations.CoordinateTransformationFactory();

        //        lay.CoordinateTransformation = fact.CreateFromCoordinateSystems(ds.CoordinateSystem,
        //            ProjNet.CoordinateSystems.ProjectedCoordinateSystem.WebMercator);
        //        lay.ReverseCoordinateTransformation = fact.CreateFromCoordinateSystems(ProjNet.CoordinateSystems.ProjectedCoordinateSystem.WebMercator,
        //            ds.CoordinateSystem);
        //    }
        //    ctlMapBox.MapLayers.Add(lay);
        //    if (WpfMap.MapLayers.Count == 1)
        //    {
        //        Envelope env = lay.Envelope;
        //        WpfMap.ZoomToEnvelope(env);
        //    }
        //}
    }
}
