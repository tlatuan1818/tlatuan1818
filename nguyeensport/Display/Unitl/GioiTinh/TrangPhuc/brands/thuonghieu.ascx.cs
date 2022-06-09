using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace nguyeensport.Display.Unitl.GioiTinh.TrangPhuc.brands
{
    public partial class thuonghieu : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string brands = Page.RouteData.Values["brands"] as string;
            string gioitinh = Page.RouteData.Values["gioitinh"] as string;
            string trangphuc = Page.RouteData.Values["trangphuc"] as string;
            if (gioitinh == "nam")
            {
                if(trangphuc == "ao")
                {
                    if (brands == "adidas")
                    {
                        ltCM.Text = "CM";
                        ltTableSize.Text = "<table class='size-guide-measurements__table'>"+
                                "<thead>"+
    
                                    "<tr>"+
    
                                    "<th class='size-guide-table-lead-column'>Size</th>"+
                                    "<th class=''>XS</th>"+
                                    "<th class=''>S</th>"+
                                    "<th class=''>M</th>"+
                                    "<th class=''>L</th>"+
                                    "<th class=''>XL</th>"+
                                    "<th class=''>2XL</th>"+
                                    "<th class=''>3XL</th>"+
                                "</tr>"+
                            "</thead>"+
                            "<tbody>"+
                                "<tr>"+
                                    "<th class='size-guide-table-lead-column'>Ngực</th>"+
                                    "<td>78.7 - 83.8</td>"+
                                    "<td>86.3 - 93.9</td>"+
                                    "<td>94 - 101.6</td>"+
                                    "<td>101.6 - 111.7</td>"+
                                    "<td>111.7 - 121.9</td>"+
                                    "<td>121.9 - 132.1</td>"+
                                    "<td>134.6 - 147.3</td>"+ 
                                "</tr>"+
                                "<tr>"+
                                    "<th class='size-guide-table-lead-column'>Eo</th>"+
                                    "<td>68.6 - 73.6</td>"+
                                    "<td>76.2 - 81.3</td>"+
                                    "<td>81.3 - 88.9</td>"+
                                    "<td>88.9 - 99.1</td>"+
                                    "<td>99.1 - 109.2</td>"+
                                    "<td>109.2 - 119.4</td>"+
                                    "<td>121.9 - 134.6</td>"+
                                "</tr>"+
                                "<tr>"+
                                    "<th class='size-guide-table-lead-column'>Hông</th>"+
                                    "<td>81.3 - 86.4</td>"+
                                    "<td>88.9 - 93.9</td>"+
                                    "<td>94 - 101.6</td>"+
                                    "<td>101.6 - 111.7</td>"+
                                    "<td>111.7 - 121.9</td>"+
                                    "<td>121.9 - 129.5</td>"+
                                    "<td>129.5 - 142.3</td>"+
                                "</tr>"+
                            "</tbody>"+
                        "</table>";
                    }
                    else if (brands == "nike")
                    {
                        ltCM.Text = "CM";
                        ltTableSize.Text = "<table class='size-guide-measurements__table'>" +
                               "<thead>" +

                                   "<tr>" +

                                   "<th class='size-guide-table-lead-column'>Size</th>" +
                                   "<th class=''>XS</th>" +
                                   "<th class=''>S</th>" +
                                   "<th class=''>M</th>" +
                                   "<th class=''>L</th>" +
                                   "<th class=''>XL</th>" +
                                   "<th class=''>2XL</th>" +
                                   "<th class=''>3XL</th>" +
                               "</tr>" +
                           "</thead>" +
                           "<tbody>" +
                               "<tr>" +
                                   "<th class='size-guide-table-lead-column'>Ngực</th>" +
                                   "<td><88</td>" +
                                   "<td>88 - 96</td>" +
                                   "<td>96 - 104</td>" +
                                   "<td>104 - 112</td>" +
                                   "<td>112 - 124</td>" +
                                   "<td>124 - 136</td>" +
                                   "<td>136 - 148</td>" +
                               "</tr>" +
                               "<tr>" +
                                   "<th class='size-guide-table-lead-column'>Eo</th>" +
                                   "<td><73</td>" +
                                   "<td>73 - 81</td>" +
                                   "<td>81 - 89</td>" +
                                   "<td>89 - 97</td>" +
                                   "<td>97 - 109</td>" +
                                   "<td>109 - 121</td>" +
                                   "<td>121 - 133</td>" +
                               "</tr>" +
                               "<tr>" +
                                   "<th class='size-guide-table-lead-column'>Hông</th>" +
                                   "<td><88</td>" +
                                   "<td>88 - 96</td>" +
                                   "<td>96 - 104</td>" +
                                   "<td>104 - 112</td>" +
                                   "<td>112 - 120</td>" +
                                   "<td>120 - 128</td>" +
                                   "<td>128 - 136</td>" +
                               "</tr>" +
                           "</tbody>" +
                       "</table>";
                    }
                    else if (brands == "puma")
                    {
                        ltCM.Text = "CM";
                        ltTableSize.Text = "<table class='size-guide-measurements__table'>" +
                               "<thead>" +

                                   "<tr>" +

                                   "<th class='size-guide-table-lead-column'>Size</th>" +
                                   "<th class=''>XXS</th>" +
                                   "<th class=''>XS</th>" +
                                   "<th class=''>S</th>" +
                                   "<th class=''>M</th>" +
                                   "<th class=''>L</th>" +
                                   "<th class=''>XL</th>" +
                                   "<th class=''>2XL</th>" +
                                   "<th class=''>3XL</th>" +
                               "</tr>" +
                           "</thead>" +
                           "<tbody>" +
                               "<tr>" +
                                   "<th class='size-guide-table-lead-column'>Ngực</th>" +
                                   "<td>76</td>" +
                                   "<td>76</td>" +
                                   "<td>91.5</td>" +
                                   "<td>99</td>" +
                                   "<td>106.5</td>" +
                                   "<td>114.5</td>" +
                                   "<td>122</td>" +
                                   "<td>124.5</td>" +
                               "</tr>" +
                               
                               "<tr>" +
                                   "<th class='size-guide-table-lead-column'>Hông</th>" +
                                   "<td>65</td>" +
                                   "<td>84</td>" +
                                   "<td>81.5</td>" +
                                   "<td>86.5</td>" +
                                   "<td>94</td>" +
                                   "<td>104</td>" +
                                   "<td>114.5</td>" +
                                   "<td>124.5</td>" +
                               "</tr>" +
                           "</tbody>" +
                       "</table>";
                    }
                    else if (brands == "mizuno")
                    {
                        ltCM.Text = "CM";
                        ltTableSize.Text = "<table class='size-guide-measurements__table'>" +
                                "<thead>" +

                                    "<tr>" +

                                    "<th class='size-guide-table-lead-column'>Size</th>" +
                                    
                                    "<th class=''>S</th>" +
                                    "<th class=''>M</th>" +
                                    "<th class=''>L</th>" +
                                    "<th class=''>XL</th>" +
                                    "<th class=''>2XL</th>" +
                                    
                                "</tr>" +
                            "</thead>" +
                            "<tbody>" +
                                "<tr>" +
                                    "<th class='size-guide-table-lead-column'>Ngực</th>" +
                                    
                                    "<td>89 - 96</td>" +
                                    "<td>97 - 104</td>" +
                                    "<td>105 - 112</td>" +
                                    "<td>113 - 120</td>" +
                                    "<td>121 - 127</td>" +
                                    
                                "</tr>" +
                                "<tr>" +
                                    "<th class='size-guide-table-lead-column'>Eo</th>" +
                                   
                                    "<td>73 - 80</td>" +
                                    "<td>81 - 88</td>" +
                                    "<td>89 - 96</td>" +
                                    "<td>97 - 104</td>" +
                                    "<td>105 - 111</td>" +
                                    
                                "</tr>" +
                                "<tr>" +
                                    "<th class='size-guide-table-lead-column'>Hông</th>" +

                                     "<td>89 - 96</td>" +
                                    "<td>97 - 104</td>" +
                                    "<td>105 - 112</td>" +
                                    "<td>113 - 120</td>" +
                                    "<td>121 - 127</td>" +

                                "</tr>" +
                            "</tbody>" +
                        "</table>";
                    }
                    else if (brands == "newbalance")
                    {
                        ltCM.Text = "CM";
                        ltTableSize.Text = "<table class='size-guide-measurements__table'>" +
                                "<thead>" +

                                    "<tr>" +

                                    "<th class='size-guide-table-lead-column'>Size</th>" +
                                    "<th class=''>XS</th>" +
                                    "<th class=''>S</th>" +
                                    "<th class=''>M</th>" +
                                    "<th class=''>L</th>" +
                                    "<th class=''>XL</th>" +
                                    "<th class=''>2XL</th>" +
                                    "<th class=''>3XL</th>" +
                                "</tr>" +
                            "</thead>" +
                            "<tbody>" +
                                "<tr>" +
                                    "<th class='size-guide-table-lead-column'>Ngực</th>" +
                                    "<td>83 - 89</td>" +
                                    "<td>89 - 96</td>" +
                                    "<td>96 - 104</td>" +
                                    "<td>104 - 111</td>" +
                                    "<td>111 - 121</td>" +
                                    "<td>121 - 134</td>" +
                                    "<td>134 - 144</td>" +
                                "</tr>" +
                                "<tr>" +
                                    "<th class='size-guide-table-lead-column'>Eo</th>" +
                                    "<td>68 - 74</td>" +
                                    "<td>74 - 78</td>" +
                                    "<td>78 - 86</td>" +
                                    "<td>86 - 93</td>" +
                                    "<td>93 - 104</td>" +
                                    "<td>104 - 116</td>" +
                                    "<td>116 - 127</td>" +
                                "</tr>" +
                                "<tr>" +
                                    "<th class='size-guide-table-lead-column'>Hông</th>" +
                                    "<td>81 - 86</td>" +
                                    "<td>86 - 93</td>" +
                                    "<td>93 - 101</td>" +
                                    "<td>101 - 109</td>" +
                                    "<td>109 - 116</td>" +
                                    "<td>116 - 127</td>" +
                                    "<td>127 - 137</td>" +
                                "</tr>" +
                            "</tbody>" +
                        "</table>";
                    }
                    else if (brands == "asics")
                    {
                        ltCM.Text = "IN";
                        ltTableSize.Text = "<table class='size-guide-measurements__table'>" +
                                                      "<thead>" +

                                                          "<tr>" +

                                                          "<th class='size-guide-table-lead-column'>Size</th>" +
                                                          "<th class=''>XS</th>" +
                                                          "<th class=''>S</th>" +
                                                          "<th class=''>M</th>" +
                                                          "<th class=''>L</th>" +
                                                          "<th class=''>XL</th>" +
                                                         
                                                      "</tr>" +
                                                  "</thead>" +
                                                  "<tbody>" +
                                                      "<tr>" +
                                                          "<th class='size-guide-table-lead-column'>Ngực</th>" +
                                                          "<td>33-36</td>" +
                                                          "<td>36-39</td>" +
                                                          "<td>39-41</td>" +
                                                          "<td>41-43</td>" +
                                                          "<td>43-46</td>" +
                                                      "</tr>" +
                                                  "</tbody>" +
                                              "</table>";
                    }
                    else if (brands == "kamito")
                    {
                        ltCM.Text = "CM";
                        ltTableSize.Text = "<table class='size-guide-measurements__table'>" +
                                "<thead>" +

                                    "<tr>" +

                                    "<th class='size-guide-table-lead-column'>Size</th>" +
                                   
                                    "<th class=''>S</th>" +
                                    "<th class=''>M</th>" +
                                    "<th class=''>L</th>" +
                                    "<th class=''>XL</th>" +
                                    "<th class=''>2XL</th>" +
                                    
                                "</tr>" +
                            "</thead>" +
                            "<tbody>" +
                                "<tr>" +
                                    "<th class='size-guide-table-lead-column'>Chiều cao</th>" +
                                    "<td>160 - 165</td>" +
                                    "<td>165 - 170</td>" +
                                    "<td>170 - 175</td>" +
                                    "<td>175 - 180</td>" +
                                    "<td>180 - 185</td>" +
                                    
                                "</tr>" +
                                "<tr>" +
                                    "<th class='size-guide-table-lead-column'>Cân năng</th>" +
                                    "<td>50 - 60 KG</td>" +
                                    "<td>60 - 65 KG</td>" +
                                    "<td>65 - 70 KG</td>" +
                                    "<td>70 - 80 KG</td>" +
                                    "<td>80 - 90 KG</td>" +
                                  
                                "</tr>" +
                            "</tbody>" +
                        "</table>";
                    }
                }
                else if(trangphuc == "giay-bong-da")
                {
                    if (brands == "adidas")
                    {
                        ltCM.Text = "CM";
                        ltTableSize.Text = "<table class='size-guide-measurements__table'>" +
                                "<thead>" +

                                    "<tr>" +

                                    "<th class='size-guide-table-lead-column'>Size</th>" +
                                    "<th class=''>4</th>" +
                                    "<th class=''>4.5</th>" +
                                    "<th class=''>5</th>" +
                                    "<th class=''>5.5</th>" +
                                    "<th class=''>6</th>" +
                                    "<th class=''>6.5</th>" +
                                    "<th class=''>7</th>" +
                                    "<th class=''>7.5</th>" +
                                    "<th class=''>8</th>" +
                                    "<th class=''>8.5</th>" +
                                    "<th class=''>9</th>" +
                                    "<th class=''>9.5</th>" +
                                    "<th class=''>10</th>" +
                                    "<th class=''>10.5</th>" +
                                    "<th class=''>11</th>" +
                                "</tr>" +
                            "</thead>" +
                            "<tbody>" +
                                "<tr>" +
                                    "<th class='size-guide-table-lead-column'>Chiều dài bàn chân</th>" +
                                    "<td>22.5</td>" +
                                    "<td>22.9</td>" +
                                    "<td>23.3</td>" +
                                    "<td>23.8</td>" +
                                    "<td>24.2</td>" +
                                    "<td>24.6</td>" +
                                    "<td>25</td>" +
                                    "<td>25.5</td>" +
                                    "<td>25.9</td>" +
                                    "<td>26.3</td>" +
                                    "<td>26.7</td>" +
                                    "<td>27.1</td>" +
                                    "<td>27.6</td>" +
                                    "<td>28</td>" +
                                    "<td>28.4</td>" +
                                "</tr>" +
                                "<tr>" +
                                    "<th class='size-guide-table-lead-column'>UK</th>" +
                                    "<td class=''>4</td>" +
                                    "<td class=''>4.5</td>" +
                                    "<td class=''>5</td>" +
                                    "<td class=''>5.5</td>" +
                                    "<td class=''>6</td>" +
                                    "<td class=''>6.5</td>" +
                                    "<td class=''>7</td>" +
                                    "<td class=''>7.5</td>" +
                                    "<td class=''>8</td>" +
                                    "<td class=''>8.5</td>" +
                                    "<td class=''>9</td>" +
                                    "<td class=''>9.5</td>" +
                                    "<td class=''>10</td>" +
                                    "<td class=''>10.5</td>" +
                                    "<td class=''>11</td>" +
                                "</tr>" +
                                "<tr>" +
                                    "<th class='size-guide-table-lead-column'>EU</th>" +
                                    "<td class=''>36.66</td>" +
                                    "<td class=''>37.33</td>" +
                                    "<td class=''>38</td>" +
                                    "<td class=''>38.66</td>" +
                                    "<td class=''>39.33</td>" +
                                    "<td class=''>40</td>" +
                                    "<td class=''>40.66</td>" +
                                    "<td class=''>41.33</td>" +
                                    "<td class=''>42</td>" +
                                    "<td class=''>42.66</td>" +
                                    "<td class=''>43.33</td>" +
                                    "<td class=''>44</td>" +
                                    "<td class=''>44.66</td>" +
                                    "<td class=''>45.33</td>" +
                                    "<td class=''>46</td>" +
                                "</tr>" +
                                "<tr>" +
                                    "<th class='size-guide-table-lead-column'>US</th>" +
                                    "<td class=''>4.5</td>" +
                                    "<td class=''>5</td>" +
                                    "<td class=''>5.5</td>" +
                                    "<td class=''>6</td>" +
                                    "<td class=''>6.5</td>" +
                                    "<td class=''>7</td>" +
                                    "<td class=''>7.5</td>" +
                                    "<td class=''>8</td>" +
                                    "<td class=''>8.5</td>" +
                                    "<td class=''>9</td>" +
                                    "<td class=''>9.5</td>" +
                                    "<td class=''>10</td>" +
                                    "<td class=''>10.5</td>" +
                                    "<td class=''>11</td>" +
                                    "<td class=''>11.5</td>" +
                                "</tr>" +
                            "</tbody>" +
                        "</table>";
                    }
                    else if (brands == "nike")
                    {
                        ltCM.Text = "CM";
                        ltTableSize.Text = "<table class='size-guide-measurements__table'>" +
                               "<thead>" +

                                   "<tr>" +

                                   "<th class='size-guide-table-lead-column'>Size</th>" +
                                    "<th class=''>4</th>" +
                                    "<th class=''>4.5</th>" +
                                    "<th class=''>5</th>" +
                                    "<th class=''>5.5</th>" +
                                    "<th class=''>6</th>" +
                                    "<th class=''>6.5</th>" +
                                    "<th class=''>7</th>" +
                                    "<th class=''>7.5</th>" +
                                    "<th class=''>8</th>" +
                                    "<th class=''>8.5</th>" +
                                    "<th class=''>9</th>" +
                                    "<th class=''>9.5</th>" +
                                    "<th class=''>10</th>" +
                                    "<th class=''>10.5</th>" +
                                    "<th class=''>11</th>" +
                               "</tr>" +
                           "</thead>" +
                           "<tbody>" +
                               "<tr>" +
                                  "<th class='size-guide-table-lead-column'>Chiều dài bàn chân</th>" +
                                    "<td>22.4</td>" +
                                    "<td>22.9</td>" +
                                    "<td>23.3</td>" +
                                    "<td>23.7</td>" +
                                    
                                    "<td>25</td>" +
                                    "<td>25.5</td>" +
                                    "<td>26</td>" +
                                    "<td>26.5</td>" +
                                    "<td>27</td>" +
                                    "<td>27.5</td>" +
                                    "<td>28</td>" +
                                    "<td>28.5</td>" +
                                    "<td>29</td>" +
                                    "<td>29.5</td>" +
                                    "<td>30</td>" +
                               "</tr>" +
                               "<tr>" +
                                   "<th class='size-guide-table-lead-column'>UK</th>" +
                                    "<td class=''>4</td>" +
                                    "<td class=''>4.5</td>" +
                                    "<td class=''>5</td>" +
                                    "<td class=''>5.5</td>" +
                                    "<td class=''>6</td>" +
                                    "<td class=''>6.5</td>" +
                                    "<td class=''>7</td>" +
                                    "<td class=''>7.5</td>" +
                                    "<td class=''>8</td>" +
                                    "<td class=''>8.5</td>" +
                                    "<td class=''>9</td>" +
                                    "<td class=''>9.5</td>" +
                                    "<td class=''>10</td>" +
                                    "<td class=''>10.5</td>" +
                                    "<td class=''>11</td>" +
                               "</tr>" +
                               "<tr>" +
                                    "<th class='size-guide-table-lead-column'>EU</th>" +
                                    "<td class=''>36.5</td>" +
                                    
                                    "<td class=''>37.5</td>" +
                                    "<td class=''>38</td>" +
                                    
                                    "<td class=''>39</td>" +
                                    "<td class=''>40</td>" +
                                    "<td class=''>40.5</td>" +
                                    "<td class=''>41</td>" +
                                    "<td class=''>42</td>" +
                                    "<td class=''>42.5</td>" +
                                    "<td class=''>43</td>" +
                                    "<td class=''>44</td>" +
                                    "<td class=''>44.5</td>" +
                                    "<td class=''>45</td>" +
                                    "<td class=''>45.5</td>" +
                                    "<td class=''>46</td>" +
                               "</tr>" +
                                "<tr>" +
                                    "<th class='size-guide-table-lead-column'>US</th>" +
                                    "<td class=''>4.5</td>" +
                                    "<td class=''>5</td>" +
                                    "<td class=''>5.5</td>" +
                                    "<td class=''>6</td>" +
                                    "<td class=''>6.5</td>" +
                                    "<td class=''>7</td>" +
                                    "<td class=''>7.5</td>" +
                                    "<td class=''>8</td>" +
                                    "<td class=''>8.5</td>" +
                                    "<td class=''>9</td>" +
                                    "<td class=''>9.5</td>" +
                                    "<td class=''>10</td>" +
                                    "<td class=''>10.5</td>" +
                                    "<td class=''>11</td>" +
                                    "<td class=''>11.5</td>" +
                                    
                                    
                               "</tr>" +
                           "</tbody>" +
                       "</table>";
                    }
                    else if (brands == "puma")
                    {
                        ltCM.Text = "CM";
                        ltTableSize.Text = "<table class='size-guide-measurements__table'>" +
                               "<thead>" +

                                   "<tr>" +

                                    "<th class='size-guide-table-lead-column'>Size</th>" +
                                    "<th class=''>5</th>" +
                                    "<th class=''>5.5</th>" +
                                    "<th class=''>6</th>" +
                                    "<th class=''>6.5</th>" +
                                    "<th class=''>7</th>" +
                                    "<th class=''>7.5</th>" +
                                    "<th class=''>8</th>" +
                                    "<th class=''>8.5</th>" +
                                    "<th class=''>9</th>" +
                                    "<th class=''>9.5</th>" +
                                    "<th class=''>10</th>" +
                                    "<th class=''>10.5</th>" +
                                    "<th class=''>11</th>" +
                               "</tr>" +
                           "</thead>" +
                           "<tbody>" +
                               "<tr>" +
                                   "<th class='size-guide-table-lead-column'>Chiều dài bàn chân</th>" +
                                    "<td>24</td>" +
                                    "<td>24.5</td>" +
                                    "<td>25</td>" +
                                    "<td>25.5</td>" +

                                    "<td>26</td>" +
                                    "<td>26.5</td>" +
                                    "<td>27</td>" +
                                    "<td>27.5</td>" +
                                    "<td>28</td>" +
                                    "<td>28.5</td>" +
                                    "<td>29</td>" +
                                    "<td>29.5</td>" +
                                    "<td>30</td>" +
                               "</tr>" +

                               "<tr>" +
                                   "<th class='size-guide-table-lead-column'>UK</th>" +
                                   
                                    "<td class=''>5</td>" +
                                    "<td class=''>5.5</td>" +
                                    "<td class=''>6</td>" +
                                    "<td class=''>6.5</td>" +
                                    "<td class=''>7</td>" +
                                    "<td class=''>7.5</td>" +
                                    "<td class=''>8</td>" +
                                    "<td class=''>8.5</td>" +
                                    "<td class=''>9</td>" +
                                    "<td class=''>9.5</td>" +
                                    "<td class=''>10</td>" +
                                    "<td class=''>10.5</td>" +
                                    "<td class=''>11</td>" +
                               "</tr>" +
                               "<tr>" +
                                    "<th class='size-guide-table-lead-column'>EU</th>" +
                                   
                                    "<td class=''>38</td>" +
                                    "<td class=''>38.5</td>" +
                                    "<td class=''>39</td>" +
                                    "<td class=''>40</td>" +
                                    "<td class=''>40.5</td>" +
                                    "<td class=''>41</td>" +
                                    "<td class=''>42</td>" +
                                    "<td class=''>42.5</td>" +
                                    "<td class=''>43</td>" +
                                    "<td class=''>44</td>" +
                                    "<td class=''>44.5</td>" +
                                    "<td class=''>45</td>" +
                                    
                                    "<td class=''>46</td>" +
                               "</tr>" +
                               "<tr>" +
                                    "<th class='size-guide-table-lead-column'>US</th>" +
                                    "<td class=''>6</td>" +
                                    "<td class=''>6.5</td>" +
                                    "<td class=''>7</td>" +
                                    "<td class=''>7.5</td>" +
                                    "<td class=''>8</td>" +
                                    "<td class=''>8.5</td>" +
                                    "<td class=''>9</td>" +
                                    "<td class=''>9.5</td>" +
                                    "<td class=''>10</td>" +
                                    "<td class=''>10.5</td>" +
                                    "<td class=''>11</td>" +
                                    "<td class=''>11.5</td>" +
                                    "<td class=''>12</td>" +
                               "</tr>" +
                           "</tbody>" +
                       "</table>";
                    }
                    else if (brands == "mizuno")
                    {
                        ltCM.Text = "";
                        ltTableSize.Text = "<table class='size-guide-measurements__table'>" +
                                "<thead>" +

                                    "<tr>" +

                                    "<th class='size-guide-table-lead-column'>Size</th>" +
                                    "<th class=''>6</th>" +
                                    "<th class=''>6.5</th>" +
                                    "<th class=''>7</th>" +
                                    "<th class=''>7.5</th>" +
                                    "<th class=''>8</th>" +
                                    "<th class=''>8.5</th>" +
                                    "<th class=''>9</th>" +
                                    "<th class=''>9.5</th>" +
                                    "<th class=''>10</th>" +
                                    "<th class=''>10.5</th>" +
                                    "<th class=''>11</th>" +
                                "</tr>" +
                            "</thead>" +
                            "<tbody>" +
                                "<tr>" +
                                   "<th class='size-guide-table-lead-column'>UK</th>" +

                                    
                                    "<td class=''>6</td>" +
                                    "<td class=''>6.5</td>" +
                                    "<td class=''>7</td>" +
                                    "<td class=''>7.5</td>" +
                                    "<td class=''>8</td>" +
                                    "<td class=''>8.5</td>" +
                                    "<td class=''>9</td>" +
                                    "<td class=''>9.5</td>" +
                                    "<td class=''>10</td>" +
                                    "<td class=''>10.5</td>" +
                                    "<td class=''>11</td>" +
                               "</tr>" +
                               "<tr>" +
                                    "<th class='size-guide-table-lead-column'>EU</th>" +

                                   
                                    "<td class=''>39</td>" +
                                    "<td class=''>40</td>" +
                                    "<td class=''>40.5</td>" +
                                    "<td class=''>41</td>" +
                                    "<td class=''>42</td>" +
                                    "<td class=''>42.5</td>" +
                                    "<td class=''>43</td>" +
                                    "<td class=''>44</td>" +
                                    "<td class=''>44.5</td>" +
                                    "<td class=''>45</td>" +

                                    "<td class=''>46</td>" +
                               "</tr>" +
                               "<tr>" +
                                    "<th class='size-guide-table-lead-column'>US</th>" +
                                    
                                    "<td class=''>7</td>" +
                                    "<td class=''>7.5</td>" +
                                    "<td class=''>8</td>" +
                                    "<td class=''>8.5</td>" +
                                    "<td class=''>9</td>" +
                                    "<td class=''>9.5</td>" +
                                    "<td class=''>10</td>" +
                                    "<td class=''>10.5</td>" +
                                    "<td class=''>11</td>" +
                                    "<td class=''>11.5</td>" +
                                    "<td class=''>12</td>" +
                               "</tr>" +
                            "</tbody>" +
                        "</table>";
                    }
                    else if (brands == "newbalance")
                    {
                        ltCM.Text = "";
                        ltTableSize.Text = "<table class='size-guide-measurements__table'>" +
                                "<thead>" +

                                    "<tr>" +

                                    "<th class='size-guide-table-lead-column'>Size</th>" +
                                    "<th class=''>6</th>" +
                                    "<th class=''>6.5</th>" +
                                    "<th class=''>7</th>" +
                                    "<th class=''>7.5</th>" +
                                    "<th class=''>8</th>" +
                                    "<th class=''>8.5</th>" +
                                    "<th class=''>9</th>" +
                                    "<th class=''>9.5</th>" +
                                    "<th class=''>10</th>" +
                                    "<th class=''>10.5</th>" +
                                    "<th class=''>11</th>" +
                                "</tr>" +
                            "</thead>" +
                            "<tbody>" +
                                "<tr>" +
                                    "<th class='size-guide-table-lead-column'>UK</th>" +


                                    "<td class=''>6</td>" +
                                    "<td class=''>6.5</td>" +
                                    "<td class=''>7</td>" +
                                    "<td class=''>7.5</td>" +
                                    "<td class=''>8</td>" +
                                    "<td class=''>8.5</td>" +
                                    "<td class=''>9</td>" +
                                    "<td class=''>9.5</td>" +
                                    "<td class=''>10</td>" +
                                    "<td class=''>10.5</td>" +
                                    "<td class=''>11</td>" +
                                "</tr>" +
                                "<tr>" +
                                    "<th class='size-guide-table-lead-column'>EU</th>" +


                                    "<td class=''>39</td>" +
                                    "<td class=''>40</td>" +
                                    "<td class=''>40.5</td>" +
                                    "<td class=''>41</td>" +
                                    "<td class=''>41.5</td>" +
                                    "<td class=''>42</td>" +
                                    "<td class=''>42.5</td>" +
                                    "<td class=''>43</td>" +
                                    "<td class=''>44</td>" +
                                    "<td class=''>44.5</td>" +
                                    "<td class=''>45</td>" +

                                    
                                "</tr>" +
                                "<tr>" +
                                    "<th class='size-guide-table-lead-column'>US</th>" +
                                   
                                    "<td class=''>6.5</td>" +
                                    "<td class=''>7</td>" +
                                    "<td class=''>7.5</td>" +
                                    "<td class=''>8</td>" +
                                    "<td class=''>8.5</td>" +
                                    "<td class=''>9</td>" +
                                    "<td class=''>9.5</td>" +
                                    "<td class=''>10</td>" +
                                    "<td class=''>10.5</td>" +
                                    "<td class=''>11</td>" +
                                    "<td class=''>11.5</td>" +
                                    
                               "</tr>" +
                            "</tbody>" +
                        "</table>";
                    }
                    else if (brands == "asics")
                    {
                        ltCM.Text = "";
                        ltTableSize.Text = "<table class='size-guide-measurements__table'>" +
                                 "<thead>" +

                                     "<tr>" +

                                     "<th class='size-guide-table-lead-column'>Size</th>" +
                                     "<th class=''>6</th>" +
                                     "<th class=''>6.5</th>" +
                                     "<th class=''>7</th>" +
                                     "<th class=''>7.5</th>" +
                                     "<th class=''>8</th>" +
                                     "<th class=''>8.5</th>" +
                                     "<th class=''>9</th>" +
                                     "<th class=''>9.5</th>" +
                                     "<th class=''>10</th>" +
                                     "<th class=''>10.5</th>" +
                                     "<th class=''>11</th>" +
                                 "</tr>" +
                             "</thead>" +
                             "<tbody>" +
                                 "<tr>" +
                                    "<th class='size-guide-table-lead-column'>UK</th>" +


                                     "<td class=''>6</td>" +
                                     "<td class=''>6.5</td>" +
                                     "<td class=''>7</td>" +
                                     "<td class=''>7.5</td>" +
                                     "<td class=''>8</td>" +
                                     "<td class=''>8.5</td>" +
                                     "<td class=''>9</td>" +
                                     "<td class=''>9.5</td>" +
                                     "<td class=''>10</td>" +
                                     "<td class=''>10.5</td>" +
                                     "<td class=''>11</td>" +
                                "</tr>" +
                                "<tr>" +
                                     "<th class='size-guide-table-lead-column'>EU</th>" +


                                    
                                     "<td class=''>40</td>" +
                                     "<td class=''>40.5</td>" +
                                     "<td class=''>41.5</td>" +
                                     "<td class=''>42</td>" +
                                     "<td class=''>42.5</td>" +
                                     "<td class=''>43.5</td>" +
                                     "<td class=''>44</td>" +
                                     "<td class=''>44.5</td>" +
                                     "<td class=''>45</td>" +

                                     "<td class=''>46</td>" +
                                     "<td class=''>46.5</td>" +
                                "</tr>" +
                                "<tr>" +
                                     "<th class='size-guide-table-lead-column'>US</th>" +

                                     "<td class=''>7</td>" +
                                     "<td class=''>7.5</td>" +
                                     "<td class=''>8</td>" +
                                     "<td class=''>8.5</td>" +
                                     "<td class=''>9</td>" +
                                     "<td class=''>9.5</td>" +
                                     "<td class=''>10</td>" +
                                     "<td class=''>10.5</td>" +
                                     "<td class=''>11</td>" +
                                     "<td class=''>11.5</td>" +
                                     "<td class=''>12</td>" +
                                "</tr>" +
                             "</tbody>" +
                         "</table>";
                    }
                    else if (brands == "kamito")
                    {
                        ltCM.Text = "CM";
                        ltTableSize.Text = "<table class='size-guide-measurements__table'>" +
                                "<thead>" +

                                    "<tr>" +

                                    "<th class='size-guide-table-lead-column'>CM</th>" +
                                    "<th class=''>18</th>" +
                                    "<th class=''>19</th>" +
                                    "<th class=''>19.5</th>" +
                                    "<th class=''>20.5</th>" +
                                    "<th class=''>21</th>" +
                                    "<th class=''>22</th>" +
                                    "<th class=''>22.5</th>" +
                                    "<th class=''>23.5</th>" +
                                    "<th class=''>24</th>" +
                                    "<th class=''>25</th>" +
                                    "<th class=''>25.5</th>" +
                                    "<th class=''>26.5</th>" +
                                    "<th class=''>27</th>" +
                                    "<th class=''>28</th>" +
                                "</tr>" +
                            "</thead>" +
                            "<tbody>" +
                            "<tr>" +
                                  "<th class='size-guide-table-lead-column'>EU</th>" +
                                    "<td>30</td>" +
                                    "<td>31</td>" +
                                    "<td>32</td>" +
                                    "<td>33</td>" +

                                    "<td>34</td>" +
                                    "<td>35</td>" +
                                    "<td>36</td>" +
                                    "<td>37</td>" +
                                    "<td>38</td>" +
                                    "<td>39</td>" +
                                    "<td>40</td>" +
                                    "<td>41</td>" +
                                    "<td>42</td>" +
                                    "<td>43</td>" +
                                    
                               "</tr>" +
                                "<tr>" +
                                    "<th class='size-guide-table-lead-column'>UK</th>" +


                                    "<td class=''>C12</td>" +
                                    "<td class=''>C13</td>" +
                                    "<td class=''>C13.5</td>" +
                                    "<td class=''>1.5</td>" +
                                    "<td class=''>2</td>" +
                                    "<td class=''>3</td>" +
                                    "<td class=''>3.5</td>" +
                                    "<td class=''>4.5</td>" +
                                    "<td class=''>5</td>" +
                                    "<td class=''>6</td>" +
                                    "<td class=''>6.5</td>" +
                                    "<td class=''>7.5</td>" +
                                    "<td class=''>8</td>" +
                                    "<td class=''>9</td>" +
                                "</tr>" +
                                "<tr>" +
                                    "<th class='size-guide-table-lead-column'>JAPAN</th>" +
                                    "<td class=''>18</td>" +
                                    "<td class=''>19</td>" +
                                    "<td class=''>19.5</td>" +
                                    "<td class=''>20.5</td>" +
                                    "<td class=''>21</td>" +
                                    "<td class=''>22</td>" +
                                    "<td class=''>22.5</td>" +
                                    "<td class=''>23.5</td>" +
                                    "<td class=''>24</td>" +
                                    "<td class=''>25</td>" +
                                    "<td class=''>25.5</td>" +
                                    "<td class=''>26.5</td>" +
                                    "<td class=''>27</td>" +
                                    "<td class=''>28</td>" +
                                "</tr>" +
                                
                            "</tbody>" +
                        "</table>";
                    }
                }
                else if(trangphuc == "quan")
                {
                    if (brands == "adidas")
                    {
                        ltCM.Text = "CM";
                        ltTableSize.Text = "<table class='size-guide-measurements__table'>" +
                                "<thead>" +

                                    "<tr>" +

                                    "<th class='size-guide-table-lead-column'>Size</th>" +
                                    "<th class=''>XS</th>" +
                                    "<th class=''>S</th>" +
                                    "<th class=''>M</th>" +
                                    "<th class=''>L</th>" +
                                    "<th class=''>XL</th>" +
                                    "<th class=''>2XL</th>" +
                                    "<th class=''>3XL</th>" +
                                "</tr>" +
                            "</thead>" +
                            "<tbody>" +
                                "<tr>" +
                                    "<th class='size-guide-table-lead-column'>Thắt lưng</th>" +
                                    "<td>68.6 - 73.6</td>" +
                                    "<td>76.2 - 81.3</td>" +
                                    "<td>81.3 - 88.9</td>" +
                                    "<td>88.9 - 99.1</td>" +
                                    "<td>99.1 - 109.2</td>" +
                                    "<td>109.2 - 119.4</td>" +
                                    "<td>121.9 - 134.6</td>" +
                                "</tr>" +
                                "<tr>" +
                                    "<th class='size-guide-table-lead-column'>Hông</th>" +
                                    "<td>81.3 - 86.4</td>" +
                                    "<td>88.9 - 93.9</td>" +
                                    "<td>94 - 101.6</td>" +
                                    "<td>101.6 - 111.7</td>" +
                                    "<td>111.7 - 121.9</td>" +
                                    "<td>121.9 - 129.5</td>" +
                                    "<td>129.5 - 142.3</td>" +
                                "</tr>" +
                                "<tr>" +
                                    "<th class='size-guide-table-lead-column'>Chiều cao háng</th>" +
                                    "<td>78.7</td>" +
                                    "<td>81.3</td>" +
                                    "<td>81.3</td>" +
                                    "<td>81.3</td>" +
                                    "<td>81.3</td>" +
                                    "<td>81.3</td>" +
                                    "<td>81.3</td>" +
                                "</tr>" +
                            "</tbody>" +
                        "</table>";
                    }
                    else if (brands == "nike")
                    {
                        ltCM.Text = "CM";
                        ltTableSize.Text = "<table class='size-guide-measurements__table'>" +
                               "<thead>" +

                                   "<tr>" +

                                   "<th class='size-guide-table-lead-column'>Size</th>" +
                                   "<th class=''>XS</th>" +
                                   "<th class=''>S</th>" +
                                   "<th class=''>M</th>" +
                                   "<th class=''>L</th>" +
                                   "<th class=''>XL</th>" +
                                   "<th class=''>2XL</th>" +
                                   "<th class=''>3XL</th>" +
                               "</tr>" +
                           "</thead>" +
                           "<tbody>" +
                               "<tr>" +
                                   "<th class='size-guide-table-lead-column'>Thắt lưng</th>" +
                                   "<td><73</td>" +
                                   "<td>73 - 81</td>" +
                                   "<td>81 - 89</td>" +
                                   "<td>89 - 97</td>" +
                                   "<td>97 - 109</td>" +
                                   "<td>109 - 121</td>" +
                                   "<td>121 - 133</td>" +
                               "</tr>" +
                               "<tr>" +
                                   "<th class='size-guide-table-lead-column'>Hông</th>" +
                                   "<td><88</td>" +
                                   "<td>88 - 96</td>" +
                                   "<td>96 - 104</td>" +
                                   "<td>104 - 112</td>" +
                                   "<td>112 - 120</td>" +
                                   "<td>120 - 128</td>" +
                                   "<td>128 - 136</td>" +
                               "</tr>" +
                               "<tr>" +
                                   "<th class='size-guide-table-lead-column'>Chiều cao háng</th>" +
                                   "<td>82</td>" +
                                   "<td>82.5</td>" +
                                   "<td>83</td>" +
                                   "<td>83.5</td>" +
                                   "<td>84</td>" +
                                   "<td>84.5</td>" +
                                   "<td>85</td>" +
                               "</tr>" +
                           "</tbody>" +
                       "</table>";
                    }
                    else if (brands == "puma")
                    {
                        ltCM.Text = "CM";
                        ltTableSize.Text = "<table class='size-guide-measurements__table'>" +
                               "<thead>" +

                                   "<tr>" +

                                   "<th class='size-guide-table-lead-column'>Size</th>" +
                                   "<th class=''>XXS</th>" +
                                   "<th class=''>XS</th>" +
                                   "<th class=''>S</th>" +
                                   "<th class=''>M</th>" +
                                   "<th class=''>L</th>" +
                                   "<th class=''>XL</th>" +
                                   "<th class=''>2XL</th>" +
                                   "<th class=''>3XL</th>" +
                               "</tr>" +
                           "</thead>" +
                           "<tbody>" +
                               "<tr>" +
                                   "<th class='size-guide-table-lead-column'>Thắt lưng</th>" +
                                   "<td>68.5</td>" +
                                   "<td>76</td>" +
                                   "<td>81.5</td>" +
                                   "<td>86.5</td>" +
                                   "<td>94</td>" +
                                   "<td>104</td>" +
                                   "<td>114.5</td>" +
                                   "<td>124.5</td>" +
                               "</tr>" +

                               "<tr>" +
                                   "<th class='size-guide-table-lead-column'>Chiều cao háng</th>" +
                                   "<td>77.5</td>" +
                                   "<td>78.5</td>" +
                                   "<td>80</td>" +
                                   "<td>81.5</td>" +
                                   "<td>81.5</td>" +
                                   "<td>82.5</td>" +
                                   "<td>84</td>" +
                                   "<td>85</td>" +
                               "</tr>" +
                           "</tbody>" +
                       "</table>";
                    }
                    else if (brands == "mizuno")
                    {
                        ltCM.Text = "CM";
                        ltTableSize.Text = "<table class='size-guide-measurements__table'>" +
                                "<thead>" +

                                    "<tr>" +

                                    "<th class='size-guide-table-lead-column'>Size</th>" +

                                    "<th class=''>S</th>" +
                                    "<th class=''>M</th>" +
                                    "<th class=''>L</th>" +
                                    "<th class=''>XL</th>" +
                                    "<th class=''>2XL</th>" +

                                "</tr>" +
                            "</thead>" +
                            "<tbody>" +
                                "<tr>" +
                                    "<th class='size-guide-table-lead-column'>Thắt lưng</th>" +

                                    "<td>89 - 96</td>" +
                                    "<td>97 - 104</td>" +
                                    "<td>105 - 112</td>" +
                                    "<td>113 - 120</td>" +
                                    "<td>121 - 127</td>" +

                                "</tr>" +
                                "<tr>" +
                                    "<th class='size-guide-table-lead-column'>Chiều cao</th>" +

                                    "<td>170 - 175</td>" +
                                    "<td>175 - 180</td>" +
                                    "<td>180 - 185</td>" +
                                    "<td>185 - 190</td>" +
                                    "<td>190 - 195</td>" +

                                "</tr>" +
                            "</tbody>" +
                        "</table>";
                    }
                    else if (brands == "newbalance")
                    {
                        ltCM.Text = "CM";
                        ltTableSize.Text = "<table class='size-guide-measurements__table'>" +
                                "<thead>" +

                                    "<tr>" +

                                    "<th class='size-guide-table-lead-column'>Size</th>" +
                                    "<th class=''>XS</th>" +
                                    "<th class=''>S</th>" +
                                    "<th class=''>M</th>" +
                                    "<th class=''>L</th>" +
                                    "<th class=''>XL</th>" +
                                    "<th class=''>2XL</th>" +
                                    "<th class=''>3XL</th>" +
                                "</tr>" +
                            "</thead>" +
                            "<tbody>" +
                                "<tr>" +
                                    "<th class='size-guide-table-lead-column'>Thắt lưng</th>" +
                                    "<td>81 - 86</td>" +
                                    "<td>86 - 93</td>" +
                                    "<td>93 - 101</td>" +
                                    "<td>101 - 109</td>" +
                                    "<td>109 - 116</td>" +
                                    "<td>116 - 127</td>" +
                                    "<td>127 - 137</td>" +
                                "</tr>" +
                                
                            "</tbody>" +
                        "</table>";
                    }
                    else if (brands == "asics")
                    {
                        ltCM.Text = "IN";
                        ltTableSize.Text = "<table class='size-guide-measurements__table'>" +
                                                      "<thead>" +

                                                          "<tr>" +

                                                          "<th class='size-guide-table-lead-column'>Size</th>" +
                                                         
                                                          "<th class=''>S</th>" +
                                                          "<th class=''>M</th>" +
                                                          "<th class=''>L</th>" +
                                                          "<th class=''>XL</th>" +

                                                      "</tr>" +
                                                  "</thead>" +
                                                  "<tbody>" +
                                                      "<tr>" +
                                                          "<th class='size-guide-table-lead-column'>Thắt lưng</th>" +
                                                          "<td>30 - 33</td>" +
                                                          "<td>33 - 35</td>" +
                                                          "<td>36 - 38</td>" +
                                                          "<td>38 - 42</td>" +
                                                          
                                                      "</tr>" +
                                                      "<tr>" +
                                                          "<th class='size-guide-table-lead-column'>Hông</th>" +
                                                          "<td>36 - 39</td>" +
                                                          "<td>39 - 41</td>" +
                                                          "<td>41 - 43/td>" +
                                                          "<td>43 - 46</td>" +
                                                      "</tr>" +
                                                  "</tbody>" +
                                              "</table>";
                    }
                    else if (brands == "kamito")
                    {
                        ltCM.Text = "CM";
                        ltTableSize.Text = "<table class='size-guide-measurements__table'>" +
                                "<thead>" +

                                    "<tr>" +

                                    "<th class='size-guide-table-lead-column'>Size</th>" +

                                    "<th class=''>S</th>" +
                                    "<th class=''>M</th>" +
                                    "<th class=''>L</th>" +
                                    "<th class=''>XL</th>" +
                                    "<th class=''>2XL</th>" +

                                "</tr>" +
                            "</thead>" +
                            "<tbody>" +
                                "<tr>" +
                                    "<th class='size-guide-table-lead-column'>Chiều cao</th>" +
                                    "<td>160 - 165</td>" +
                                    "<td>165 - 170</td>" +
                                    "<td>170 - 175</td>" +
                                    "<td>175 - 180</td>" +
                                    "<td>180 - 185</td>" +

                                "</tr>" +
                                "<tr>" +
                                    "<th class='size-guide-table-lead-column'>Cân năng</th>" +
                                    "<td>50 - 60 KG</td>" +
                                    "<td>60 - 65 KG</td>" +
                                    "<td>65 - 70 KG</td>" +
                                    "<td>70 - 80 KG</td>" +
                                    "<td>80 - 90 KG</td>" +

                                "</tr>" +
                            "</tbody>" +
                        "</table>";
                    }
                }
                else if(trangphuc == "giay-the-thao")
                {
                    if (brands == "adidas")
                    {
                        ltCM.Text = "CM";
                        ltTableSize.Text = "<table class='size-guide-measurements__table'>" +
                                "<thead>" +

                                    "<tr>" +

                                    "<th class='size-guide-table-lead-column'>Size</th>" +
                                    "<th class=''>4</th>" +
                                    "<th class=''>4.5</th>" +
                                    "<th class=''>5</th>" +
                                    "<th class=''>5.5</th>" +
                                    "<th class=''>6</th>" +
                                    "<th class=''>6.5</th>" +
                                    "<th class=''>7</th>" +
                                    "<th class=''>7.5</th>" +
                                    "<th class=''>8</th>" +
                                    "<th class=''>8.5</th>" +
                                    "<th class=''>9</th>" +
                                    "<th class=''>9.5</th>" +
                                    "<th class=''>10</th>" +
                                    "<th class=''>10.5</th>" +
                                    "<th class=''>11</th>" +
                                "</tr>" +
                            "</thead>" +
                            "<tbody>" +
                                "<tr>" +
                                    "<th class='size-guide-table-lead-column'>Chiều dài bàn chân</th>" +
                                    "<td>22.5</td>" +
                                    "<td>22.9</td>" +
                                    "<td>23.3</td>" +
                                    "<td>23.8</td>" +
                                    "<td>24.2</td>" +
                                    "<td>24.6</td>" +
                                    "<td>25</td>" +
                                    "<td>25.5</td>" +
                                    "<td>25.9</td>" +
                                    "<td>26.3</td>" +
                                    "<td>26.7</td>" +
                                    "<td>27.1</td>" +
                                    "<td>27.6</td>" +
                                    "<td>28</td>" +
                                    "<td>28.4</td>" +
                                "</tr>" +
                                "<tr>" +
                                    "<th class='size-guide-table-lead-column'>UK</th>" +
                                    "<td class=''>4</td>" +
                                    "<td class=''>4.5</td>" +
                                    "<td class=''>5</td>" +
                                    "<td class=''>5.5</td>" +
                                    "<td class=''>6</td>" +
                                    "<td class=''>6.5</td>" +
                                    "<td class=''>7</td>" +
                                    "<td class=''>7.5</td>" +
                                    "<td class=''>8</td>" +
                                    "<td class=''>8.5</td>" +
                                    "<td class=''>9</td>" +
                                    "<td class=''>9.5</td>" +
                                    "<td class=''>10</td>" +
                                    "<td class=''>10.5</td>" +
                                    "<td class=''>11</td>" +
                                "</tr>" +
                                "<tr>" +
                                    "<th class='size-guide-table-lead-column'>EU</th>" +
                                    "<td class=''>36.66</td>" +
                                    "<td class=''>37.33</td>" +
                                    "<td class=''>38</td>" +
                                    "<td class=''>38.66</td>" +
                                    "<td class=''>39.33</td>" +
                                    "<td class=''>40</td>" +
                                    "<td class=''>40.66</td>" +
                                    "<td class=''>41.33</td>" +
                                    "<td class=''>42</td>" +
                                    "<td class=''>42.66</td>" +
                                    "<td class=''>43.33</td>" +
                                    "<td class=''>44</td>" +
                                    "<td class=''>44.66</td>" +
                                    "<td class=''>45.33</td>" +
                                    "<td class=''>46</td>" +
                                "</tr>" +
                                "<tr>" +
                                    "<th class='size-guide-table-lead-column'>US</th>" +
                                    "<td class=''>4.5</td>" +
                                    "<td class=''>5</td>" +
                                    "<td class=''>5.5</td>" +
                                    "<td class=''>6</td>" +
                                    "<td class=''>6.5</td>" +
                                    "<td class=''>7</td>" +
                                    "<td class=''>7.5</td>" +
                                    "<td class=''>8</td>" +
                                    "<td class=''>8.5</td>" +
                                    "<td class=''>9</td>" +
                                    "<td class=''>9.5</td>" +
                                    "<td class=''>10</td>" +
                                    "<td class=''>10.5</td>" +
                                    "<td class=''>11</td>" +
                                    "<td class=''>11.5</td>" +
                                "</tr>" +
                            "</tbody>" +
                        "</table>";
                    }
                    else if (brands == "nike")
                    {
                        ltCM.Text = "CM";
                        ltTableSize.Text = "<table class='size-guide-measurements__table'>" +
                               "<thead>" +

                                   "<tr>" +

                                   "<th class='size-guide-table-lead-column'>Size</th>" +
                                    "<th class=''>4</th>" +
                                    "<th class=''>4.5</th>" +
                                    "<th class=''>5</th>" +
                                    "<th class=''>5.5</th>" +
                                    "<th class=''>6</th>" +
                                    "<th class=''>6.5</th>" +
                                    "<th class=''>7</th>" +
                                    "<th class=''>7.5</th>" +
                                    "<th class=''>8</th>" +
                                    "<th class=''>8.5</th>" +
                                    "<th class=''>9</th>" +
                                    "<th class=''>9.5</th>" +
                                    "<th class=''>10</th>" +
                                    "<th class=''>10.5</th>" +
                                    "<th class=''>11</th>" +
                               "</tr>" +
                           "</thead>" +
                           "<tbody>" +
                               "<tr>" +
                                  "<th class='size-guide-table-lead-column'>Chiều dài bàn chân</th>" +
                                    "<td>22.4</td>" +
                                    "<td>22.9</td>" +
                                    "<td>23.3</td>" +
                                    "<td>23.7</td>" +

                                    "<td>25</td>" +
                                    "<td>25.5</td>" +
                                    "<td>26</td>" +
                                    "<td>26.5</td>" +
                                    "<td>27</td>" +
                                    "<td>27.5</td>" +
                                    "<td>28</td>" +
                                    "<td>28.5</td>" +
                                    "<td>29</td>" +
                                    "<td>29.5</td>" +
                                    "<td>30</td>" +
                               "</tr>" +
                               "<tr>" +
                                   "<th class='size-guide-table-lead-column'>UK</th>" +
                                    "<td class=''>4</td>" +
                                    "<td class=''>4.5</td>" +
                                    "<td class=''>5</td>" +
                                    "<td class=''>5.5</td>" +
                                    "<td class=''>6</td>" +
                                    "<td class=''>6.5</td>" +
                                    "<td class=''>7</td>" +
                                    "<td class=''>7.5</td>" +
                                    "<td class=''>8</td>" +
                                    "<td class=''>8.5</td>" +
                                    "<td class=''>9</td>" +
                                    "<td class=''>9.5</td>" +
                                    "<td class=''>10</td>" +
                                    "<td class=''>10.5</td>" +
                                    "<td class=''>11</td>" +
                               "</tr>" +
                               "<tr>" +
                                    "<th class='size-guide-table-lead-column'>EU</th>" +
                                    "<td class=''>36.5</td>" +

                                    "<td class=''>37.5</td>" +
                                    "<td class=''>38</td>" +

                                    "<td class=''>39</td>" +
                                    "<td class=''>40</td>" +
                                    "<td class=''>40.5</td>" +
                                    "<td class=''>41</td>" +
                                    "<td class=''>42</td>" +
                                    "<td class=''>42.5</td>" +
                                    "<td class=''>43</td>" +
                                    "<td class=''>44</td>" +
                                    "<td class=''>44.5</td>" +
                                    "<td class=''>45</td>" +
                                    "<td class=''>45.5</td>" +
                                    "<td class=''>46</td>" +
                               "</tr>" +
                                "<tr>" +
                                    "<th class='size-guide-table-lead-column'>US</th>" +
                                    "<td class=''>4.5</td>" +
                                    "<td class=''>5</td>" +
                                    "<td class=''>5.5</td>" +
                                    "<td class=''>6</td>" +
                                    "<td class=''>6.5</td>" +
                                    "<td class=''>7</td>" +
                                    "<td class=''>7.5</td>" +
                                    "<td class=''>8</td>" +
                                    "<td class=''>8.5</td>" +
                                    "<td class=''>9</td>" +
                                    "<td class=''>9.5</td>" +
                                    "<td class=''>10</td>" +
                                    "<td class=''>10.5</td>" +
                                    "<td class=''>11</td>" +
                                    "<td class=''>11.5</td>" +


                               "</tr>" +
                           "</tbody>" +
                       "</table>";
                    }
                    else if (brands == "puma")
                    {
                        ltCM.Text = "CM";
                        ltTableSize.Text = "<table class='size-guide-measurements__table'>" +
                               "<thead>" +

                                   "<tr>" +

                                    "<th class='size-guide-table-lead-column'>Size</th>" +
                                    "<th class=''>5</th>" +
                                    "<th class=''>5.5</th>" +
                                    "<th class=''>6</th>" +
                                    "<th class=''>6.5</th>" +
                                    "<th class=''>7</th>" +
                                    "<th class=''>7.5</th>" +
                                    "<th class=''>8</th>" +
                                    "<th class=''>8.5</th>" +
                                    "<th class=''>9</th>" +
                                    "<th class=''>9.5</th>" +
                                    "<th class=''>10</th>" +
                                    "<th class=''>10.5</th>" +
                                    "<th class=''>11</th>" +
                               "</tr>" +
                           "</thead>" +
                           "<tbody>" +
                               "<tr>" +
                                   "<th class='size-guide-table-lead-column'>Chiều dài bàn chân</th>" +
                                    "<td>24</td>" +
                                    "<td>24.5</td>" +
                                    "<td>25</td>" +
                                    "<td>25.5</td>" +

                                    "<td>26</td>" +
                                    "<td>26.5</td>" +
                                    "<td>27</td>" +
                                    "<td>27.5</td>" +
                                    "<td>28</td>" +
                                    "<td>28.5</td>" +
                                    "<td>29</td>" +
                                    "<td>29.5</td>" +
                                    "<td>30</td>" +
                               "</tr>" +

                               "<tr>" +
                                   "<th class='size-guide-table-lead-column'>UK</th>" +

                                    "<td class=''>5</td>" +
                                    "<td class=''>5.5</td>" +
                                    "<td class=''>6</td>" +
                                    "<td class=''>6.5</td>" +
                                    "<td class=''>7</td>" +
                                    "<td class=''>7.5</td>" +
                                    "<td class=''>8</td>" +
                                    "<td class=''>8.5</td>" +
                                    "<td class=''>9</td>" +
                                    "<td class=''>9.5</td>" +
                                    "<td class=''>10</td>" +
                                    "<td class=''>10.5</td>" +
                                    "<td class=''>11</td>" +
                               "</tr>" +
                               "<tr>" +
                                    "<th class='size-guide-table-lead-column'>EU</th>" +

                                    "<td class=''>38</td>" +
                                    "<td class=''>38.5</td>" +
                                    "<td class=''>39</td>" +
                                    "<td class=''>40</td>" +
                                    "<td class=''>40.5</td>" +
                                    "<td class=''>41</td>" +
                                    "<td class=''>42</td>" +
                                    "<td class=''>42.5</td>" +
                                    "<td class=''>43</td>" +
                                    "<td class=''>44</td>" +
                                    "<td class=''>44.5</td>" +
                                    "<td class=''>45</td>" +

                                    "<td class=''>46</td>" +
                               "</tr>" +
                               "<tr>" +
                                    "<th class='size-guide-table-lead-column'>US</th>" +
                                    "<td class=''>6</td>" +
                                    "<td class=''>6.5</td>" +
                                    "<td class=''>7</td>" +
                                    "<td class=''>7.5</td>" +
                                    "<td class=''>8</td>" +
                                    "<td class=''>8.5</td>" +
                                    "<td class=''>9</td>" +
                                    "<td class=''>9.5</td>" +
                                    "<td class=''>10</td>" +
                                    "<td class=''>10.5</td>" +
                                    "<td class=''>11</td>" +
                                    "<td class=''>11.5</td>" +
                                    "<td class=''>12</td>" +
                               "</tr>" +
                           "</tbody>" +
                       "</table>";
                    }
                    else if (brands == "mizuno")
                    {
                        ltCM.Text = "";
                        ltTableSize.Text = "<table class='size-guide-measurements__table'>" +
                                "<thead>" +

                                    "<tr>" +

                                    "<th class='size-guide-table-lead-column'>Size</th>" +
                                    "<th class=''>6</th>" +
                                    "<th class=''>6.5</th>" +
                                    "<th class=''>7</th>" +
                                    "<th class=''>7.5</th>" +
                                    "<th class=''>8</th>" +
                                    "<th class=''>8.5</th>" +
                                    "<th class=''>9</th>" +
                                    "<th class=''>9.5</th>" +
                                    "<th class=''>10</th>" +
                                    "<th class=''>10.5</th>" +
                                    "<th class=''>11</th>" +
                                "</tr>" +
                            "</thead>" +
                            "<tbody>" +
                                "<tr>" +
                                   "<th class='size-guide-table-lead-column'>UK</th>" +


                                    "<td class=''>6</td>" +
                                    "<td class=''>6.5</td>" +
                                    "<td class=''>7</td>" +
                                    "<td class=''>7.5</td>" +
                                    "<td class=''>8</td>" +
                                    "<td class=''>8.5</td>" +
                                    "<td class=''>9</td>" +
                                    "<td class=''>9.5</td>" +
                                    "<td class=''>10</td>" +
                                    "<td class=''>10.5</td>" +
                                    "<td class=''>11</td>" +
                               "</tr>" +
                               "<tr>" +
                                    "<th class='size-guide-table-lead-column'>EU</th>" +


                                    "<td class=''>39</td>" +
                                    "<td class=''>40</td>" +
                                    "<td class=''>40.5</td>" +
                                    "<td class=''>41</td>" +
                                    "<td class=''>42</td>" +
                                    "<td class=''>42.5</td>" +
                                    "<td class=''>43</td>" +
                                    "<td class=''>44</td>" +
                                    "<td class=''>44.5</td>" +
                                    "<td class=''>45</td>" +

                                    "<td class=''>46</td>" +
                               "</tr>" +
                               "<tr>" +
                                    "<th class='size-guide-table-lead-column'>US</th>" +

                                    "<td class=''>7</td>" +
                                    "<td class=''>7.5</td>" +
                                    "<td class=''>8</td>" +
                                    "<td class=''>8.5</td>" +
                                    "<td class=''>9</td>" +
                                    "<td class=''>9.5</td>" +
                                    "<td class=''>10</td>" +
                                    "<td class=''>10.5</td>" +
                                    "<td class=''>11</td>" +
                                    "<td class=''>11.5</td>" +
                                    "<td class=''>12</td>" +
                               "</tr>" +
                            "</tbody>" +
                        "</table>";
                    }
                    else if (brands == "newbalance")
                    {
                        ltCM.Text = "";
                        ltTableSize.Text = "<table class='size-guide-measurements__table'>" +
                                "<thead>" +

                                    "<tr>" +

                                    "<th class='size-guide-table-lead-column'>Size</th>" +
                                    "<th class=''>6</th>" +
                                    "<th class=''>6.5</th>" +
                                    "<th class=''>7</th>" +
                                    "<th class=''>7.5</th>" +
                                    "<th class=''>8</th>" +
                                    "<th class=''>8.5</th>" +
                                    "<th class=''>9</th>" +
                                    "<th class=''>9.5</th>" +
                                    "<th class=''>10</th>" +
                                    "<th class=''>10.5</th>" +
                                    "<th class=''>11</th>" +
                                "</tr>" +
                            "</thead>" +
                            "<tbody>" +
                                "<tr>" +
                                    "<th class='size-guide-table-lead-column'>UK</th>" +


                                    "<td class=''>6</td>" +
                                    "<td class=''>6.5</td>" +
                                    "<td class=''>7</td>" +
                                    "<td class=''>7.5</td>" +
                                    "<td class=''>8</td>" +
                                    "<td class=''>8.5</td>" +
                                    "<td class=''>9</td>" +
                                    "<td class=''>9.5</td>" +
                                    "<td class=''>10</td>" +
                                    "<td class=''>10.5</td>" +
                                    "<td class=''>11</td>" +
                                "</tr>" +
                                "<tr>" +
                                    "<th class='size-guide-table-lead-column'>EU</th>" +


                                    "<td class=''>39.5</td>" +
                                    "<td class=''>40</td>" +
                                    "<td class=''>40.5</td>" +
                                    "<td class=''>41</td>" +
                                    "<td class=''>41.5</td>" +
                                    "<td class=''>42</td>" +
                                    "<td class=''>42.5</td>" +
                                    "<td class=''>43</td>" +
                                    "<td class=''>44</td>" +
                                    "<td class=''>44.5</td>" +
                                    "<td class=''>45</td>" +


                                "</tr>" +
                                "<tr>" +
                                    "<th class='size-guide-table-lead-column'>US</th>" +

                                    "<td class=''>6.5</td>" +
                                    "<td class=''>7</td>" +
                                    "<td class=''>7.5</td>" +
                                    "<td class=''>8</td>" +
                                    "<td class=''>8.5</td>" +
                                    "<td class=''>9</td>" +
                                    "<td class=''>9.5</td>" +
                                    "<td class=''>10</td>" +
                                    "<td class=''>10.5</td>" +
                                    "<td class=''>11</td>" +
                                    "<td class=''>11.5</td>" +

                               "</tr>" +
                            "</tbody>" +
                        "</table>";
                    }
                    else if (brands == "asics")
                    {
                        ltCM.Text = "";
                        ltTableSize.Text = "<table class='size-guide-measurements__table'>" +
                                 "<thead>" +

                                     "<tr>" +

                                     "<th class='size-guide-table-lead-column'>Size</th>" +
                                     "<th class=''>6</th>" +
                                     "<th class=''>6.5</th>" +
                                     "<th class=''>7</th>" +
                                     "<th class=''>7.5</th>" +
                                     "<th class=''>8</th>" +
                                     "<th class=''>8.5</th>" +
                                     "<th class=''>9</th>" +
                                     "<th class=''>9.5</th>" +
                                     "<th class=''>10</th>" +
                                     "<th class=''>10.5</th>" +
                                     "<th class=''>11</th>" +
                                 "</tr>" +
                             "</thead>" +
                             "<tbody>" +
                                 "<tr>" +
                                    "<th class='size-guide-table-lead-column'>UK</th>" +


                                     "<td class=''>6</td>" +
                                     "<td class=''>6.5</td>" +
                                     "<td class=''>7</td>" +
                                     "<td class=''>7.5</td>" +
                                     "<td class=''>8</td>" +
                                     "<td class=''>8.5</td>" +
                                     "<td class=''>9</td>" +
                                     "<td class=''>9.5</td>" +
                                     "<td class=''>10</td>" +
                                     "<td class=''>10.5</td>" +
                                     "<td class=''>11</td>" +
                                "</tr>" +
                                "<tr>" +
                                     "<th class='size-guide-table-lead-column'>EU</th>" +



                                     "<td class=''>40</td>" +
                                     "<td class=''>40.5</td>" +
                                     "<td class=''>41.5</td>" +
                                     "<td class=''>42</td>" +
                                     "<td class=''>42.5</td>" +
                                     "<td class=''>43.5</td>" +
                                     "<td class=''>44</td>" +
                                     "<td class=''>44.5</td>" +
                                     "<td class=''>45</td>" +

                                     "<td class=''>46</td>" +
                                     "<td class=''>46.5</td>" +
                                "</tr>" +
                                "<tr>" +
                                     "<th class='size-guide-table-lead-column'>US</th>" +

                                     "<td class=''>7</td>" +
                                     "<td class=''>7.5</td>" +
                                     "<td class=''>8</td>" +
                                     "<td class=''>8.5</td>" +
                                     "<td class=''>9</td>" +
                                     "<td class=''>9.5</td>" +
                                     "<td class=''>10</td>" +
                                     "<td class=''>10.5</td>" +
                                     "<td class=''>11</td>" +
                                     "<td class=''>11.5</td>" +
                                     "<td class=''>12</td>" +
                                "</tr>" +
                             "</tbody>" +
                         "</table>";
                    }
                    else if (brands == "kamito")
                    {
                        ltCM.Text = "CM";
                        ltTableSize.Text = "<table class='size-guide-measurements__table'>" +
                                "<thead>" +

                                    "<tr>" +

                                    "<th class='size-guide-table-lead-column'>CM</th>" +
                                    "<th class=''>18</th>" +
                                    "<th class=''>19</th>" +
                                    "<th class=''>19.5</th>" +
                                    "<th class=''>20.5</th>" +
                                    "<th class=''>21</th>" +
                                    "<th class=''>22</th>" +
                                    "<th class=''>22.5</th>" +
                                    "<th class=''>23.5</th>" +
                                    "<th class=''>24</th>" +
                                    "<th class=''>25</th>" +
                                    "<th class=''>25.5</th>" +
                                    "<th class=''>26.5</th>" +
                                    "<th class=''>27</th>" +
                                    "<th class=''>28</th>" +
                                "</tr>" +
                            "</thead>" +
                            "<tbody>" +
                            "<tr>" +
                                  "<th class='size-guide-table-lead-column'>EU</th>" +
                                    "<td>30</td>" +
                                    "<td>31</td>" +
                                    "<td>32</td>" +
                                    "<td>33</td>" +

                                    "<td>34</td>" +
                                    "<td>35</td>" +
                                    "<td>36</td>" +
                                    "<td>37</td>" +
                                    "<td>38</td>" +
                                    "<td>39</td>" +
                                    "<td>40</td>" +
                                    "<td>41</td>" +
                                    "<td>42</td>" +
                                    "<td>43</td>" +

                               "</tr>" +
                                "<tr>" +
                                    "<th class='size-guide-table-lead-column'>UK</th>" +


                                    "<td class=''>C12</td>" +
                                    "<td class=''>C13</td>" +
                                    "<td class=''>C13.5</td>" +
                                    "<td class=''>1.5</td>" +
                                    "<td class=''>2</td>" +
                                    "<td class=''>3</td>" +
                                    "<td class=''>3.5</td>" +
                                    "<td class=''>4.5</td>" +
                                    "<td class=''>5</td>" +
                                    "<td class=''>6</td>" +
                                    "<td class=''>6.5</td>" +
                                    "<td class=''>7.5</td>" +
                                    "<td class=''>8</td>" +
                                    "<td class=''>9</td>" +
                                "</tr>" +
                                "<tr>" +
                                    "<th class='size-guide-table-lead-column'>JAPAN</th>" +
                                    "<td class=''>18</td>" +
                                    "<td class=''>19</td>" +
                                    "<td class=''>19.5</td>" +
                                    "<td class=''>20.5</td>" +
                                    "<td class=''>21</td>" +
                                    "<td class=''>22</td>" +
                                    "<td class=''>22.5</td>" +
                                    "<td class=''>23.5</td>" +
                                    "<td class=''>24</td>" +
                                    "<td class=''>25</td>" +
                                    "<td class=''>25.5</td>" +
                                    "<td class=''>26.5</td>" +
                                    "<td class=''>27</td>" +
                                    "<td class=''>28</td>" +
                                "</tr>" +

                            "</tbody>" +
                        "</table>";
                    }
                }
            }
            if(gioitinh == "nu")
            {
                if (trangphuc == "ao")
                {
                    if (brands == "adidas")
                    {
                        ltCM.Text = "CM";
                        ltTableSize.Text = "<table class='size-guide-measurements__table'>" +
                                "<thead>" +

                                    "<tr>" +

                                    "<th class='size-guide-table-lead-column'>Size</th>" +
                                    "<th class=''>XXS</th>" +
                                    "<th class=''>XS</th>" +
                                    "<th class=''>S</th>" +
                                    "<th class=''>M</th>" +
                                    "<th class=''>L</th>" +
                                    "<th class=''>XL</th>" +
                                    "<th class=''>XXL</th>" +
                                "</tr>" +
                            "</thead>" +
                            "<tbody>" +
                                "<tr>" +
                                    "<th class='size-guide-table-lead-column'>Ngực</th>" +
                                    "<td>72.9 - 75.9</td>" +
                                    "<td>76.2 - 81.3</td>" +
                                    "<td>83.8 - 88.9</td>" +
                                    "<td>91.4 - 94</td>" +
                                    "<td>96.5 - 101.6</td>" +
                                    "<td>104.1 - 109.2</td>" +
                                    "<td>111.7 - 116.8</td>" +
                                "</tr>" +
                                "<tr>" +
                                    "<th class='size-guide-table-lead-column'>Eo</th>" +
                                    "<td>56.9 - 59.9</td>" +
                                    "<td>60.9 - 66</td>" +
                                    "<td>68.6 - 71.1</td>" +
                                    "<td>73.6 - 78.7</td>" +
                                    "<td>81.3 - 86.4</td>" +
                                    "<td>88.9 - 94</td>" +
                                    "<td>96.5 - 104.1</td>" +
                                "</tr>" +
                                "<tr>" +
                                    "<th class='size-guide-table-lead-column'>Hông</th>" +
                                    "<td>82.1 - 85.1</td>" +
                                    "<td>86.4 - 91.4</td>" +
                                    "<td>94 - 96.5</td>" +
                                    "<td>99 - 104.1</td>" +
                                    "<td>106.7 - 109.2</td>" +
                                    "<td>111.7 - 116.8</td>" +
                                    "<td>119.4 - 124.5</td>" +
                               "</tr>" +
                               "<tr>" +
                                    "<th class='size-guide-table-lead-column'>UK Size</th>" +
                                    "<td>0 - 2</td>" +
                                    "<td>4 - 6</td>" +
                                    "<td>8 - 10</td>" +
                                    "<td>12 - 14</td>" +
                                    "<td>16 - 18</td>" +
                                    "<td>20 - 22</td>" +
                                    "<td>24 - 26</td>" +
                               "</tr>" +
                            "</tbody>" +
                        "</table>";
                    }
                    else if (brands == "nike")
                    {
                        ltCM.Text = "CM";
                        ltTableSize.Text = "<table class='size-guide-measurements__table'>" +
                               "<thead>" +

                                   "<tr>" +

                                   "<th class='size-guide-table-lead-column'>Size</th>" +
                                   "<th class=''>XS</th>" +
                                   "<th class=''>S</th>" +
                                   "<th class=''>M</th>" +
                                   "<th class=''>L</th>" +
                                   "<th class=''>XL</th>" +
                                   "<th class=''>XXL</th>" +
                                  
                               "</tr>" +
                           "</thead>" +
                           "<tbody>" +
                               "<tr>" +
                                   "<th class='size-guide-table-lead-column'>Ngực</th>" +
                                   "<td>76 - 83</td>" +
                                   "<td>83 - 90</td>" +
                                   "<td>90 - 97</td>" +
                                   "<td>97 - 104</td>" +
                                   "<td>104 - 114</td>" +
                                   "<td>114 - 124</td>" +
                                   
                               "</tr>" +
                               "<tr>" +
                                   "<th class='size-guide-table-lead-column'>Eo</th>" +
                                   "<td>60 - 67</td>" +
                                   "<td>67 - 74</td>" +
                                   "<td>74 - 81</td>" +
                                   "<td>81 - 88</td>" +
                                   "<td>88 - 98</td>" +
                                   "<td>98 - 108</td>" +
                                   
                               "</tr>" +
                               "<tr>" +
                                   "<th class='size-guide-table-lead-column'>Hông</th>" +
                                   "<td>84 - 91</td>" +
                                   "<td>91 - 98</td>" +
                                   "<td>98 - 105</td>" +
                                   "<td>105 - 112</td>" +
                                   "<td>112 - 120</td>" +
                                   "<td>120 - 128</td>" +
                                   
                               "</tr>" +
                               "<tr>" +
                                   "<th class='size-guide-table-lead-column'>UK Size</th>" +
                                   "<td>4 - 6</td>" +
                                   "<td>8 - 10</td>" +
                                   "<td>12 - 14</td>" +
                                   "<td>16 - 18</td>" +
                                   "<td>20 - 22</td>" +
                                   "<td>24 - 26</td>" +
                               "</tr>" +
                           "</tbody>" +
                       "</table>";
                    }
                    else if (brands == "puma")
                    {
                        ltCM.Text = "CM";
                        ltTableSize.Text = "<table class='size-guide-measurements__table'>" +
                               "<thead>" +

                                   "<tr>" +

                                   "<th class='size-guide-table-lead-column'>Size</th>" +
                                   "<th class=''>XXS</th>" +
                                   "<th class=''>XS</th>" +
                                   "<th class=''>S</th>" +
                                   "<th class=''>M</th>" +
                                   "<th class=''>L</th>" +
                                   "<th class=''>XL</th>" +
                                   "<th class=''>2XL</th>" +
                                   "<th class=''>3XL</th>" +
                               "</tr>" +
                           "</thead>" +
                           "<tbody>" +
                               "<tr>" +
                                   "<th class='size-guide-table-lead-column'>Ngực</th>" +
                                   "<td>76</td>" +
                                   "<td>81.5</td>" +
                                   "<td>86.5</td>" +
                                   "<td>91.5</td>" +
                                   "<td>96.5</td>" +
                                   "<td>101.5</td>" +
                                   "<td>106.5</td>" +
                                   "<td>112</td>" +
                               "</tr>" +

                               "<tr>" +
                                   "<th class='size-guide-table-lead-column'>Eo</th>" +
                                   "<td>61</td>" +
                                   "<td>63.5</td>" +
                                   "<td>66</td>" +
                                   "<td>73.5</td>" +
                                   "<td>78.5</td>" +
                                   "<td>86.5</td>" +
                                   "<td>91.5</td>" +
                                   "<td>96.5</td>" +
                               "</tr>" +
                                "<tr>" +
                                   "<th class='size-guide-table-lead-column'>Hông</th>" +
                                   "<td>89</td>" +
                                   "<td>91.5</td>" +
                                   "<td>94</td>" +
                                   "<td>99</td>" +
                                   "<td>104</td>" +
                                   "<td>112</td>" +
                                   "<td>117</td>" +
                                   "<td>122</td>" +
                               "</tr>" +
                           "</tbody>" +
                       "</table>";
                    }
                    else if (brands == "mizuno")
                    {
                        ltCM.Text = "CM";
                        ltTableSize.Text = "<table class='size-guide-measurements__table'>" +
                                "<thead>" +

                                    "<tr>" +

                                    "<th class='size-guide-table-lead-column'>Size</th>" +
                                    "<th class=''>XS</th>" +
                                    "<th class=''>S</th>" +
                                    "<th class=''>M</th>" +
                                    "<th class=''>L</th>" +
                                    "<th class=''>XL</th>" +
                                    

                                "</tr>" +
                            "</thead>" +
                            "<tbody>" +
                                "<tr>" +
                                    "<th class='size-guide-table-lead-column'>Ngực</th>" +

                                    "<td>75 - 81</td>" +
                                    "<td>82 - 88</td>" +
                                    "<td>89 - 95</td>" +
                                    "<td>96 - 102</td>" +
                                    "<td>103 - 109</td>" +

                                "</tr>" +
                                "<tr>" +
                                    "<th class='size-guide-table-lead-column'>Eo</th>" +

                                    "<td>55 - 61</td>" +
                                    "<td>61 - 67</td>" +
                                    "<td>97 - 73</td>" +
                                    "<td>73 - 79</td>" +
                                    "<td>79 - 85</td>" +

                                "</tr>" +
                                "<tr>" +
                                    "<th class='size-guide-table-lead-column'>Hông</th>" +

                                    "<td>78 - 84</td>" +
                                    "<td>85 - 91</td>" +
                                    "<td>92 - 98</td>" +
                                    "<td>99 - 105</td>" +
                                    "<td>106 - 112</td>" +

                                "</tr>" +
                            "</tbody>" +
                        "</table>";
                    }
                    else if (brands == "newbalance")
                    {
                        ltCM.Text = "CM";
                        ltTableSize.Text = "<table class='size-guide-measurements__table'>" +
                                "<thead>" +

                                    "<tr>" +

                                    "<th class='size-guide-table-lead-column'>Size</th>" +
                                    "<th class=''>XS</th>" +
                                    "<th class=''>S</th>" +
                                    "<th class=''>M</th>" +
                                    "<th class=''>L</th>" +
                                    "<th class=''>XL</th>" +
                                    "<th class=''>2XL</th>" +
                                    
                                "</tr>" +
                            "</thead>" +
                            "<tbody>" +
                                "<tr>" +
                                    "<th class='size-guide-table-lead-column'>Ngực</th>" +
                                    "<td>76 - 81</td>" +
                                    "<td>81 - 89</td>" +
                                    "<td>89 - 93</td>" +
                                    "<td>93 - 101</td>" +
                                    "<td>101 - 111</td>" +
                                    "<td>111 - 119</td>" +
                                    
                                "</tr>" +
                                "<tr>" +
                                    "<th class='size-guide-table-lead-column'>Eo</th>" +
                                    "<td>61 - 66</td>" +
                                    "<td>66 - 71</td>" +
                                    "<td>71 - 78</td>" +
                                    "<td>78 - 86</td>" +
                                    "<td>86 - 96</td>" +
                                    "<td>96 - 106</td>" +
                                    
                                "</tr>" +
                                "<tr>" +
                                    "<th class='size-guide-table-lead-column'>Hông</th>" +
                                    "<td>83 - 89</td>" +
                                    "<td>89 - 96</td>" +
                                    "<td>96 - 101</td>" +
                                    "<td>101 - 109</td>" +
                                    "<td>109 - 119</td>" +
                                    "<td>119 - 127</td>" +
                                    
                                "</tr>" +
                            "</tbody>" +
                        "</table>";
                    }
                    else if (brands == "asics")
                    {
                        ltCM.Text = "CM";
                        ltTableSize.Text = "<table class='size-guide-measurements__table'>" +
                                                      "<thead>" +
                                                          "<tr>" +
                                                          "<th class='size-guide-table-lead-column'>Size</th>" +
                                                          "<th class=''>XXS</th>" +
                                                          "<th class=''>XS</th>" +
                                                          "<th class=''>S</th>" +
                                                          "<th class=''>M</th>" +
                                                          "<th class=''>L</th>" +
                                                          "<th class=''>XL</th>" +
                                                          "<th class=''>XXL</th>" +
                                                      "</tr>" +
                                                  "</thead>" +
                                                  "<tbody>" +
                                                      "<tr>" +
                                                          "<th class='size-guide-table-lead-column'>Ngực</th>" +
                                                          "<td>74 - 78</td>" +
                                                          "<td>78 - 84</td>" +
                                                          "<td>84 - 90</td>" +
                                                          "<td>90 - 96</td>" +
                                                          "<td>96 - 103</td>" +
                                                          "<td>103 - 111</td>" +
                                                          "<td>111 - 119</td>" +
                                                      "</tr>" +
                                                      "<tr>" +
                                                          "<th class='size-guide-table-lead-column'>Eo</th>" +
                                                          "<td>59 - 63</td>" +
                                                          "<td>63 - 67</td>" +
                                                          "<td>67 - 73</td>" +
                                                          "<td>73 - 79</td>" +
                                                          "<td>79 - 86</td>" +
                                                          "<td>86 - 95</td>" +
                                                          "<td>95 - 104</td>" +
                                                      "</tr>" +
                                                      "<tr>" +
                                                          "<th class='size-guide-table-lead-column'>Hông</th>" +
                                                          "<td>82 - 86</td>" +
                                                          "<td>86 - 91</td>" +
                                                          "<td>91 - 97</td>" +
                                                          "<td>97 - 103</td>" +
                                                          "<td>103 - 110</td>" +
                                                          "<td>110 - 117</td>" +
                                                          "<td>117 - 125</td>" +
                                                      "</tr>" +
                                                  "</tbody>" +
                                              "</table>";
                    }
                    else if (brands == "kamito")
                    {
                        ltCM.Text = "CM";
                        ltTableSize.Text = "<table class='size-guide-measurements__table'>" +
                                "<thead>" +

                                    "<tr>" +

                                    "<th class='size-guide-table-lead-column'>Size</th>" +
                                    "<th class=''>S</th>" +
                                    "<th class=''>M</th>" +
                                    "<th class=''>L</th>" +
                                    "<th class=''>XL</th>" +
                                "</tr>" +
                            "</thead>" +
                            "<tbody>" +
                                "<tr>" +
                                    "<th class='size-guide-table-lead-column'>Chiều cao</th>" +
                                    "<td>150 - 155</td>" +
                                    "<td>155 - 160</td>" +
                                    "<td>160 - 165</td>" +
                                    "<td>165 - 170</td>" +
                                "</tr>" +
                                "<tr>" +
                                    "<th class='size-guide-table-lead-column'>Cân nặng</th>" +
                                    "<td>40 - 45 KG</td>" +
                                    "<td>45 - 50 KG</td>" +
                                   
                                    "<td>55 - 60 KG</td>" +
                                    "<td>60 - 65 KG</td>" +

                                "</tr>" +
                            "</tbody>" +
                        "</table>";
                    }
                }
                else if (trangphuc == "giay-bong-da")
                {
                    if (brands == "adidas")
                    {
                        ltCM.Text = "CM";
                        ltTableSize.Text = "<table class='size-guide-measurements__table'>" +
                                "<thead>" +

                                    "<tr>" +

                                    "<th class='size-guide-table-lead-column'>Size</th>" +
                                    "<th class=''>4</th>" +
                                    "<th class=''>4.5</th>" +
                                    "<th class=''>5</th>" +
                                    "<th class=''>5.5</th>" +
                                    "<th class=''>6</th>" +
                                    "<th class=''>6.5</th>" +
                                    "<th class=''>7</th>" +
                                    "<th class=''>7.5</th>" +
                                    "<th class=''>8</th>" +
                                    "<th class=''>8.5</th>" +
                                    "<th class=''>9</th>" +
                                    "<th class=''>9.5</th>" +
                                    "<th class=''>10</th>" +
                                    "<th class=''>10.5</th>" +
                                    "<th class=''>11</th>" +
                                "</tr>" +
                            "</thead>" +
                            "<tbody>" +
                                "<tr>" +
                                    "<th class='size-guide-table-lead-column'>Chiều dài bàn chân</th>" +
                                    "<td>22.5</td>" +
                                    "<td>22.9</td>" +
                                    "<td>23.3</td>" +
                                    "<td>23.8</td>" +
                                    "<td>24.2</td>" +
                                    "<td>24.6</td>" +
                                    "<td>25</td>" +
                                    "<td>25.5</td>" +
                                    "<td>25.9</td>" +
                                    "<td>26.3</td>" +
                                    "<td>26.7</td>" +
                                    "<td>27.1</td>" +
                                    "<td>27.6</td>" +
                                    "<td>28</td>" +
                                    "<td>28.4</td>" +
                                "</tr>" +
                                "<tr>" +
                                    "<th class='size-guide-table-lead-column'>UK</th>" +
                                    "<td class=''>4</td>" +
                                    "<td class=''>4.5</td>" +
                                    "<td class=''>5</td>" +
                                    "<td class=''>5.5</td>" +
                                    "<td class=''>6</td>" +
                                    "<td class=''>6.5</td>" +
                                    "<td class=''>7</td>" +
                                    "<td class=''>7.5</td>" +
                                    "<td class=''>8</td>" +
                                    "<td class=''>8.5</td>" +
                                    "<td class=''>9</td>" +
                                    "<td class=''>9.5</td>" +
                                    "<td class=''>10</td>" +
                                    "<td class=''>10.5</td>" +
                                    "<td class=''>11</td>" +
                                "</tr>" +
                                "<tr>" +
                                    "<th class='size-guide-table-lead-column'>EU</th>" +
                                    "<td class=''>36.66</td>" +
                                    "<td class=''>37.33</td>" +
                                    "<td class=''>38</td>" +
                                    "<td class=''>38.66</td>" +
                                    "<td class=''>39.33</td>" +
                                    "<td class=''>40</td>" +
                                    "<td class=''>40.66</td>" +
                                    "<td class=''>41.33</td>" +
                                    "<td class=''>42</td>" +
                                    "<td class=''>42.66</td>" +
                                    "<td class=''>43.33</td>" +
                                    "<td class=''>44</td>" +
                                    "<td class=''>44.66</td>" +
                                    "<td class=''>45.33</td>" +
                                    "<td class=''>46</td>" +
                                "</tr>" +
                                "<tr>" +
                                    "<th class='size-guide-table-lead-column'>US</th>" +
                                    "<td class=''>4.5</td>" +
                                    "<td class=''>5</td>" +
                                    "<td class=''>5.5</td>" +
                                    "<td class=''>6</td>" +
                                    "<td class=''>6.5</td>" +
                                    "<td class=''>7</td>" +
                                    "<td class=''>7.5</td>" +
                                    "<td class=''>8</td>" +
                                    "<td class=''>8.5</td>" +
                                    "<td class=''>9</td>" +
                                    "<td class=''>9.5</td>" +
                                    "<td class=''>10</td>" +
                                    "<td class=''>10.5</td>" +
                                    "<td class=''>11</td>" +
                                    "<td class=''>11.5</td>" +
                                "</tr>" +
                            "</tbody>" +
                        "</table>";
                    }
                    else if (brands == "nike")
                    {
                        ltCM.Text = "CM";
                        ltTableSize.Text = "<table class='size-guide-measurements__table'>" +
                               "<thead>" +

                                   "<tr>" +

                                   "<th class='size-guide-table-lead-column'>Size</th>" +
                                    "<th class=''>4</th>" +
                                    "<th class=''>4.5</th>" +
                                    "<th class=''>5</th>" +
                                    "<th class=''>5.5</th>" +
                                    "<th class=''>6</th>" +
                                    "<th class=''>6.5</th>" +
                                    "<th class=''>7</th>" +
                                    "<th class=''>7.5</th>" +
                                    "<th class=''>8</th>" +
                                    "<th class=''>8.5</th>" +
                                    "<th class=''>9</th>" +
                                    "<th class=''>9.5</th>" +
                                    "<th class=''>10</th>" +
                                    "<th class=''>10.5</th>" +
                                    "<th class=''>11</th>" +
                               "</tr>" +
                           "</thead>" +
                           "<tbody>" +
                               "<tr>" +
                                  "<th class='size-guide-table-lead-column'>Chiều dài bàn chân</th>" +
                                    "<td>22.4</td>" +
                                    "<td>22.9</td>" +
                                    "<td>23.3</td>" +
                                    "<td>23.7</td>" +

                                    "<td>25</td>" +
                                    "<td>25.5</td>" +
                                    "<td>26</td>" +
                                    "<td>26.5</td>" +
                                    "<td>27</td>" +
                                    "<td>27.5</td>" +
                                    "<td>28</td>" +
                                    "<td>28.5</td>" +
                                    "<td>29</td>" +
                                    "<td>29.5</td>" +
                                    "<td>30</td>" +
                               "</tr>" +
                               "<tr>" +
                                   "<th class='size-guide-table-lead-column'>UK</th>" +
                                    "<td class=''>4</td>" +
                                    "<td class=''>4.5</td>" +
                                    "<td class=''>5</td>" +
                                    "<td class=''>5.5</td>" +
                                    "<td class=''>6</td>" +
                                    "<td class=''>6.5</td>" +
                                    "<td class=''>7</td>" +
                                    "<td class=''>7.5</td>" +
                                    "<td class=''>8</td>" +
                                    "<td class=''>8.5</td>" +
                                    "<td class=''>9</td>" +
                                    "<td class=''>9.5</td>" +
                                    "<td class=''>10</td>" +
                                    "<td class=''>10.5</td>" +
                                    "<td class=''>11</td>" +
                               "</tr>" +
                               "<tr>" +
                                    "<th class='size-guide-table-lead-column'>EU</th>" +
                                    "<td class=''>36.5</td>" +

                                    "<td class=''>37.5</td>" +
                                    "<td class=''>38</td>" +

                                    "<td class=''>39</td>" +
                                    "<td class=''>40</td>" +
                                    "<td class=''>40.5</td>" +
                                    "<td class=''>41</td>" +
                                    "<td class=''>42</td>" +
                                    "<td class=''>42.5</td>" +
                                    "<td class=''>43</td>" +
                                    "<td class=''>44</td>" +
                                    "<td class=''>44.5</td>" +
                                    "<td class=''>45</td>" +
                                    "<td class=''>45.5</td>" +
                                    "<td class=''>46</td>" +
                               "</tr>" +
                                "<tr>" +
                                    "<th class='size-guide-table-lead-column'>US</th>" +
                                    "<td class=''>4.5</td>" +
                                    "<td class=''>5</td>" +
                                    "<td class=''>5.5</td>" +
                                    "<td class=''>6</td>" +
                                    "<td class=''>6.5</td>" +
                                    "<td class=''>7</td>" +
                                    "<td class=''>7.5</td>" +
                                    "<td class=''>8</td>" +
                                    "<td class=''>8.5</td>" +
                                    "<td class=''>9</td>" +
                                    "<td class=''>9.5</td>" +
                                    "<td class=''>10</td>" +
                                    "<td class=''>10.5</td>" +
                                    "<td class=''>11</td>" +
                                    "<td class=''>11.5</td>" +


                               "</tr>" +
                           "</tbody>" +
                       "</table>";
                    }
                    else if (brands == "puma")
                    {
                        ltCM.Text = "CM";
                        ltTableSize.Text = "<table class='size-guide-measurements__table'>" +
                               "<thead>" +

                                   "<tr>" +

                                    "<th class='size-guide-table-lead-column'>Size</th>" +
                                    "<th class=''>5</th>" +
                                    "<th class=''>5.5</th>" +
                                    "<th class=''>6</th>" +
                                    "<th class=''>6.5</th>" +
                                    "<th class=''>7</th>" +
                                    "<th class=''>7.5</th>" +
                                    "<th class=''>8</th>" +
                                    "<th class=''>8.5</th>" +
                                    "<th class=''>9</th>" +
                                    "<th class=''>9.5</th>" +
                                    "<th class=''>10</th>" +
                                    "<th class=''>10.5</th>" +
                                    "<th class=''>11</th>" +
                               "</tr>" +
                           "</thead>" +
                           "<tbody>" +
                               "<tr>" +
                                   "<th class='size-guide-table-lead-column'>Chiều dài bàn chân</th>" +
                                    "<td>24</td>" +
                                    "<td>24.5</td>" +
                                    "<td>25</td>" +
                                    "<td>25.5</td>" +

                                    "<td>26</td>" +
                                    "<td>26.5</td>" +
                                    "<td>27</td>" +
                                    "<td>27.5</td>" +
                                    "<td>28</td>" +
                                    "<td>28.5</td>" +
                                    "<td>29</td>" +
                                    "<td>29.5</td>" +
                                    "<td>30</td>" +
                               "</tr>" +

                               "<tr>" +
                                   "<th class='size-guide-table-lead-column'>UK</th>" +

                                    "<td class=''>5</td>" +
                                    "<td class=''>5.5</td>" +
                                    "<td class=''>6</td>" +
                                    "<td class=''>6.5</td>" +
                                    "<td class=''>7</td>" +
                                    "<td class=''>7.5</td>" +
                                    "<td class=''>8</td>" +
                                    "<td class=''>8.5</td>" +
                                    "<td class=''>9</td>" +
                                    "<td class=''>9.5</td>" +
                                    "<td class=''>10</td>" +
                                    "<td class=''>10.5</td>" +
                                    "<td class=''>11</td>" +
                               "</tr>" +
                               "<tr>" +
                                    "<th class='size-guide-table-lead-column'>EU</th>" +

                                    "<td class=''>38</td>" +
                                    "<td class=''>38.5</td>" +
                                    "<td class=''>39</td>" +
                                    "<td class=''>40</td>" +
                                    "<td class=''>40.5</td>" +
                                    "<td class=''>41</td>" +
                                    "<td class=''>42</td>" +
                                    "<td class=''>42.5</td>" +
                                    "<td class=''>43</td>" +
                                    "<td class=''>44</td>" +
                                    "<td class=''>44.5</td>" +
                                    "<td class=''>45</td>" +

                                    "<td class=''>46</td>" +
                               "</tr>" +
                               "<tr>" +
                                    "<th class='size-guide-table-lead-column'>US</th>" +
                                    "<td class=''>6</td>" +
                                    "<td class=''>6.5</td>" +
                                    "<td class=''>7</td>" +
                                    "<td class=''>7.5</td>" +
                                    "<td class=''>8</td>" +
                                    "<td class=''>8.5</td>" +
                                    "<td class=''>9</td>" +
                                    "<td class=''>9.5</td>" +
                                    "<td class=''>10</td>" +
                                    "<td class=''>10.5</td>" +
                                    "<td class=''>11</td>" +
                                    "<td class=''>11.5</td>" +
                                    "<td class=''>12</td>" +
                               "</tr>" +
                           "</tbody>" +
                       "</table>";
                    }
                    else if (brands == "mizuno")
                    {
                        ltCM.Text = "";
                        ltTableSize.Text = "<table class='size-guide-measurements__table'>" +
                                "<thead>" +

                                    "<tr>" +

                                    "<th class='size-guide-table-lead-column'>Size</th>" +
                                    "<th class=''>6</th>" +
                                    "<th class=''>6.5</th>" +
                                    "<th class=''>7</th>" +
                                    "<th class=''>7.5</th>" +
                                    "<th class=''>8</th>" +
                                    "<th class=''>8.5</th>" +
                                    "<th class=''>9</th>" +
                                    "<th class=''>9.5</th>" +
                                    "<th class=''>10</th>" +
                                    "<th class=''>10.5</th>" +
                                    "<th class=''>11</th>" +
                                "</tr>" +
                            "</thead>" +
                            "<tbody>" +
                                "<tr>" +
                                   "<th class='size-guide-table-lead-column'>UK</th>" +


                                    "<td class=''>6</td>" +
                                    "<td class=''>6.5</td>" +
                                    "<td class=''>7</td>" +
                                    "<td class=''>7.5</td>" +
                                    "<td class=''>8</td>" +
                                    "<td class=''>8.5</td>" +
                                    "<td class=''>9</td>" +
                                    "<td class=''>9.5</td>" +
                                    "<td class=''>10</td>" +
                                    "<td class=''>10.5</td>" +
                                    "<td class=''>11</td>" +
                               "</tr>" +
                               "<tr>" +
                                    "<th class='size-guide-table-lead-column'>EU</th>" +


                                    "<td class=''>39</td>" +
                                    "<td class=''>40</td>" +
                                    "<td class=''>40.5</td>" +
                                    "<td class=''>41</td>" +
                                    "<td class=''>42</td>" +
                                    "<td class=''>42.5</td>" +
                                    "<td class=''>43</td>" +
                                    "<td class=''>44</td>" +
                                    "<td class=''>44.5</td>" +
                                    "<td class=''>45</td>" +

                                    "<td class=''>46</td>" +
                               "</tr>" +
                               "<tr>" +
                                    "<th class='size-guide-table-lead-column'>US</th>" +

                                    "<td class=''>7</td>" +
                                    "<td class=''>7.5</td>" +
                                    "<td class=''>8</td>" +
                                    "<td class=''>8.5</td>" +
                                    "<td class=''>9</td>" +
                                    "<td class=''>9.5</td>" +
                                    "<td class=''>10</td>" +
                                    "<td class=''>10.5</td>" +
                                    "<td class=''>11</td>" +
                                    "<td class=''>11.5</td>" +
                                    "<td class=''>12</td>" +
                               "</tr>" +
                            "</tbody>" +
                        "</table>";
                    }
                    else if (brands == "newbalance")
                    {
                        ltCM.Text = "";
                        ltTableSize.Text = "<table class='size-guide-measurements__table'>" +
                                "<thead>" +

                                    "<tr>" +

                                    "<th class='size-guide-table-lead-column'>Size</th>" +
                                    "<th class=''>6</th>" +
                                    "<th class=''>6.5</th>" +
                                    "<th class=''>7</th>" +
                                    "<th class=''>7.5</th>" +
                                    "<th class=''>8</th>" +
                                    "<th class=''>8.5</th>" +
                                    "<th class=''>9</th>" +
                                    "<th class=''>9.5</th>" +
                                    "<th class=''>10</th>" +
                                    "<th class=''>10.5</th>" +
                                    "<th class=''>11</th>" +
                                "</tr>" +
                            "</thead>" +
                            "<tbody>" +
                                "<tr>" +
                                    "<th class='size-guide-table-lead-column'>UK</th>" +


                                    "<td class=''>6</td>" +
                                    "<td class=''>6.5</td>" +
                                    "<td class=''>7</td>" +
                                    "<td class=''>7.5</td>" +
                                    "<td class=''>8</td>" +
                                    "<td class=''>8.5</td>" +
                                    "<td class=''>9</td>" +
                                    "<td class=''>9.5</td>" +
                                    "<td class=''>10</td>" +
                                    "<td class=''>10.5</td>" +
                                    "<td class=''>11</td>" +
                                "</tr>" +
                                "<tr>" +
                                    "<th class='size-guide-table-lead-column'>EU</th>" +


                                    "<td class=''>39</td>" +
                                    "<td class=''>40</td>" +
                                    "<td class=''>40.5</td>" +
                                    "<td class=''>41</td>" +
                                    "<td class=''>41.5</td>" +
                                    "<td class=''>42</td>" +
                                    "<td class=''>42.5</td>" +
                                    "<td class=''>43</td>" +
                                    "<td class=''>44</td>" +
                                    "<td class=''>44.5</td>" +
                                    "<td class=''>45</td>" +


                                "</tr>" +
                                "<tr>" +
                                    "<th class='size-guide-table-lead-column'>US</th>" +

                                    "<td class=''>6.5</td>" +
                                    "<td class=''>7</td>" +
                                    "<td class=''>7.5</td>" +
                                    "<td class=''>8</td>" +
                                    "<td class=''>8.5</td>" +
                                    "<td class=''>9</td>" +
                                    "<td class=''>9.5</td>" +
                                    "<td class=''>10</td>" +
                                    "<td class=''>10.5</td>" +
                                    "<td class=''>11</td>" +
                                    "<td class=''>11.5</td>" +

                               "</tr>" +
                            "</tbody>" +
                        "</table>";
                    }
                    else if (brands == "asics")
                    {
                        ltCM.Text = "";
                        ltTableSize.Text = "<table class='size-guide-measurements__table'>" +
                                 "<thead>" +

                                     "<tr>" +

                                     "<th class='size-guide-table-lead-column'>Size</th>" +
                                     "<th class=''>6</th>" +
                                     "<th class=''>6.5</th>" +
                                     "<th class=''>7</th>" +
                                     "<th class=''>7.5</th>" +
                                     "<th class=''>8</th>" +
                                     "<th class=''>8.5</th>" +
                                     "<th class=''>9</th>" +
                                     "<th class=''>9.5</th>" +
                                     "<th class=''>10</th>" +
                                     "<th class=''>10.5</th>" +
                                     "<th class=''>11</th>" +
                                 "</tr>" +
                             "</thead>" +
                             "<tbody>" +
                                 "<tr>" +
                                    "<th class='size-guide-table-lead-column'>UK</th>" +


                                     "<td class=''>6</td>" +
                                     "<td class=''>6.5</td>" +
                                     "<td class=''>7</td>" +
                                     "<td class=''>7.5</td>" +
                                     "<td class=''>8</td>" +
                                     "<td class=''>8.5</td>" +
                                     "<td class=''>9</td>" +
                                     "<td class=''>9.5</td>" +
                                     "<td class=''>10</td>" +
                                     "<td class=''>10.5</td>" +
                                     "<td class=''>11</td>" +
                                "</tr>" +
                                "<tr>" +
                                     "<th class='size-guide-table-lead-column'>EU</th>" +



                                     "<td class=''>40</td>" +
                                     "<td class=''>40.5</td>" +
                                     "<td class=''>41.5</td>" +
                                     "<td class=''>42</td>" +
                                     "<td class=''>42.5</td>" +
                                     "<td class=''>43.5</td>" +
                                     "<td class=''>44</td>" +
                                     "<td class=''>44.5</td>" +
                                     "<td class=''>45</td>" +

                                     "<td class=''>46</td>" +
                                     "<td class=''>46.5</td>" +
                                "</tr>" +
                                "<tr>" +
                                     "<th class='size-guide-table-lead-column'>US</th>" +

                                     "<td class=''>7</td>" +
                                     "<td class=''>7.5</td>" +
                                     "<td class=''>8</td>" +
                                     "<td class=''>8.5</td>" +
                                     "<td class=''>9</td>" +
                                     "<td class=''>9.5</td>" +
                                     "<td class=''>10</td>" +
                                     "<td class=''>10.5</td>" +
                                     "<td class=''>11</td>" +
                                     "<td class=''>11.5</td>" +
                                     "<td class=''>12</td>" +
                                "</tr>" +
                             "</tbody>" +
                         "</table>";
                    }
                    else if (brands == "kamito")
                    {
                        ltCM.Text = "CM";
                        ltTableSize.Text = "<table class='size-guide-measurements__table'>" +
                                "<thead>" +

                                    "<tr>" +

                                    "<th class='size-guide-table-lead-column'>CM</th>" +
                                    "<th class=''>18</th>" +
                                    "<th class=''>19</th>" +
                                    "<th class=''>19.5</th>" +
                                    "<th class=''>20.5</th>" +
                                    "<th class=''>21</th>" +
                                    "<th class=''>22</th>" +
                                    "<th class=''>22.5</th>" +
                                    "<th class=''>23.5</th>" +
                                    "<th class=''>24</th>" +
                                    "<th class=''>25</th>" +
                                    "<th class=''>25.5</th>" +
                                    "<th class=''>26.5</th>" +
                                    "<th class=''>27</th>" +
                                    "<th class=''>28</th>" +
                                "</tr>" +
                            "</thead>" +
                            "<tbody>" +
                            "<tr>" +
                                  "<th class='size-guide-table-lead-column'>EU</th>" +
                                    "<td>30</td>" +
                                    "<td>31</td>" +
                                    "<td>32</td>" +
                                    "<td>33</td>" +

                                    "<td>34</td>" +
                                    "<td>35</td>" +
                                    "<td>36</td>" +
                                    "<td>37</td>" +
                                    "<td>38</td>" +
                                    "<td>39</td>" +
                                    "<td>40</td>" +
                                    "<td>41</td>" +
                                    "<td>42</td>" +
                                    "<td>43</td>" +

                               "</tr>" +
                                "<tr>" +
                                    "<th class='size-guide-table-lead-column'>UK</th>" +


                                    "<td class=''>C12</td>" +
                                    "<td class=''>C13</td>" +
                                    "<td class=''>C13.5</td>" +
                                    "<td class=''>1.5</td>" +
                                    "<td class=''>2</td>" +
                                    "<td class=''>3</td>" +
                                    "<td class=''>3.5</td>" +
                                    "<td class=''>4.5</td>" +
                                    "<td class=''>5</td>" +
                                    "<td class=''>6</td>" +
                                    "<td class=''>6.5</td>" +
                                    "<td class=''>7.5</td>" +
                                    "<td class=''>8</td>" +
                                    "<td class=''>9</td>" +
                                "</tr>" +
                                "<tr>" +
                                    "<th class='size-guide-table-lead-column'>JAPAN</th>" +
                                    "<td class=''>18</td>" +
                                    "<td class=''>19</td>" +
                                    "<td class=''>19.5</td>" +
                                    "<td class=''>20.5</td>" +
                                    "<td class=''>21</td>" +
                                    "<td class=''>22</td>" +
                                    "<td class=''>22.5</td>" +
                                    "<td class=''>23.5</td>" +
                                    "<td class=''>24</td>" +
                                    "<td class=''>25</td>" +
                                    "<td class=''>25.5</td>" +
                                    "<td class=''>26.5</td>" +
                                    "<td class=''>27</td>" +
                                    "<td class=''>28</td>" +
                                "</tr>" +

                            "</tbody>" +
                        "</table>";
                    }
                }
                else if (trangphuc == "quan")
                {
                    if (brands == "adidas")
                    {
                        ltCM.Text = "CM";
                        ltTableSize.Text = "<table class='size-guide-measurements__table'>" +
                                "<thead>" +

                                    "<tr>" +

                                    "<th class='size-guide-table-lead-column'>Size</th>" +
                                    "<th class=''>XXS</th>" +
                                    "<th class=''>XS</th>" +
                                    "<th class=''>S</th>" +
                                    "<th class=''>M</th>" +
                                    "<th class=''>L</th>" +
                                    "<th class=''>XL</th>" +
                                    "<th class=''>XXL</th>" +
                                "</tr>" +
                            "</thead>" +
                            "<tbody>" +
                                "<tr>" +
                                    "<th class='size-guide-table-lead-column'>Thắt lưng</th>" +
                                    "<td>58.4 - 63.5</td>" +
                                    "<td>63.5 - 68.6</td>" +
                                    "<td>68.6 - 76.2</td>" +
                                    "<td>76.2 - 83.8</td>" +
                                    "<td>83.8 - 91.4</td>" +
                                    "<td>91.4 - 99.1</td>" +
                                    "<td>99.1 - 104.1</td>" +
                                "</tr>" +
                                "<tr>" +
                                    "<th class='size-guide-table-lead-column'>Hông</th>" +
                                    "<td>81.3 - 86.3</td>" +
                                    "<td>86.4 - 94</td>" +
                                    "<td>94 - 99.1</td>" +
                                    "<td>99.1 - 106.7</td>" +
                                    "<td>106.7 - 114.3</td>" +
                                    "<td>114.3 - 121.9</td>" +
                                    "<td>121.9 - 127</td>" +
                                "</tr>" +
                                "<tr>" +
                                    "<th class='size-guide-table-lead-column'>Chiều cao háng</th>" +
                                    "<td>76.2</td>" +
                                    "<td>76.2</td>" +
                                    "<td>76.2</td>" +
                                    "<td>78.7</td>" +
                                    "<td>78.7</td>" +
                                    "<td>78.7</td>" +
                                    "<td>81.3</td>" +
                                "</tr>" +
                            "</tbody>" +
                        "</table>";
                    }
                    else if (brands == "nike")
                    {
                        ltCM.Text = "CM";
                        ltTableSize.Text = "<table class='size-guide-measurements__table'>" +
                               "<thead>" +

                                   "<tr>" +

                                   "<th class='size-guide-table-lead-column'>Size</th>" +
                                   "<th class=''>XS</th>" +
                                   "<th class=''>S</th>" +
                                   "<th class=''>M</th>" +
                                   "<th class=''>L</th>" +
                                   "<th class=''>XL</th>" +
                                   "<th class=''>XXL</th>" +
                               "</tr>" +
                           "</thead>" +
                           "<tbody>" +
                               "<tr>" +
                                   "<th class='size-guide-table-lead-column'>Thắt lưng</th>" +
                                   "<td>60 - 67</td>" +
                                   "<td>67 - 74</td>" +
                                   "<td>74 - 81</td>" +
                                   "<td>81 - 88</td>" +
                                   "<td>88 - 98</td>" +
                                   "<td>98 - 108</td>" +
                                   
                               "</tr>" +
                               "<tr>" +
                                   "<th class='size-guide-table-lead-column'>Hông</th>" +
                                   "<td>84 - 91</td>" +
                                   "<td>91 - 98</td>" +
                                   "<td>98 - 105</td>" +
                                   "<td>105 - 112</td>" +
                                   "<td>112 - 120</td>" +
                                   "<td>120 - 128</td>" +
                                   
                               "</tr>" +
                               "<tr>" +
                                   "<th class='size-guide-table-lead-column'>Chiều cao háng</th>" +
                                   "<td>79.5</td>" +
                                   "<td>79.5</td>" +
                                   "<td>80</td>" +
                                   "<td>80</td>" +
                                   "<td>80.5</td>" +
                                   "<td>80.5</td>" +
                                   
                               "</tr>" +
                           "</tbody>" +
                       "</table>";
                    }
                    else if (brands == "puma")
                    {
                        ltCM.Text = "CM";
                        ltTableSize.Text = "<table class='size-guide-measurements__table'>" +
                               "<thead>" +

                                   "<tr>" +

                                   "<th class='size-guide-table-lead-column'>Size</th>" +
                                   "<th class=''>XXS</th>" +
                                   "<th class=''>XS</th>" +
                                   "<th class=''>S</th>" +
                                   "<th class=''>M</th>" +
                                   "<th class=''>L</th>" +
                                   "<th class=''>XL</th>" +
                                   "<th class=''>2XL</th>" +
                                   "<th class=''>3XL</th>" +
                               "</tr>" +
                           "</thead>" +
                           "<tbody>" +
                               "<tr>" +
                                   "<th class='size-guide-table-lead-column'>Thắt lưng</th>" +
                                   "<td>61</td>" +
                                   "<td>63.5</td>" +
                                   "<td>66</td>" +
                                   "<td>73.5</td>" +
                                   "<td>78.5</td>" +
                                   "<td>86.5</td>" +
                                   "<td>91.5</td>" +
                                   "<td>96.5</td>" +
                               "</tr>" +

                               "<tr>" +
                                   "<th class='size-guide-table-lead-column'>Hông</th>" +
                                   "<td>89</td>" +
                                   "<td>91.5</td>" +
                                   "<td>94</td>" +
                                   "<td>99</td>" +
                                   "<td>104</td>" +
                                   "<td>112</td>" +
                                   "<td>117</td>" +
                                   "<td>122</td>" +
                               "</tr>" +
                           "</tbody>" +
                       "</table>";
                    }
                    else if (brands == "mizuno")
                    {
                        ltCM.Text = "CM";
                        ltTableSize.Text = "<table class='size-guide-measurements__table'>" +
                                "<thead>" +

                                    "<tr>" +

                                    "<th class='size-guide-table-lead-column'>Size</th>" +

                                    "<th class=''>XS</th>" +
                                    "<th class=''>S</th>" +
                                    "<th class=''>M</th>" +
                                    "<th class=''>L</th>" +
                                    "<th class=''>XL</th>" +

                                "</tr>" +
                            "</thead>" +
                            "<tbody>" +
                                "<tr>" +
                                    "<th class='size-guide-table-lead-column'>Thắt lưng</th>" +

                                    "<td>78 - 84</td>" +
                                    "<td>85 - 91</td>" +
                                    "<td>92 - 98</td>" +
                                    "<td>99 - 105</td>" +
                                    "<td>106 - 112</td>" +

                                "</tr>" +
                                "<tr>" +
                                    "<th class='size-guide-table-lead-column'>Chiều cao</th>" +

                                    "<td>156 - 163</td>" +
                                    "<td>163 - 168</td>" +
                                    "<td>168 - 173</td>" +
                                    "<td>173 - 178</td>" +
                                    "<td>178 - 183</td>" +
                                "</tr>" +
                            "</tbody>" +
                        "</table>";
                    }
                    else if (brands == "newbalance")
                    {
                        ltCM.Text = "CM";
                        ltTableSize.Text = "<table class='size-guide-measurements__table'>" +
                                "<thead>" +

                                    "<tr>" +

                                    "<th class='size-guide-table-lead-column'>Size</th>" +
                                    "<th class=''>XS</th>" +
                                    "<th class=''>S</th>" +
                                    "<th class=''>M</th>" +
                                    "<th class=''>L</th>" +
                                    "<th class=''>XL</th>" +
                                    "<th class=''>2XL</th>" +
                                   
                                "</tr>" +
                            "</thead>" +
                            "<tbody>" +
                                "<tr>" +
                                    "<th class='size-guide-table-lead-column'>Thắt lưng</th>" +
                                    "<td>83 - 89</td>" +
                                    "<td>89 - 96</td>" +
                                    "<td>96 - 101</td>" +
                                    "<td>101 - 109</td>" +
                                    "<td>109 - 119</td>" +
                                    "<td>119 - 127</td>" +
                                    
                                "</tr>" +

                            "</tbody>" +
                        "</table>";
                    }
                    else if (brands == "asics")
                    {
                        ltCM.Text = "CM";
                        ltTableSize.Text = "<table class='size-guide-measurements__table'>" +
                                                      "<thead>" +

                                                          "<tr>" +

                                                          "<th class='size-guide-table-lead-column'>Size</th>" +
                                                          "<th class=''>XXS</th>" +
                                                          "<th class=''>XS</th>" +
                                                          "<th class=''>S</th>" +
                                                          "<th class=''>M</th>" +
                                                          "<th class=''>L</th>" +
                                                          "<th class=''>XL</th>" +
                                                          "<th class=''>XXL</th>" +
                                                      "</tr>" +
                                                  "</thead>" +
                                                  "<tbody>" +
                                                      "<tr>" +
                                                          "<th class='size-guide-table-lead-column'>Thắt lưng</th>" +
                                                          "<td>82 - 86</td>" +
                                                          "<td>86 - 91</td>" +
                                                          "<td>91 - 97</td>" +
                                                          "<td>97 - 103</td>" +
                                                          "<td>103 - 110</td>" +
                                                          "<td>110 - 117</td>" +
                                                          "<td>117 - 125</td>" +
                                                          
                                                      "</tr>" +
                                                      
                                                  "</tbody>" +
                                              "</table>";
                    }
                    else if (brands == "kamito")
                    {
                        ltCM.Text = "CM";
                        ltTableSize.Text = "<table class='size-guide-measurements__table'>" +
                                "<thead>" +

                                    "<tr>" +

                                    "<th class='size-guide-table-lead-column'>Size</th>" +

                                    "<th class=''>S</th>" +
                                    "<th class=''>M</th>" +
                                    "<th class=''>L</th>" +
                                    "<th class=''>XL</th>" +
                                   

                                "</tr>" +
                            "</thead>" +
                            "<tbody>" +
                                 "<tr>" +
                                    "<th class='size-guide-table-lead-column'>Chiều cao</th>" +
                                    "<td>150 - 155</td>" +
                                    "<td>155 - 160</td>" +
                                    "<td>160 - 165</td>" +
                                    "<td>165 - 170</td>" +
                                "</tr>" +
                                "<tr>" +
                                    "<th class='size-guide-table-lead-column'>Cân nặng</th>" +
                                    "<td>40 - 45 KG</td>" +
                                    "<td>45 - 50 KG</td>" +
                                  
                                    "<td>55 - 60 KG</td>" +
                                    "<td>60 - 65 KG</td>" +

                                "</tr>" +
                            "</tbody>" +
                        "</table>";
                    }
                }
                else if (trangphuc == "giay-the-thao")
                {
                    if (brands == "adidas")
                    {
                        ltCM.Text = "CM";
                        ltTableSize.Text = "<table class='size-guide-measurements__table'>" +
                                "<thead>" +

                                    "<tr>" +

                                    "<th class='size-guide-table-lead-column'>Size</th>" +
                                    "<th class=''>3.5</th>" +
                                    "<th class=''>4</th>" +
                                    "<th class=''>4.5</th>" +
                                    "<th class=''>5</th>" +
                                    "<th class=''>5.5</th>" +
                                    "<th class=''>6</th>" +
                                    "<th class=''>6.5</th>" +
                                    "<th class=''>7</th>" +
                                    "<th class=''>7.5</th>" +
                                    "<th class=''>8</th>" +
                                    "<th class=''>8.5</th>" +
                                   
                                "</tr>" +
                            "</thead>" +
                            "<tbody>" +
                                "<tr>" +
                                    "<th class='size-guide-table-lead-column'>Chiều dài bàn chân</th>" +
                                    "<td>22.1</td>" +
                                    "<td>22.5</td>" +
                                    "<td>22.9</td>" +
                                    "<td>23.3</td>" +
                                    "<td>23.8</td>" +
                                    "<td>24.2</td>" +
                                    "<td>24.6</td>" +
                                    "<td>25</td>" +
                                    "<td>25.5</td>" +
                                    "<td>25.9</td>" +
                                    "<td>26.3</td>" +
                                    
                                "</tr>" +
                                "<tr>" +
                                    "<th class='size-guide-table-lead-column'>UK</th>" +
                                    "<td class=''>3.5</td>" +
                                    "<td class=''>4</td>" +
                                    "<td class=''>4.5</td>" +
                                    "<td class=''>5</td>" +
                                    "<td class=''>5.5</td>" +
                                    "<td class=''>6</td>" +
                                    "<td class=''>6.5</td>" +
                                    "<td class=''>7</td>" +
                                    "<td class=''>7.5</td>" +
                                    "<td class=''>8</td>" +
                                    "<td class=''>8.5</td>" +
                                    
                                "</tr>" +
                                "<tr>" +
                                    "<th class='size-guide-table-lead-column'>EU</th>" +
                                    "<td class=''>36</td>" +
                                    "<td class=''>36.66</td>" +
                                    "<td class=''>37.33</td>" +
                                    "<td class=''>38</td>" +
                                    "<td class=''>38.66</td>" +
                                    "<td class=''>39.33</td>" +
                                    "<td class=''>40</td>" +
                                    "<td class=''>40.66</td>" +
                                    "<td class=''>41.33</td>" +
                                    "<td class=''>42</td>" +
                                    "<td class=''>42.66</td>" +
                                    
                                "</tr>" +
                                "<tr>" +
                                    "<th class='size-guide-table-lead-column'>US</th>" +
                                   
                                    "<td class=''>5</td>" +
                                    "<td class=''>5.5</td>" +
                                    "<td class=''>6</td>" +
                                    "<td class=''>6.5</td>" +
                                    "<td class=''>7</td>" +
                                    "<td class=''>7.5</td>" +
                                    "<td class=''>8</td>" +
                                    "<td class=''>8.5</td>" +
                                    "<td class=''>9</td>" +
                                    "<td class=''>9.5</td>" +
                                    "<td class=''>10</td>" +
                                   
                                "</tr>" +
                            "</tbody>" +
                        "</table>";
                    }
                    else if (brands == "nike")
                    {
                        ltCM.Text = "CM";
                        ltTableSize.Text = "<table class='size-guide-measurements__table'>" +
                               "<thead>" +
                                   "<tr>" +
                                   "<th class='size-guide-table-lead-column'>Size</th>" +
                                   "<th class=''>3</th>" +
                                    "<th class=''>3.5</th>" +
                                    "<th class=''>4</th>" +
                                    "<th class=''>4.5</th>" +
                                    "<th class=''>5</th>" +
                                    "<th class=''>5.5</th>" +
                                    "<th class=''>6</th>" +
                                    "<th class=''>6.5</th>" +
                                    "<th class=''>7</th>" +
                                    "<th class=''>7.5</th>" +
                                    "<th class=''>8</th>" +
                                    "<th class=''>8.5</th>" +
                                    "<th class=''>9</th>" +
                                    "<th class=''>9.5</th>" +
                                    
                               "</tr>" +
                           "</thead>" +
                           "<tbody>" +
                               "<tr>" +
                                  "<th class='size-guide-table-lead-column'>Chiều dài bàn chân</th>" +
                                    "<td>22.5</td>" +
                                    "<td>23</td>" +
                                    "<td>23.5</td>" +
                                    "<td>24</td>" +
                                    "<td>24.5</td>" +
                                    "<td>25</td>" +
                                    "<td>25.5</td>" +
                                    "<td>26</td>" +
                                    "<td>26.5</td>" +
                                    "<td>27</td>" +
                                    "<td>27.5</td>" +
                                    "<td>28</td>" +
                                    "<td>28.5</td>" +
                                    "<td>29</td>" +
                                    
                               "</tr>" +
                               "<tr>" +
                                   "<th class='size-guide-table-lead-column'>UK</th>" +
                                    "<td class=''>3</td>" +
                                    "<td class=''>3.5</td>" +
                                    "<td class=''>4</td>" +
                                    "<td class=''>4.5</td>" +
                                    "<td class=''>5</td>" +
                                    "<td class=''>5.5</td>" +
                                    "<td class=''>6</td>" +
                                    "<td class=''>6.5</td>" +
                                    "<td class=''>7</td>" +
                                    "<td class=''>7.5</td>" +
                                    "<td class=''>8</td>" +
                                    "<td class=''>8.5</td>" +
                                    "<td class=''>9</td>" +
                                    "<td class=''>9.5</td>" +
                               "</tr>" +
                               "<tr>" +
                                    "<th class='size-guide-table-lead-column'>EU</th>" +
                                    "<td class=''>36</td>" +
                                    "<td class=''>36.5</td>" +
                                    "<td class=''>37.5</td>" +
                                    "<td class=''>38</td>" +
                                    "<td class=''>38.5</td>" +
                                    "<td class=''>39</td>" +
                                    "<td class=''>40</td>" +
                                    "<td class=''>40.5</td>" +
                                    "<td class=''>41</td>" +
                                    "<td class=''>42</td>" +
                                    "<td class=''>42.5</td>" +
                                    "<td class=''>43</td>" +
                                    "<td class=''>44</td>" +
                                    "<td class=''>44.5</td>" +
                               "</tr>" +
                                "<tr>" +
                                    "<th class='size-guide-table-lead-column'>US</th>" +
                                    "<td class=''>5.5</td>" +
                                    "<td class=''>6</td>" +
                                    "<td class=''>6.5</td>" +
                                    "<td class=''>7</td>" +
                                    "<td class=''>7.5</td>" +
                                    "<td class=''>8</td>" +
                                    "<td class=''>8.5</td>" +
                                    "<td class=''>9</td>" +
                                    "<td class=''>9.5</td>" +
                                    "<td class=''>10</td>" +
                                    "<td class=''>10.5</td>" +
                                    "<td class=''>11</td>" +
                                    "<td class=''>11.5</td>" +
                                    "<td class=''>12</td>" +
                               "</tr>" +
                           "</tbody>" +
                       "</table>";
                    }
                    else if (brands == "puma")
                    {
                        ltCM.Text = "CM";
                        ltTableSize.Text = "<table class='size-guide-measurements__table'>" +
                               "<thead>" +
                                   "<tr>" +
                                    "<th class='size-guide-table-lead-column'>Size</th>" +
                                    "<th class=''>2.5</th>" +
                                    "<th class=''>3</th>" +
                                    "<th class=''>3.5</th>" +
                                    "<th class=''>4</th>" +
                                    "<th class=''>4.5</th>" +
                                    "<th class=''>5</th>" +
                                    "<th class=''>5.5</th>" +
                                    "<th class=''>6</th>" +
                                    "<th class=''>6.5</th>" +
                                    "<th class=''>7</th>" +
                                    "<th class=''>7.5</th>" +
                                    "<th class=''>8</th>" +
                                    "<th class=''>8.5</th>" +
                               "</tr>" +
                           "</thead>" +
                           "<tbody>" +
                               "<tr>" +
                                   "<th class='size-guide-table-lead-column'>Chiều dài bàn chân</th>" +
                                    "<td>21.5</td>" +
                                    "<td>22</td>" +
                                    "<td>22.5</td>" +
                                    "<td>23</td>" +

                                    "<td>23.5</td>" +
                                    "<td>24</td>" +
                                    "<td>24.5</td>" +
                                    "<td>25</td>" +
                                    "<td>25.5</td>" +
                                    "<td>26</td>" +
                                    "<td>26.5</td>" +
                                    "<td>27</td>" +
                                    "<td>27.5</td>" +
                               "</tr>" +

                               "<tr>" +
                                   "<th class='size-guide-table-lead-column'>UK</th>" +

                                    "<td class=''>2.5</td>" +
                                    "<td class=''>3</td>" +
                                    "<td class=''>3.5</td>" +
                                    "<td class=''>4</td>" +
                                    "<td class=''>4.5</td>" +
                                    "<td class=''>5</td>" +
                                    "<td class=''>5.5</td>" +
                                    "<td class=''>6</td>" +
                                    "<td class=''>6.5</td>" +
                                    "<td class=''>7</td>" +
                                    "<td class=''>7.5</td>" +
                                    "<td class=''>8</td>" +
                                    "<td class=''>8.5</td>" +
                               "</tr>" +
                               "<tr>" +
                                    "<th class='size-guide-table-lead-column'>EU</th>" +
                                    "<td class=''>35</td>" +
                                    "<td class=''>35.5</td>" +
                                    "<td class=''>36</td>" +
                                    "<td class=''>37</td>" +
                                    "<td class=''>37.5</td>" +
                                    "<td class=''>38</td>" +
                                    "<td class=''>38.5</td>" +
                                    "<td class=''>39</td>" +
                                    "<td class=''>40</td>" +
                                    "<td class=''>40.5</td>" +
                                    "<td class=''>41</td>" +
                                    "<td class=''>42</td>" +
                                    "<td class=''>42.5</td>" +
                               "</tr>" +
                               "<tr>" +
                                    "<th class='size-guide-table-lead-column'>US</th>" +
                                    "<td class=''>5</td>" +
                                    "<td class=''>5.5</td>" +
                                    "<td class=''>6</td>" +
                                    "<td class=''>6.5</td>" +
                                    "<td class=''>7</td>" +
                                    "<td class=''>7.5</td>" +
                                    "<td class=''>8</td>" +
                                    "<td class=''>8.5</td>" +
                                    "<td class=''>9</td>" +
                                    "<td class=''>9.5</td>" +
                                    "<td class=''>10</td>" +
                                    "<td class=''>10.5</td>" +
                                    "<td class=''>11</td>" +
                               "</tr>" +
                           "</tbody>" +
                       "</table>";
                    }
                    else if (brands == "mizuno")
                    {
                        ltCM.Text = "";
                        ltTableSize.Text = "<table class='size-guide-measurements__table'>" +
                                "<thead>" +

                                    "<tr>" +

                                    "<th class='size-guide-table-lead-column'>Size</th>" +
                                    "<th class=''>2.5</th>" +
                                    "<th class=''>3</th>" +
                                    "<th class=''>3.5</th>" +
                                    "<th class=''>4</th>" +
                                    "<th class=''>4.5</th>" +
                                    "<th class=''>5</th>" +
                                    "<th class=''>5.5</th>" +
                                    "<th class=''>6</th>" +
                                    "<th class=''>6.5</th>" +
                                    "<th class=''>7</th>" +
                                    "<th class=''>7.5</th>" +
                                    "<th class=''>8</th>" +
                                "</tr>" +
                            "</thead>" +
                            "<tbody>" +
                                "<tr>" +
                                   "<th class='size-guide-table-lead-column'>UK</th>" +
                                    "<td class=''>2.5</td>" +
                                    "<td class=''>3</td>" +
                                    "<td class=''>3.5</td>" +
                                    "<td class=''>4</td>" +
                                    "<td class=''>4.5</td>" +
                                    "<td class=''>5</td>" +
                                    "<td class=''>5.5</td>" +
                                    "<td class=''>6</td>" +
                                    "<td class=''>6.5</td>" +
                                    "<td class=''>7</td>" +
                                    "<td class=''>7.5</td>" +
                                    "<td class=''>8</td>" +
                               "</tr>" +
                               "<tr>" +
                                    "<th class='size-guide-table-lead-column'>EU</th>" +
                                    "<td class=''>35</td>" +
                                    "<td class=''>35.5</td>" +
                                    "<td class=''>36</td>" +
                                    "<td class=''>37</td>" +
                                    "<td class=''>37.5</td>" +
                                    "<td class=''>38</td>" +
                                    "<td class=''>38.5</td>" +
                                    "<td class=''>39</td>" +
                                    "<td class=''>40</td>" +
                                    "<td class=''>40.5</td>" +
                                    "<td class=''>41</td>" +
                                    "<td class=''>42</td>" +
                               "</tr>" +
                               "<tr>" +
                                    "<th class='size-guide-table-lead-column'>US</th>" +
                                    "<td class=''>5</td>" +
                                    "<td class=''>5.5</td>" +
                                    "<td class=''>6</td>" +
                                    "<td class=''>6.5</td>" +
                                    "<td class=''>7</td>" +
                                    "<td class=''>7.5</td>" +
                                    "<td class=''>8</td>" +
                                    "<td class=''>8.5</td>" +
                                    "<td class=''>9</td>" +
                                    "<td class=''>9.5</td>" +
                                    "<td class=''>10</td>" +
                                    "<td class=''>10.5</td>" +
                               "</tr>" +
                            "</tbody>" +
                        "</table>";
                    }
                    else if (brands == "newbalance")
                    {
                        ltCM.Text = "";
                        ltTableSize.Text = "<table class='size-guide-measurements__table'>" +
                                "<thead>" +

                                    "<tr>" +

                                    "<th class='size-guide-table-lead-column'>Size</th>" +
                                    "<th class=''>3.5</th>" +
                                    "<th class=''>4</th>" +
                                    "<th class=''>4.5</th>" +
                                    "<th class=''>5</th>" +
                                    "<th class=''>5.5</th>" +
                                    "<th class=''>6</th>" +
                                    "<th class=''>6.5</th>" +
                                    "<th class=''>7</th>" +
                                    "<th class=''>7.5</th>" +
                                    "<th class=''>8</th>" +
                                    "<th class=''>8.5</th>" +
                                "</tr>" +
                            "</thead>" +
                            "<tbody>" +
                                "<tr>" +
                                    "<th class='size-guide-table-lead-column'>UK</th>" +
                                    "<td class=''>3.5</td>" +
                                    "<td class=''>4</td>" +
                                    "<td class=''>4.5</td>" +
                                    "<td class=''>5</td>" +
                                    "<td class=''>5.5</td>" +
                                    "<td class=''>6</td>" +
                                    "<td class=''>6.5</td>" +
                                    "<td class=''>7</td>" +
                                    "<td class=''>7.5</td>" +
                                    "<td class=''>8</td>" +
                                    "<td class=''>8.5</td>" +
                                "</tr>" +
                                "<tr>" +
                                    "<th class='size-guide-table-lead-column'>EU</th>" +
                                    "<td class=''>36</td>" +
                                    "<td class=''>36.5</td>" +
                                    "<td class=''>37</td>" +
                                    "<td class=''>37.5</td>" +
                                    "<td class=''>38</td>" +
                                    "<td class=''>39</td>" +
                                    
                                    "<td class=''>40</td>" +
                                    "<td class=''>40.5</td>" +
                                    "<td class=''>41</td>" +
                                    "<td class=''>41.5</td>" +
                                    "<td class=''>42.5</td>" +
                                "</tr>" +
                                "<tr>" +
                                    "<th class='size-guide-table-lead-column'>US</th>" +
                                    
                                    "<td class=''>5.5</td>" +
                                    "<td class=''>6</td>" +
                                    "<td class=''>6.5</td>" +
                                    "<td class=''>7</td>" +
                                    "<td class=''>7.5</td>" +
                                    "<td class=''>8</td>" +
                                    "<td class=''>8.5</td>" +
                                    "<td class=''>9</td>" +
                                    "<td class=''>9.5</td>" +
                                    "<td class=''>10</td>" +
                                    "<td class=''>10.5</td>" +
                               "</tr>" +
                            "</tbody>" +
                        "</table>";
                    }
                    else if (brands == "asics")
                    {
                        ltCM.Text = "";
                        ltTableSize.Text = "<table class='size-guide-measurements__table'>" +
                                 "<thead>" +

                                     "<tr>" +

                                     "<th class='size-guide-table-lead-column'>Size</th>" +
                                     "<th class=''>3</th>" +
                                    "<th class=''>3.5</th>" +
                                    "<th class=''>4</th>" +
                                    "<th class=''>4.5</th>" +
                                    "<th class=''>5</th>" +
                                    "<th class=''>5.5</th>" +
                                    "<th class=''>6</th>" +
                                    "<th class=''>6.5</th>" +
                                    "<th class=''>7</th>" +
                                    "<th class=''>7.5</th>" +
                                    "<th class=''>8</th>" +
                                    "<th class=''>8.5</th>" +
                                     
                                 "</tr>" +
                             "</thead>" +
                             "<tbody>" +
                                 "<tr>" +
                                    "<th class='size-guide-table-lead-column'>UK</th>" +


                                     "<td class=''>6</td>" +
                                     "<td class=''>6.5</td>" +
                                     "<td class=''>7</td>" +
                                     "<td class=''>7.5</td>" +
                                     "<td class=''>8</td>" +
                                     "<td class=''>8.5</td>" +
                                     "<td class=''>9</td>" +
                                     "<td class=''>9.5</td>" +
                                     "<td class=''>10</td>" +
                                     "<td class=''>10.5</td>" +
                                     "<td class=''>11</td>" +
                                "</tr>" +
                                "<tr>" +
                                    "<th class='size-guide-table-lead-column'>EU</th>" +
                                    "<td class=''>35.5</td>" +
                                    
                                    "<td class=''>36</td>" +
                                    "<td class=''>37</td>" +
                                    "<td class=''>37.5</td>" +
                                    "<td class=''>38</td>" +
                                   
                                    "<td class=''>39</td>" +
                                     "<td class=''>39.5</td>" +
                                    "<td class=''>40</td>" +
                                    "<td class=''>40.5</td>" +
                                    "<td class=''>41.5</td>" +
                                    "<td class=''>42</td>" +
                                    "<td class=''>42.5</td>" +
                                "</tr>" +
                                "<tr>" +
                                     "<th class='size-guide-table-lead-column'>US</th>" +
                                     "<td class=''>5</td>" +
                                     "<td class=''>5.5</td>" +
                                     "<td class=''>6</td>" +
                                     "<td class=''>6.5</td>" +
                                     "<td class=''>7</td>" +
                                     "<td class=''>7.5</td>" +
                                     "<td class=''>8</td>" +
                                     "<td class=''>8.5</td>" +
                                     "<td class=''>9</td>" +
                                     "<td class=''>9.5</td>" +
                                     "<td class=''>10</td>" +
                                     "<td class=''>10.5</td>" +
                                    
                                "</tr>" +
                             "</tbody>" +
                         "</table>";
                    }
                    else if (brands == "kamito")
                    {
                        ltCM.Text = "CM";
                        ltTableSize.Text = "<table class='size-guide-measurements__table'>" +
                                "<thead>" +

                                    "<tr>" +

                                    "<th class='size-guide-table-lead-column'>CM</th>" +
                                    "<th class=''>18</th>" +
                                    "<th class=''>19</th>" +
                                    "<th class=''>19.5</th>" +
                                    "<th class=''>20.5</th>" +
                                    "<th class=''>21</th>" +
                                    "<th class=''>22</th>" +
                                    "<th class=''>22.5</th>" +
                                    "<th class=''>23.5</th>" +
                                    "<th class=''>24</th>" +
                                    "<th class=''>25</th>" +
                                    "<th class=''>25.5</th>" +
                                    "<th class=''>26.5</th>" +
                                    "<th class=''>27</th>" +
                                    "<th class=''>28</th>" +
                                "</tr>" +
                            "</thead>" +
                            "<tbody>" +
                            "<tr>" +
                                  "<th class='size-guide-table-lead-column'>EU</th>" +
                                    "<td>30</td>" +
                                    "<td>31</td>" +
                                    "<td>32</td>" +
                                    "<td>33</td>" +

                                    "<td>34</td>" +
                                    "<td>35</td>" +
                                    "<td>36</td>" +
                                    "<td>37</td>" +
                                    "<td>38</td>" +
                                    "<td>39</td>" +
                                    "<td>40</td>" +
                                    "<td>41</td>" +
                                    "<td>42</td>" +
                                    "<td>43</td>" +

                               "</tr>" +
                                "<tr>" +
                                    "<th class='size-guide-table-lead-column'>UK</th>" +


                                    "<td class=''>C12</td>" +
                                    "<td class=''>C13</td>" +
                                    "<td class=''>C13.5</td>" +
                                    "<td class=''>1.5</td>" +
                                    "<td class=''>2</td>" +
                                    "<td class=''>3</td>" +
                                    "<td class=''>3.5</td>" +
                                    "<td class=''>4.5</td>" +
                                    "<td class=''>5</td>" +
                                    "<td class=''>6</td>" +
                                    "<td class=''>6.5</td>" +
                                    "<td class=''>7.5</td>" +
                                    "<td class=''>8</td>" +
                                    "<td class=''>9</td>" +
                                "</tr>" +
                                "<tr>" +
                                    "<th class='size-guide-table-lead-column'>JAPAN</th>" +
                                    "<td class=''>18</td>" +
                                    "<td class=''>19</td>" +
                                    "<td class=''>19.5</td>" +
                                    "<td class=''>20.5</td>" +
                                    "<td class=''>21</td>" +
                                    "<td class=''>22</td>" +
                                    "<td class=''>22.5</td>" +
                                    "<td class=''>23.5</td>" +
                                    "<td class=''>24</td>" +
                                    "<td class=''>25</td>" +
                                    "<td class=''>25.5</td>" +
                                    "<td class=''>26.5</td>" +
                                    "<td class=''>27</td>" +
                                    "<td class=''>28</td>" +
                                "</tr>" +

                            "</tbody>" +
                        "</table>";
                    }
                }
            }
            if(gioitinh == "tre-em")
            {
                if (trangphuc == "ao")
                {
                   
                        ltCM.Text = "CM";
                        ltTableSize.Text = "<table class='size-guide-measurements__table'>" +
                                "<thead>" +

                                    "<tr>" +

                                    "<th class='size-guide-table-lead-column'>Size</th>" +
                                    "<th class=''>6</th>" +
                                    "<th class=''>7</th>" +
                                    "<th class=''>8</th>" +
                                    "<th class=''>9</th>" +
                                    "<th class=''>10</th>" +
                                    "<th class=''>11</th>" +
                                    "<th class=''>12</th>" +
                                    "<th class=''>14</th>" +
                                "</tr>" +
                            "</thead>" +
                            "<tbody>" +
                                "<tr>" +
                                    "<th class='size-guide-table-lead-column'>Chiều cao</th>" +
                                    "<td>114 - 122</td>" +
                                    "<td>122 - 130</td>" +
                                    "<td>130 - 135</td>" +
                                    "<td>135 - 140</td>" +
                                    "<td>140 - 145</td>" +
                                    "<td>145 - 150</td>" +
                                    "<td>150 - 153</td>" +
                                    "<td>153 - 157</td>" +
                                "</tr>" +
                                "<tr>" +
                                    "<th class='size-guide-table-lead-column'>Cân nặng</th>" +
                                    "<td>18 - 20 KG</td>" +
                                    "<td>20 - 23 KG</td>" +
                                    "<td>23 - 26 KG</td>" +
                                    "<td>26 - 29 KG</td>" +
                                    "<td>29 - 32 KG</td>" +
                                    "<td>32 - 35 KG</td>" +
                                    "<td>35 - 38 KG</td>" +
                                    "<td>38 - 42 KG</td>" +
                                "</tr>" +
                            "</tbody>" +
                        "</table>";
                   
                }
                else if (trangphuc == "giay-bong-da")
                {

                    ltCM.Text = "CM";
                    ltTableSize.Text = "<table class='size-guide-measurements__table'>" +
                            "<thead>" +

                                "<tr>" +

                                "<th class='size-guide-table-lead-column'>CM</th>" +
                                "<th class=''>18</th>" +
                                "<th class=''>19</th>" +
                                "<th class=''>19.5</th>" +
                                "<th class=''>20.5</th>" +
                                "<th class=''>21</th>" +
                                "<th class=''>22</th>" +
                                "<th class=''>22.5</th>" +
                                "<th class=''>23.5</th>" +
                                "<th class=''>24</th>" +
                                "<th class=''>25</th>" +
                                "<th class=''>25.5</th>" +
                                "<th class=''>26.5</th>" +
                                "<th class=''>27</th>" +
                                "<th class=''>28</th>" +
                            "</tr>" +
                        "</thead>" +
                        "<tbody>" +
                        "<tr>" +
                              "<th class='size-guide-table-lead-column'>EU</th>" +
                                "<td>30</td>" +
                                "<td>31</td>" +
                                "<td>32</td>" +
                                "<td>33</td>" +

                                "<td>34</td>" +
                                "<td>35</td>" +
                                "<td>36</td>" +
                                "<td>37</td>" +
                                "<td>38</td>" +
                                "<td>39</td>" +
                                "<td>40</td>" +
                                "<td>41</td>" +
                                "<td>42</td>" +
                                "<td>43</td>" +

                           "</tr>" +
                            "<tr>" +
                                "<th class='size-guide-table-lead-column'>UK</th>" +


                                "<td class=''>C12</td>" +
                                "<td class=''>C13</td>" +
                                "<td class=''>C13.5</td>" +
                                "<td class=''>1.5</td>" +
                                "<td class=''>2</td>" +
                                "<td class=''>3</td>" +
                                "<td class=''>3.5</td>" +
                                "<td class=''>4.5</td>" +
                                "<td class=''>5</td>" +
                                "<td class=''>6</td>" +
                                "<td class=''>6.5</td>" +
                                "<td class=''>7.5</td>" +
                                "<td class=''>8</td>" +
                                "<td class=''>9</td>" +
                            "</tr>" +
                            "<tr>" +
                                "<th class='size-guide-table-lead-column'>JAPAN</th>" +
                                "<td class=''>18</td>" +
                                "<td class=''>19</td>" +
                                "<td class=''>19.5</td>" +
                                "<td class=''>20.5</td>" +
                                "<td class=''>21</td>" +
                                "<td class=''>22</td>" +
                                "<td class=''>22.5</td>" +
                                "<td class=''>23.5</td>" +
                                "<td class=''>24</td>" +
                                "<td class=''>25</td>" +
                                "<td class=''>25.5</td>" +
                                "<td class=''>26.5</td>" +
                                "<td class=''>27</td>" +
                                "<td class=''>28</td>" +
                            "</tr>" +

                        "</tbody>" +
                    "</table>";
                }
                else if (trangphuc == "quan")
                {

                    ltCM.Text = "CM";
                    ltTableSize.Text = "<table class='size-guide-measurements__table'>" +
                            "<thead>" +

                                "<tr>" +

                                "<th class='size-guide-table-lead-column'>Size</th>" +
                                "<th class=''>6</th>" +
                                "<th class=''>7</th>" +
                                "<th class=''>8</th>" +
                                "<th class=''>9</th>" +
                                "<th class=''>10</th>" +
                                "<th class=''>11</th>" +
                                "<th class=''>12</th>" +
                                "<th class=''>14</th>" +
                            "</tr>" +
                        "</thead>" +
                        "<tbody>" +
                            "<tr>" +
                                "<th class='size-guide-table-lead-column'>Chiều cao</th>" +
                                "<td>114 - 122</td>" +
                                "<td>122 - 130</td>" +
                                "<td>130 - 135</td>" +
                                "<td>135 - 140</td>" +
                                "<td>140 - 145</td>" +
                                "<td>145 - 150</td>" +
                                "<td>150 - 153</td>" +
                                "<td>153 - 157</td>" +
                            "</tr>" +
                            "<tr>" +
                                "<th class='size-guide-table-lead-column'>Cân nặng</th>" +
                                "<td>18 - 20 KG</td>" +
                                "<td>20 - 23 KG</td>" +
                                "<td>23 - 26 KG</td>" +
                                "<td>26 - 29 KG</td>" +
                                "<td>29 - 32 KG</td>" +
                                "<td>32 - 35 KG</td>" +
                                "<td>35 - 38 KG</td>" +
                                "<td>38 - 42 KG</td>" +
                            "</tr>" +
                        "</tbody>" +
                    "</table>";


                }
                else if (trangphuc == "giay-the-thao")
                {

                    ltCM.Text = "CM";
                    ltTableSize.Text = "<table class='size-guide-measurements__table'>" +
                            "<thead>" +

                                "<tr>" +

                                "<th class='size-guide-table-lead-column'>CM</th>" +
                                "<th class=''>18</th>" +
                                "<th class=''>19</th>" +
                                "<th class=''>19.5</th>" +
                                "<th class=''>20.5</th>" +
                                "<th class=''>21</th>" +
                                "<th class=''>22</th>" +
                                "<th class=''>22.5</th>" +
                                "<th class=''>23.5</th>" +
                                "<th class=''>24</th>" +
                                "<th class=''>25</th>" +
                                "<th class=''>25.5</th>" +
                                "<th class=''>26.5</th>" +
                                "<th class=''>27</th>" +
                                "<th class=''>28</th>" +
                            "</tr>" +
                        "</thead>" +
                        "<tbody>" +
                        "<tr>" +
                              "<th class='size-guide-table-lead-column'>EU</th>" +
                                "<td>30</td>" +
                                "<td>31</td>" +
                                "<td>32</td>" +
                                "<td>33</td>" +

                                "<td>34</td>" +
                                "<td>35</td>" +
                                "<td>36</td>" +
                                "<td>37</td>" +
                                "<td>38</td>" +
                                "<td>39</td>" +
                                "<td>40</td>" +
                                "<td>41</td>" +
                                "<td>42</td>" +
                                "<td>43</td>" +

                           "</tr>" +
                            "<tr>" +
                                "<th class='size-guide-table-lead-column'>UK</th>" +

                                "<td class=''>C12</td>" +
                                "<td class=''>C13</td>" +
                                "<td class=''>C13.5</td>" +
                                "<td class=''>1.5</td>" +
                                "<td class=''>2</td>" +
                                "<td class=''>3</td>" +
                                "<td class=''>3.5</td>" +
                                "<td class=''>4.5</td>" +
                                "<td class=''>5</td>" +
                                "<td class=''>6</td>" +
                                "<td class=''>6.5</td>" +
                                "<td class=''>7.5</td>" +
                                "<td class=''>8</td>" +
                                "<td class=''>9</td>" +
                            "</tr>" +
                            "<tr>" +
                                "<th class='size-guide-table-lead-column'>JAPAN</th>" +
                                "<td class=''>18</td>" +
                                "<td class=''>19</td>" +
                                "<td class=''>19.5</td>" +
                                "<td class=''>20.5</td>" +
                                "<td class=''>21</td>" +
                                "<td class=''>22</td>" +
                                "<td class=''>22.5</td>" +
                                "<td class=''>23.5</td>" +
                                "<td class=''>24</td>" +
                                "<td class=''>25</td>" +
                                "<td class=''>25.5</td>" +
                                "<td class=''>26.5</td>" +
                                "<td class=''>27</td>" +
                                "<td class=''>28</td>" +
                            "</tr>" +

                        "</tbody>" +
                    "</table>";
                }
            }
        }
    }
}