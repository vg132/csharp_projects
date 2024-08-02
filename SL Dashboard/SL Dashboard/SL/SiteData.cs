using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SL_Dashboard.Models;

namespace SL_Dashboard.SL
{
	public class SiteData
	{
		private static List<Site> _sites;
		private static List<Models.TransportationType> _transportationTypes;

		public static List<Models.TransportationType> TransportationTypes
		{
			get
			{
				if (_transportationTypes == null)
				{
					_transportationTypes = new List<Models.TransportationType>();
					_transportationTypes.Add(new Models.TransportationType(1, "Pendeltåg"));
					_transportationTypes.Add(new Models.TransportationType(2, "Roslagsbanan"));
					_transportationTypes.Add(new Models.TransportationType(3, "Tunnelbanan"));
					_transportationTypes.Add(new Models.TransportationType(4, "Tvärbanan"));
				}
				return _transportationTypes;
			}
		}

		private static List<Site> Sites
		{
			get
			{
				if (_sites == null)
				{
					_sites = new List<Site>();
					#region Site Data

					_sites.Add(new Site("Barkarby", 9703, 59.403576, 17.868834, 1));
					_sites.Add(new Site("Bro", 9711, 59.51142, 17.635889, 1));
					_sites.Add(new Site("Bålsta", 9710, 59.569244, 17.531003, 1));
					_sites.Add(new Site("Farsta strand", 9180, 59.236435, 18.101564, 1));
					_sites.Add(new Site("Flemingsberg", 9526, 59.217584, 17.946274, 1));
					_sites.Add(new Site("Gnesta", 9540, 59.048744, 17.311621, 1));
					_sites.Add(new Site("Gröndalsviken", 9721, 58.899043, 17.932069, 1));
					_sites.Add(new Site("Handen", 9730, 59.167593, 18.134394, 1));
					_sites.Add(new Site("Helenelund", 9507, 59.409626, 17.961445, 1));
					_sites.Add(new Site("Hemfosa", 9725, 59.068868, 17.976422, 1));
					_sites.Add(new Site("Huddinge", 9527, 59.237302, 17.98022, 1));
					_sites.Add(new Site("Häggvik", 9505, 59.444399, 17.932262, 1));
					_sites.Add(new Site("Jakobsberg", 9702, 59.423404, 17.832892, 1));
					_sites.Add(new Site("Jordbro", 9729, 59.141541, 18.125811, 1));
					_sites.Add(new Site("Järna", 9542, 59.093322, 17.567267, 1));
					_sites.Add(new Site("Kallhäll", 9701, 59.453244, 17.805812, 1));
					_sites.Add(new Site("Karlberg", 9510, 59.339624, 18.029423, 1));
					_sites.Add(new Site("Krigslida", 9727, 59.109603, 18.067499, 1));
					_sites.Add(new Site("Kungsängen", 9700, 59.477915, 17.752361, 1));
					_sites.Add(new Site("Märsta", 9500, 59.628126, 17.861033, 1));
					_sites.Add(new Site("Mölnbo", 9541, 59.047508, 17.418137, 1));
					_sites.Add(new Site("Norrviken", 9504, 59.458228, 17.924237, 1));
					_sites.Add(new Site("Nynäsgård", 9722, 58.913399, 17.942466, 1));
					_sites.Add(new Site("Nynäshamn", 9720, 58.901121, 17.950962, 1));
					_sites.Add(new Site("Rosersberg", 9501, 59.58337, 17.879776, 1));
					_sites.Add(new Site("Rotebro", 9503, 59.476433, 17.914238, 1));
					_sites.Add(new Site("Rönninge", 9523, 59.193526, 17.749979, 1));
					_sites.Add(new Site("Segersäng", 9724, 59.029078, 17.926641, 1));
					_sites.Add(new Site("Skogås", 9731, 59.218211, 18.154306, 1));
					_sites.Add(new Site("Sollentuna", 9506, 59.428861, 17.948098, 1));
					_sites.Add(new Site("Solna", 9509, 59.365154, 18.010068, 1));
					_sites.Add(new Site("Spånga", 9704, 59.383343, 17.898788, 1));
					_sites.Add(new Site("Stockholms central", 9000, 59.330354, 18.058841, 1));
					_sites.Add(new Site("Stockholms södra", 9530, 59.314163, 18.064485, 1));
					_sites.Add(new Site("Stuvsta", 9528, 59.253223, 17.996013, 1));
					_sites.Add(new Site("Sundbyberg", 9325, 59.360751, 17.970742, 1));
					_sites.Add(new Site("Södertälje Syd", 9543, 59.162292, 17.645416, 1));
					_sites.Add(new Site("Södertälje centrum", 9520, 59.192417, 17.626791, 1));
					_sites.Add(new Site("Södertälje hamn", 9521, 59.17928, 17.646799, 1));
					_sites.Add(new Site("Trångsund", 9732, 59.228027, 18.129544, 1));
					_sites.Add(new Site("Tullinge", 9525, 59.205206, 17.903037, 1));
					_sites.Add(new Site("Tumba", 9524, 59.199735, 17.835617, 1));
					_sites.Add(new Site("Tungelsta", 9726, 59.102491, 18.044872, 1));
					_sites.Add(new Site("Ulriksdal", 9508, 59.380742, 18.000283, 1));
					_sites.Add(new Site("Upplands Väsby", 9502, 59.521826, 17.899647, 1));
					_sites.Add(new Site("Västerhaninge", 9728, 59.122847, 18.102593, 1));
					_sites.Add(new Site("Älvsjö", 9529, 59.278774, 18.010969, 1));
					_sites.Add(new Site("Årstaberg", 9531, 59.300067, 18.029181, 1));
					_sites.Add(new Site("Ösmo", 9723, 58.98471, 17.902662, 1));
					_sites.Add(new Site("Östertälje", 9522, 59.184415, 17.659965, 1));

					_sites.Add(new Site("Altorp", 9683, 59.410194, 18.072874, 2));
					_sites.Add(new Site("Bråvallavägen", 9636, 59.405585, 18.060579, 2));
					_sites.Add(new Site("Bällsta", 9627, 59.523942, 18.071844, 2));
					_sites.Add(new Site("Djursholms Ekeby", 9635, 59.412727, 18.057403, 2));
					_sites.Add(new Site("Djursholms Ösby", 9637, 59.397978, 18.058648, 2));
					_sites.Add(new Site("Ekskogen", 9621, 59.639044, 18.226983, 2));
					_sites.Add(new Site("Enebyberg", 9634, 59.425565, 18.051288, 2));
					_sites.Add(new Site("Ensta", 9631, 59.453468, 18.063658, 2));
					_sites.Add(new Site("Frösunda", 9622, 59.624204, 18.170464, 2));
					_sites.Add(new Site("Galoppfältet", 9668, 59.447147, 18.085148, 2));
					_sites.Add(new Site("Hägernäs", 9666, 59.451155, 18.124641, 2));
					_sites.Add(new Site("Kragstalund", 9628, 59.509264, 18.075857, 2));
					_sites.Add(new Site("Kårsta", 9620, 59.656777, 18.267441, 2));
					_sites.Add(new Site("Lahäll", 9682, 59.427399, 18.085341, 2));
					_sites.Add(new Site("Lindholmen", 9623, 59.584152, 18.109266, 2));
					_sites.Add(new Site("Molnby", 9624, 59.556526, 18.08474, 2));
					_sites.Add(new Site("Mörby", 9638, 59.391871, 18.046921, 2));
					_sites.Add(new Site("Näsby allé", 9681, 59.427399, 18.085341, 2));
					_sites.Add(new Site("Näsbypark", 9680, 59.43052, 18.096156, 2));
					_sites.Add(new Site("Ormsta", 9625, 59.545995, 18.079504, 2));
					_sites.Add(new Site("Roslags Näsby", 9633, 59.435245, 18.057296, 2));
					_sites.Add(new Site("Rydbo", 9665, 59.465325, 18.183231, 2));
					_sites.Add(new Site("Stockholms östra", 9600, 59.34609, 18.071705, 2));
					_sites.Add(new Site("Stocksund", 9639, 59.385086, 18.043928, 2));
					_sites.Add(new Site("Tibble", 9632, 59.442467, 18.062596, 2));
					_sites.Add(new Site("Tunagård", 9661, 59.469004, 18.307471, 2));
					_sites.Add(new Site("Täby centrum", 9669, 59.44394, 18.074054, 2));
					_sites.Add(new Site("Täby kyrkby", 9629, 59.460997, 18.062725, 2));
					_sites.Add(new Site("Täljö", 9664, 59.472389, 18.233485, 2));
					_sites.Add(new Site("Universitetet", 9203, 59.360309, 18.056674, 2));
					_sites.Add(new Site("Vallentuna", 9626, 59.533327, 18.079805, 2));
					_sites.Add(new Site("Vendevägen", 9685, 59.399906, 18.067971, 2));
					_sites.Add(new Site("Viggbyholm", 9667, 59.449045, 18.103859, 2));
					_sites.Add(new Site("Visinge", 9630, 59.460997, 18.062725, 2));
					_sites.Add(new Site("Åkers Runö", 9663, 59.480786, 18.268901, 2));
					_sites.Add(new Site("Åkersberga", 9662, 59.479151, 18.298437, 2));
					_sites.Add(new Site("Östberga", 9684, 59.402839, 18.073024, 2));
					_sites.Add(new Site("Österskär", 9660, 59.460981, 18.311945, 2));

					_sites.Add(new Site("Abrahamsberg", 9110, 59.336675, 17.952947, 3));
					_sites.Add(new Site("Akalla", 9300, 59.414198, 17.920315, 3));
					_sites.Add(new Site("Alby", 9282, 59.239508, 17.845573, 3));
					_sites.Add(new Site("Alvik", 9112, 59.333616, 17.980263, 3));
					_sites.Add(new Site("Aspudden", 9293, 59.306453, 18.001528, 3));
					_sites.Add(new Site("Axelsberg", 9291, 59.30435, 17.975392, 3));
					_sites.Add(new Site("Bagarmossen", 9141, 59.276274, 18.131453, 3));
					_sites.Add(new Site("Bandhagen", 9163, 59.270354, 18.049335, 3));
					_sites.Add(new Site("Bergshamra", 9202, 59.381551, 18.03659, 3));
					_sites.Add(new Site("Björkhagen", 9143, 59.29112, 18.11551, 3));
					_sites.Add(new Site("Blackeberg", 9105, 59.348333, 17.882813, 3));
					_sites.Add(new Site("Blåsut", 9187, 59.29026, 18.090963, 3));
					_sites.Add(new Site("Bredäng", 9289, 59.294906, 17.933764, 3));
					_sites.Add(new Site("Brommaplan", 9109, 59.338376, 17.939257, 3));
					_sites.Add(new Site("Danderyds sjukhus", 9201, 59.39191, 18.04131, 3));
					_sites.Add(new Site("Duvbo", 9324, 59.368472, 17.96621, 3));
					_sites.Add(new Site("Enskede gård", 9167, 59.2894, 18.070289, 3));
					_sites.Add(new Site("Farsta strand", 9180, 59.234991, 18.101724, 3));
					_sites.Add(new Site("Farsta", 9181, 59.24337, 18.093194, 3));
					_sites.Add(new Site("Fittja", 9283, 59.247453, 17.86098, 3));
					_sites.Add(new Site("Fridhemsplan", 9115, 59.333435, 18.03477, 3));
					_sites.Add(new Site("Fruängen", 9260, 59.285811, 17.964964, 3));
					_sites.Add(new Site("Gamla stan", 9193, 59.323294, 18.067059, 3));
					_sites.Add(new Site("Globen", 9168, 59.294248, 18.077917, 3));
					_sites.Add(new Site("Gubbängen", 9183, 59.262853, 18.082058, 3));
					_sites.Add(new Site("Gullmarsplan", 9189, 59.299025, 18.080835, 3));
					_sites.Add(new Site("Gärdet", 9221, 59.34667, 18.099589, 3));
					_sites.Add(new Site("Hagsätra", 9160, 59.262722, 18.012514, 3));
					_sites.Add(new Site("Hallonbergen", 9303, 59.374975, 17.972149, 3));
					_sites.Add(new Site("Hallunda", 9281, 59.243239, 17.825618, 3));
					_sites.Add(new Site("Hammarbyhöjden", 9144, 59.294736, 18.104546, 3));
					_sites.Add(new Site("Hjulsta", 9320, 59.397266, 17.892071, 3));
					_sites.Add(new Site("Hornstull", 9295, 59.315871, 18.033886, 3));
					_sites.Add(new Site("Husby", 9301, 59.410551, 17.929213, 3));
					_sites.Add(new Site("Huvudsta", 9327, 59.350044, 17.989396, 3));
					_sites.Add(new Site("Hägerstensåsen", 9262, 59.295607, 17.979125, 3));
					_sites.Add(new Site("Hässelby gård", 9101, 59.366875, 17.84377, 3));
					_sites.Add(new Site("Hässelby strand", 9100, 59.361266, 17.832344, 3));
					_sites.Add(new Site("Högdalen", 9162, 59.263818, 18.043026, 3));
					_sites.Add(new Site("Hökarängen", 9182, 59.257742, 18.082809, 3));
					_sites.Add(new Site("Hötorget", 9119, 59.335553, 18.063583, 3));
					_sites.Add(new Site("Islandstorget", 9106, 59.345833, 17.894024, 3));
					_sites.Add(new Site("Johannelund", 9102, 59.367925, 17.85745, 3));
					_sites.Add(new Site("Karlaplan", 9222, 59.338836, 18.090835, 3));
					_sites.Add(new Site("Kista", 9302, 59.403337, 17.946463, 3));
					_sites.Add(new Site("Kristineberg", 9113, 59.332691, 18.00319, 3));
					_sites.Add(new Site("Kungsträdgården", 9340, 59.331288, 18.076427, 3));
					_sites.Add(new Site("Kärrtorp", 9142, 59.284473, 18.114438, 3));
					_sites.Add(new Site("Liljeholmen", 9294, 59.310746, 18.022814, 3));
					_sites.Add(new Site("Mariatorget", 9297, 59.316977, 18.063326, 3));
					_sites.Add(new Site("Masmo", 9284, 59.249677, 17.880329, 3));
					_sites.Add(new Site("Medborgarplatsen", 9191, 59.31436, 18.073454, 3));
					_sites.Add(new Site("Midsommarkransen", 9264, 59.301852, 18.012042, 3));
					_sites.Add(new Site("Mälarhöjden", 9290, 59.300932, 17.957282, 3));
					_sites.Add(new Site("Mörby centrum", 9200, 59.398727, 18.036203, 3));
					_sites.Add(new Site("Norsborg", 9280, 59.243832, 17.814417, 3));
					_sites.Add(new Site("Näckrosen", 9304, 59.367122, 17.986903, 3));
					_sites.Add(new Site("Odenplan", 9117, 59.342994, 18.049636, 3));
					_sites.Add(new Site("Rinkeby", 9322, 59.388624, 17.932315, 3));
					_sites.Add(new Site("Rissne", 9323, 59.376333, 17.943161, 3));
					_sites.Add(new Site("Ropsten", 9223, 59.357324, 18.102121, 3));
					_sites.Add(new Site("Råcksta", 9104, 59.354797, 17.881826, 3));
					_sites.Add(new Site("Rådhuset", 9309, 59.330651, 18.045749, 3));
					_sites.Add(new Site("Rådmansgatan", 9118, 59.340565, 18.058691, 3));
					_sites.Add(new Site("Rågsved", 9161, 59.256581, 18.028134, 3));
					_sites.Add(new Site("S:t Eriksplan", 9116, 59.339909, 18.036632, 3));
					_sites.Add(new Site("Sandsborg", 9186, 59.284758, 18.092401, 3));
					_sites.Add(new Site("Skanstull", 9190, 59.307899, 18.076158, 3));
					_sites.Add(new Site("Skarpnäck", 9140, 59.266757, 18.133342, 3));
					_sites.Add(new Site("Skogskyrkogården", 9185, 59.27919, 18.09549, 3));
					_sites.Add(new Site("Skärholmen", 9287, 59.277174, 17.9069, 3));
					_sites.Add(new Site("Skärmarbrink", 9188, 59.295476, 18.090362, 3));
					_sites.Add(new Site("Slussen", 9192, 59.319528, 18.072295, 3));
					_sites.Add(new Site("Sockenplan", 9166, 59.283296, 18.070589, 3));
					_sites.Add(new Site("Solna centrum", 9305, 59.358779, 17.998717, 3));
					_sites.Add(new Site("Stadion", 9205, 59.342994, 18.081779, 3));
					_sites.Add(new Site("Stadshagen", 9307, 59.337223, 18.021148, 3));
					_sites.Add(new Site("Stora mossen", 9111, 59.334524, 17.966176, 3));
					_sites.Add(new Site("Stureby", 9164, 59.274608, 18.055601, 3));
					_sites.Add(new Site("Sundbybergs centrum", 9325, 59.361691, 17.975454, 3));
					_sites.Add(new Site("Svedmyra", 9165, 59.283334, 18.070536, 3));
					_sites.Add(new Site("Sätra", 9288, 59.285022, 17.921362, 3));
					_sites.Add(new Site("T-Centralen", 9001, 59.330792, 18.063088, 3));
					_sites.Add(new Site("Tallkrogen", 9184, 59.2711, 18.085298, 3));
					_sites.Add(new Site("Tekniska högskolan", 9204, 59.34585, 18.071694, 3));
					_sites.Add(new Site("Telefonplan", 9263, 59.298324, 17.997193, 3));
					_sites.Add(new Site("Tensta", 9321, 59.394981, 17.90468, 3));
					_sites.Add(new Site("Thorildsplan", 9114, 59.331788, 18.015432, 3));
					_sites.Add(new Site("Universitetet", 9203, 59.365526, 18.054872, 3));
					_sites.Add(new Site("Vreten", 9326, 59.354621, 17.976657, 3));
					_sites.Add(new Site("Vällingby", 9103, 59.36324, 17.872052, 3));
					_sites.Add(new Site("Västertorp", 9261, 59.291444, 17.966638, 3));
					_sites.Add(new Site("Västra skogen", 9306, 59.347974, 18.00734, 3));
					_sites.Add(new Site("Vårberg", 9286, 59.275968, 17.89012, 3));
					_sites.Add(new Site("Vårby gård", 9285, 59.264631, 17.884369, 3));
					_sites.Add(new Site("Zinkensdamm", 9296, 59.31782, 18.050065, 3));
					_sites.Add(new Site("Ängbyplan", 9107, 59.341856, 17.906942, 3));
					_sites.Add(new Site("Åkeshov", 9108, 59.342037, 17.924899, 3));
					_sites.Add(new Site("Örnsberg", 9292, 59.305555, 17.989168, 3));
					_sites.Add(new Site("Östermalmstorg", 9206, 59.334962, 18.074012, 3));

					_sites.Add(new Site("Alvik", 9112, 59.33322773187615, 17.97965168952942, 4));
					_sites.Add(new Site("Alviks strand", 9812, 59.32888801573286, 17.98211932182312, 4));
					_sites.Add(new Site("Stora Essingen", 9811, 59.324766687715886, 17.993041276931763, 4));
					_sites.Add(new Site("Gröndal", 1605, 59.31580668526209, 18.010443449020386, 4));
					_sites.Add(new Site("Trekanten", 1603, 59.31407517684315, 18.018372058868408, 4));
					_sites.Add(new Site("Liljeholmen", 9294, 59.310822713968925, 18.02454113960266, 4));
					_sites.Add(new Site("Årstadal", 9807, 59.30582295146178, 18.02552819252014, 4));
					_sites.Add(new Site("Årstaberg", 9531, 59.2994147332507, 18.02930474281311, 4));
					_sites.Add(new Site("Årstafältet", 1521, 59.29636903714818, 18.039711713790894, 4));
					_sites.Add(new Site("Valla torg", 1525, 59.29504878560735, 18.048434257507324, 4));
					_sites.Add(new Site("Linde", 1503, 59.29334498280576, 18.064184188842773, 4));
					_sites.Add(new Site("Globen", 9168, 59.29415032788101, 18.07647943496704, 4));
					_sites.Add(new Site("Gullmarsplan", 9189, 59.29944212136717, 18.08027744293213, 4));
					_sites.Add(new Site("Mårtensdal", 1555, 59.30272579672863, 18.088141679763794, 4));
					_sites.Add(new Site("Luma", 1552, 59.304174456814664, 18.095828890800476, 4));
					_sites.Add(new Site("Sickla kaj", 1550, 59.30285450815607, 18.103601932525635, 4));
					_sites.Add(new Site("Sickla udde", 9820, 59.30620904912501, 18.108880519866943, 4));

					#endregion
				}
				return _sites;
			}
		}
	
		public static List<Site> GetSites(int typeId)
		{
			return Sites.Where(item => item.TypeId == typeId).ToList();
		}
	}
}