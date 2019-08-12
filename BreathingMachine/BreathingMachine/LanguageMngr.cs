using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreathingMachine
{
    class LanguageMngr
    {
        public static LANGUAGE m_language=LANGUAGE.CHINA;  //0-中文,1-英语，，其它待添加
        public string set()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "设置";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "Set";
            }
            else
            {
                //return "";
                return "设置";
            }
        }
        public string help()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "帮助";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "Help";
            }
            else
            {
                //return "";
                return "Help";
            }
        }

        public string soft_ver()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "软件版本：";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "Soft ver.：";
            }
            else
            {
                //return "";
                return "Soft ver.：";
            }
        }

        public string language()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "语言";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "Language";
            }
            else
            {
                //return "";
                return "Language";
            }
        }

        public string chinese()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "中文";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "Chinese";
            }
            else
            {
                //return "";
                return "Chinese";
            }
        }

        public string english()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "英文";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "English";
            }
            else
            {
                //return "";
                return "English";
            }
        }

        public string importData()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "导入数据";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "Import Data";
            }
            else
            {
                //return "";
                return "Import Data";
            }
        }
        public string exportData()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "导出数据";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "Export Data";
            }
            else
            {
                //return "";
                return "Export Data";
            }
        }

        public string advanceMode()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "高级模式";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "Advance Mode";
            }
            else
            {
                //return "";
                return "Advance Mode";
            }
        }

        public string showAllWorkData()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "显示所有工作数据";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "Show All Work Data";
            }
            else
            {
                //return "";
                return "Show All Work Data";
            }
        }
        public string timePeriodSet()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "时段设置";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "Time Setting";
            }
            else
            {
                //return "";
                return "Time Setting";
            }
        }

        public string startDate()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "开始时间";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "Start Date";
            }
            else
            {
                //return "";
                return "Start Date";
            }
        }
        public string endDate()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "结束时间";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "End Date";
            }
            else
            {
                //return "";
                return "End Date";
            }
        }

        public string basicInfo()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "基本信息";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "Basic Info.";
            }
            else
            {
                //return "";
                return "Basic Info.";
            }
        }

        public string usageTime()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "使用时间";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "Usage Time";
            }
            else
            {
                //return "";
                return "Usage Time";
            }
        }

        public string detailCharts()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "详细图表";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "Detail Charts";
            }
            else
            {
                //return "";
                return "Detail Charts";
            }
        }
        public string alarmInfo()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "报警信息";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "Alarm Info";
            }
            else
            {
                //return "";
                return "Alarm Info";
            }
        }

        public string workInfo()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "工作信息";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "Work Info";
            }
            else
            {
                //return "";
                return "Work Info";
            }
        }

        public string name()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "姓名：";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "Name：";
            }
            else
            {
                //return "";
                return "Name：";
            }
        }

        public string age()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "年龄：";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "Age：";
            }
            else
            {
                //return "";
                return "Age：";
            }
        }
        public string gender()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "性别：";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "Gender：";
            }
            else
            {
                //return "";
                return "Gender：";
            }
        }

        public string height()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "身高：";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "Height：";
            }
            else
            {
                //return "";
                return "Height：";
            }
        }

        public string weight()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "体重：";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "Weight：";
            }
            else
            {
                //return "";
                return "Weight：";
            }
        }
        public string patient_info()
        {
            if(m_language==LANGUAGE.CHINA)
            {
                return "病人信息";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "Patient Info";
            }
            else
            {
                //return "";
                return "Patient Info";
            }
        }

        public string phoneNum()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "电话号码：";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "Phone No.：";
            }
            else
            {
                //return "";
                return "Phone No.：";
            }
        }

        public string address()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "住址：";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "Adress：";
            }
            else
            {
                //return "";
                return "Adress：";
            }
        }

        public string edit()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "编辑";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "Edit";
            }
            else
            {
                //return "";
                return "Edit";
            }
        }

        public string generateReport()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "生成报告";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "Generate Report";
            }
            else
            {
                //return "";
                return "Generate Report";
            }
        }

        public string machineType()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "设备型号：";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "Model No.：";
            }
            else
            {
                //return "";
                return "Model No.：";
            }
        }

        public string equipInfo()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "设备信息";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "Equipment Info";
            }
            else
            {
                //return "";
                return "Equipment Info";
            }
        }

        public string male()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "男";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "male";
            }
            else
            {
                //return "";
                return "male";
            }
        }

        public string female()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "女";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "female";
            }
            else
            {
                //return "";
                return "female";
            }
        }

        public string timePeriod()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "时间段";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "Time Period";
            }
            else
            {
                //return "";
                return "Time Period";
            }
        }

        public static string pls_enter_right_usrname_pwd()
        {
            if(m_language==LANGUAGE.CHINA)
            {
                return "请输入正确的用户名和密码";
            }
            else if(m_language==LANGUAGE.ENGLISH)
            {
                return "Please enter the right username and password！";
            }
            else
            {
                //return "";
                return "Please enter the right username and password！";
            }
        }

        public string ok()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "确定";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "ok";
            }
            else
            {
                //return "";
                return "ok";
            }
        }

        public string cancle()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "取消";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "cancle";
            }
            else
            {
                //return "";
                return "cancle";
            }
        }

        public static string no_data()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "无数据！";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "No data!";
            }
            else
            {
                //return "";
                return "No data!";
            }
        }

        public static string pls_import_data()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "请导入数据！";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "Please import data first!";
            }
            else
            {
                //return "";
                return "Please import data first!";
            }
        }

        public static string errAge()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "年龄";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "age";
            }
            else
            {
                //return "";
                return "age";
            }
        }
        public static string errHeight()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "身高";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "height";
            }
            else
            {
                //return "";
                return "height";
            }
        }
        public static string errWeight()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "体重";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "weight";
            }
            else
            {
                //return "";
                return "weight";
            }
        }
        public static string errPhoneNum()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "电话号码";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "phoneNo.";
            }
            else
            {
                //return "";
                return "phoneNo.";
            }
        }
        
        public static string pls_fill_up_name_and_age()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "姓名和年龄为必填信息，请将信息填完！";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "Name and age are necessary information,please fill up!";
            }
            else
            {
                //return "";
                return "Name and age are necessary information,please fill up!";
            }
        }
        public string showGenderValue(string gender)
        {
            //if(gender=="")
            //{
            //    return "NA";
            //}
            if(gender=="男"||gender=="male")
            {
                if (m_language == LANGUAGE.CHINA)
                {
                    return "男";
                }
                else if (m_language == LANGUAGE.ENGLISH)
                {
                    return "male";
                }
                else
                {
                    //return "";
                    return "male";
                }
            }
            else if (gender == "女" || gender == "female")
            {
                if (m_language == LANGUAGE.CHINA)
                {
                    return "女";
                }
                else if (m_language == LANGUAGE.ENGLISH)
                {
                    return "female";
                }
                else
                {
                    //return "";
                    return "female";
                }
            }
            else
            {
                return "NA";
            }
        }

        public string date()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "日期";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "Date";
            }
            else
            {
                //return "";
                return "Date";
            }
        }
        public string alarm_info()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "报警信息";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "Alarm Info";
            }
            else
            {
                //return "";
                return "Alarm Info";
            }
        }

        public string running_mode()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "运行模式";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "Running Mode";
            }
            else
            {
                //return "";
                return "Running Mode";
            }
        }

        public string alarm_code()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "报警码";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "Alarm Code";
            }
            else
            {
                //return "";
                return "Alarm Code";
            }
        }

        public string alarm_value_L()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "报警数据1";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "Alarm value 1";
            }
            else
            {
                //return "";
                return "Alarm value 1";
            }
        }
        public string alarm_value_H()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "报警数据2";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "Alarm value 2";
            }
            else
            {
                //return "";
                return "Alarm value 2";
            }
        }

        public static string pls_fill_in_right()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "请填写正确的：";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "Please fill in the right：";
            }
            else
            {
                //return "";
                return "Please fill in the right：";
            }
        }

        public static string generate_report_successful()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "生成报告成功！";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "Generate report sucessful!";
            }
            else
            {
                return "Generate report sucessful!";
            }
        }
        public static string pls_complete_patient_info()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "请先完善病人信息！";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "Please complete patient informations!";
            }
            else
            {
                return "Please complete patient informations!";
            }
        }

        public static string startTime_begyond_endTime()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "开始时间大于结束时间，请重选！";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "Start date beyond end date,please choose again!";
            }
            else
            {
                return "Start date beyond end date,please choose again!";
            }
        }

        public static string file_export_completed()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "文件导出完毕！";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "File export completed!";
            }
            else
            {
                return "File export completed!";
            }
        }
        public static string pls_choose_time()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "请选择时间！";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "Please choose time!";
            }
            else
            {
                return "Please choose time!";
            }
        }
        public static string fail_to_get_alarmFile_info()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "获取报警文件信息失败！";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "Fail to get alarm file info!";
            }
            else
            {
                return "Fail to get alarm file info!";
            }
        }

        public static string pls_choose_the_right_folder()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "请选择正确的文件夹！";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "Please choose the right folder!";
            }
            else
            {
                return "Please choose the right folder!";
            }
        }
        public static string open_alarmFile_fail()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "打开报警文件失败！";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "Open alarm file fail!";
            }
            else
            {
                return "Open alarm file fail!";
            }
        }
        public static string pls_ensure_import_data_and_choose_time()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "请确认导入了数据，并且选择了时间！";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "Please make sure already import data and choose time!";
            }
            else
            {
                return "Please make sure already import data and choose time!";
            }
        }


        public static string u_r_already_in_eng_mode()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "您已经在工程师模式！";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "You are already in engineer mode!";
            }
            else
            {
                return "You are already in engineer mode!";
            }
        }

        public static string welcom_enterinto_eng_mode()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "欢迎进入工程师模式！";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "Welcome to engineer mode!";
            }
            else
            {
                return "Welcome to engineer mode!";
            }
        }

        public static string adault_or_child(byte bt)
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return Convert.ToBoolean(bt) ? "儿童" : "成人";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return Convert.ToBoolean(bt) ? "Paediatric" : "Adult";
            }
            else
            {
                return Convert.ToBoolean(bt) ? "Paediatric" : "Adult";
            }
        }

        //if(LanguageMngr.m_language==LANGUAGE.CHINA)
        //    {
        //        str = Convert.ToBoolean(bt) ? "雾化" : "湿化";
        //    }
        //    else if(LanguageMngr.m_language==LANGUAGE.ENGLISH)
        //    {
        //        str = Convert.ToBoolean(bt) ? "Atomization" : "Humidifying";
        //    }
        //    else
        //    {
        //        //等有其他语言再添加
        //    }
        public static String humidy_or_atomiz(byte bt)
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return Convert.ToBoolean(bt) ? "雾化" : "湿化";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return Convert.ToBoolean(bt) ? "Atomization" : "Humidifying";
            }
            else
            {
                return Convert.ToBoolean(bt) ? "Atomization" : "Humidifying";
            }
        }
        public  String set_temp()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "设定温度";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "Set temperature";
            }
            else
            {
                return "Set temperature";
            }
        }
        public  String set_flow()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "设定流量";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "Set flow";
            }
            else
            {
                return "Set flow";
            }
        }
        public  String set_high_oxy_alarm()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "设定高氧浓度报警";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "Set High Oxy Alarm";
            }
            else
            {
                return "Set High Oxy Alarm";
            }
        }
        public  String set_low_oxy_alarm()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "设定低氧浓度报警";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "Set Low Oxy Alarm";
            }
            else
            {
                return "Set Low Oxy Alarm";
            }
        }
        public  String set_atomiz_level()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "设定雾化量档位";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "Set Atomiz Level";
            }
            else
            {
                return "Set Atomiz Level";
            }
        }
        public  String set_atomiz_time()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "设定雾化时间";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "Set Atomiz Time";
            }
            else
            {
                return "Set Atomiz Time";
            }
        }
         public  String set_adault_or_child()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "设定成人儿童模式";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "Set Adult or Paediatric";
            }
            else
            {
                return "Set Adult or Paediatric";
            }
        }
        public  String data_patient_tmp()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "患者端温度";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "Patient Temperature";
            }
            else
            {
                return "Patient Temperature";
            }
        }
        public  String data_air_outlet_tmp()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "出气口温度";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "Air Outlet Temperature";
            }
            else
            {
                return "Air Outlet Temperature";
            }
        }
        public  String data_heating_plate_tmp()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "加热盘温度";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "Heating Plate Temperature";
            }
            else
            {
                return "Heating Plate Temperature";
            }
        }
        public  String data_enviroment_tmp()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "环境温度";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "Enviroment Temperature";
            }
            else
            {
                return "Enviroment Temperature";
            }
        }

        public  String data_driveboard_tmp()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "驱动板温度";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "Driving Board temperature";
            }
            else
            {
                return "Driving Board temperature";
            }
        }

        public  String data_flow()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "流量";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "Flow";
            }
            else
            {
                return "Flow";
            }
        }

        public String data_dewpoint_tmp()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "露点温度";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "Dewpoint Temperature";
            }
            else
            {
                return "Dewpoint Temperature";
            }
        }

        public  String data_Oxy_concentration()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "氧浓度";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "Oxygen Concentration";
            }
            else
            {
                return "Oxygen Concentration";
            }
        }
        public  String data_air_pressure()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "气道压力";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "Air Pressure";
            }
            else
            {
                return "Air Pressure";
            }
        }
        public  String data_loop_type()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "回路类型";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "Loop Type";
            }
            else
            {
                return "Loop Type";
            }
        }
        public  String data_fault_statue1()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "故障状态位1";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "Fault Statue 1";
            }
            else
            {
                return "Fault Statue 1";
            }
        }

        public  String data_fault_statue2()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "故障状态位2";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "Fault Statue 2";
            }
            else
            {
                return "Fault Statue 2";
            }
        }
        public  String data_fault_statue3()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "故障状态位3";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "Fault Statue 3";
            }
            else
            {
                return "Fault Statue 3";
            }
        }
        public  String data_fault_statue4()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "故障状态位4";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "Fault Statue 4";
            }
            else
            {
                return "Fault Statue 4";
            }
        }
        public  String data_fault_statue5()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "故障状态位5";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "Fault Statue 5";
            }
            else
            {
                return "Fault Statue 5";
            }
        }
        public  String data_fault_statue6()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "故障状态位6";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "Fault Statue 6";
            }
            else
            {
                return "Fault Statue 6";
            }
        }
        public  String data_fault_statue7()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "故障状态位7";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "Fault Statue 7";
            }
            else
            {
                return "Fault Statue 7";
            }
        }
        public  String data_fault_statue8()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "故障状态位8";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "Fault Statue 8";
            }
            else
            {
                return "Fault Statue 8";
            }
        }
        public  String data_fault_statue9()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "故障状态位9";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "Fault Statue 9";
            }
            else
            {
                return "Fault Statue 9";
            }
        }
        public  String data_fault_statue10()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "故障状态位10";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "Fault Statue 10";
            }
            else
            {
                return "Fault Statue 10";
            }
        }
        public  String data_fault_statue11()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "故障状态位11";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "Fault Statue 11";
            }
            else
            {
                return "Fault Statue 11";
            }
        }
        public  String data_fault_statue12()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "故障状态位12";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "Fault Statue 12";
            }
            else
            {
                return "Fault Statue 12";
            }
        }
        public  String data_atomiz_DAC_L()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "雾化DAC数值L";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "Atomiz DAC L";
            }
            else
            {
                return "Atomiz DAC L";
            }
        }
        public  String data_atomiz_DAC_H()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "雾化DAC数值H";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "Atomiz DAC H";
            }
            else
            {
                return "Atomiz DAC H";
            }
        }
        public  String data_atomiz_ADC_L()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "雾化ADC数值L";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "Atomiz ADC L";
            }
            else
            {
                return "Atomiz ADC L";
            }
        }
        public  String data_atomiz_ADC_H()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "雾化ADC数值H";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "Atomiz ADC H";
            }
            else
            {
                return "Atomiz ADC H";
            }
        }
        public  String data_loop_heating_PWM_L()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "雾化ADC回路加热PWM数值L";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "Loop Heating PWM L";
            }
            else
            {
                return "Loop Heating PWM L";
            }
        }
        public  String data_loop_heating_PWM_H()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "雾化ADC回路加热PWM数值H";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "Loop Heating PWM H";
            }
            else
            {
                return "Loop Heating PWM H";
            }
        }
        public  String data_loop_heating_ADC_L()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "回路加热ADC数值L";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "Loop Heating ADC L";
            }
            else
            {
                return "Loop Heating ADC L";
            }
        }
        public  String data_loop_heating_ADC_H()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "回路加热ADC数值H";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "Loop Heating ADC H";
            }
            else
            {
                return "Loop Heating ADC H";
            }
        }
        public  String data_heating_plate_PWM_L()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "加热盘加热PWM数值L";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "Heating Plate PWM L";
            }
            else
            {
                return "Heating Plate PWM L";
            }
        }
        public  String data_heating_plate_PWM_H()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "加热盘加热PWM数值H";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "Heating Plate PWM H";
            }
            else
            {
                return "Heating Plate PWM H";
            }
        }
        public  String data_heating_plate_ADC_L()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "加热盘加热ADC数值L";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "Heating Plate ADC L";
            }
            else
            {
                return "Heating Plate ADC L";
            }
        }
        public  String data_heating_plate_ADC_H()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "加热盘加热ADC数值H";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "Heating Plate ADC H";
            }
            else
            {
                return "Heating Plate ADC H";
            }
        }
        public  String data_main_motor_drive_L()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "主马达驱动数值L";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "Main motor driver L";
            }
            else
            {
                return "Main motor driver L";
            }
        }
        public  String data_main_motor_drive_H()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "主马达驱动数值H";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "Main motor driver H";
            }
            else
            {
                return "Main motor driver H";
            }
        }

        public  String data_main_motor_speed_L()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "主马达转速数值L";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "Main motor speed L";
            }
            else
            {
                return "Main motor speed L";
            }
        }
        public  String data_main_motor_speed_H()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "主马达转速数值H";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "Main motor speed H";
            }
            else
            {
                return "Main motor speed H";
            }
        }
        public  String data_press_sensor_ADC_L()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "压力传感器ADC值L";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "Press sensor ADC L";
            }
            else
            {
                return "Press sensor ADC L";
            }
        }
        public  String data_press_sensor_ADC_H()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "压力传感器ADC值H";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "Press sensor ADC H";
            }
            else
            {
                return "Press sensor ADC H";
            }
        }
        public  String data_waterlevel_HADC_L()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "水位传感器HADC值L";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "Water level HADC L";
            }
            else
            {
                return "Water level HADC L";
            }
        }
        public  String data_waterlevel_HADC_H()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "水位传感器HADC值H";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "Water level HADC H";
            }
            else
            {
                return "Water level HADC H";
            }
        }
        public  String data_waterlevel_LADC_L()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "水位传感器LADC值L";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "Water level LADC L";
            }
            else
            {
                return "Water level LADC L";
            }
        }
        public  String data_waterlevel_LADC_H()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "水位传感器LADC值H";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "Water level LADC H";
            }
            else
            {
                return "Water level LADC H";
            }
        }
        public  String data_fan_driver_L()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "散热风扇驱动数值L";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "Fan driver L";
            }
            else
            {
                return "Fan driver L";
            }
        }
        public  String data_fan_driver_H()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "散热风扇驱动数值H";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "Fan driver H";
            }
            else
            {
                return "Fan driver H";
            }
        }
        public  String data_fan_speed_L()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "散热风扇转速数值L";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "Fan speed L";
            }
            else
            {
                return "Fan speed L";
            }
        }
        public  String data_fan_speed_H()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "散热风扇转速数值H";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "Fan speed H";
            }
            else
            {
                return "Fan speed H";
            }
        }

        public String data_main_motor_tmp_ADC_L()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "主马达温度ADC值L";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "Main motor tmp value L";
            }
            else
            {
                return "Main motor tmp value L";
            }
        }

        public String data_main_motor_tmp_ADC_H()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "主马达温度ADC值H";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "Main motor tmp value H";
            }
            else
            {
                return "Main motor tmp value H";
            }
        }

        public String atomization()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "雾化";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "Atomization";
            }
            else
            {
                return "Atomization";
            }
        }
        public String humidification()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "湿化";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "Humidification";
            }
            else
            {
                return "Humidification";
            }
        }

        public String overheat()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                //return "患者端超温";
                return "超温";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "Overheat";
            }
            else
            {
                return "Overheat";
            }
        }

        public String power_off()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "电源断开";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
               // return "Power off";
                return "Power Out";
            }
            else
            {
                return "Power Out";
            }
        }

        //湿化罐(雾化罐)未安装
        public String check_chamber()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                //return "罐子未安装";
                return "检查水罐"; 
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "Check Chamber";
            }
            else
            {
                return "Check Chamber";
            }
        }

        //缺水
        public String change_water_bag()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "缺水";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                //return "Change water bag";
                return "Lack of water";
            }
            else
            {
                return "Lack of water";
            }
        }


        //温度探头未安装
        public String check_temp_probe()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                //return "连接数据";
                return "温度探头未安装";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                //return "Check temp.probe";
                return "Temp. Probe uninstalled";
            }
            else
            {
                return "Temp. Probe uninstalled";
            }
        }

        //管路未安装
        public String check_tube()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                //return "连接发热线";
                return "管路未安装";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                //return "Check tube";
                return "Tube uninstalled";
            }
            else
            {
                return "Tube uninstalled";
            }
        }

        //管路不匹配
        public String tube_not_match()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "管路不匹配";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "CTube not match";
            }
            else
            {
                return "CTube not match";
            }
        }
        //堵塞
        public String check_blockages()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                //return "堵塞";
                return "检查堵塞";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                //return "Check blockages";
                return "Check for blockages";
            }
            else
            {
                return "Check for blockages";
            }
        }

         //高氧浓度
        public String high_O2()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "高氧浓度";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                //return "High O2";
                return "Oxygen too high";
            }
            else
            {
                return "Oxygen too high";
            }
        }

        //低氧浓度
        public String low_O2()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "低氧浓度";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                //return "Low O2";
                return "Oxygen too low";
            }
            else
            {
                return "Oxygen too low";
            }
        }

        //流量超范围
        public String flow_overrange()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                //return "达不到设定流量";
                return "流量超范围";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                //return "Flow overrange";
                return "Flow over range";
            }
            else
            {
                return "Flow over range";
            }
        }

        //温度超范围
        public String temp_overrange()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                //return "温度达不到设定值";
                return "温度超范围";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                //return "Temp.overrange";
                return "Temp. Over Range";
            }
            else
            {
                return "Temp. Over Range";
            }
        }

        //温度探头脱落
        public String prob_out()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "温度探头脱落";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "Temp. Probe out";
            }
            else
            {
                return "Temp. Probe out";
            }
        }

        //SD卡未安装
        public String sdCard_not_install()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "SD卡未安装";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "SD Card Uninstalled";
            }
            else
            {
                return "SD Card Uninstalled";
            }
        }

        //回路故障
        public String Circuit_failure_data_cable_uninstalled()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "回路故障/温度探头未安装";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "Circuit failure/data cable uninstalled";
            }
            else
            {
                return "";
            }
        }

        //泄露
        public String Check_for_leaks()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "泄露";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "Check for leaks";
            }
            else
            {
                return "";
            }
        }

        //系统故障E1---氧浓度传感器故障
        public String system_failure_E1()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "系统故障E1";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "System failure E1";
            }
            else
            {
                return "System failure E1";
            }
        }

        //系统故障E2---流量传感器故障
        public String system_failure_E2()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "系统故障E2";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "System failure E2";
            }
            else
            {
                return "System failure E2";
            }
        }


        //系统故障E3---环境温度传感器故障
        public String system_failure_E3()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "系统故障E3";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "System failure E3";
            }
            else
            {
                return "System failure E3";
            }
        }


        //系统故障E4---加热盘温度传感器故障
        public String system_failure_E4()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "系统故障E4";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "System failure E4";
            }
            else
            {
                return "System failure E4";
            }
        }

        //系统故障E5---散热风扇故障
        public String system_failure_E5()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "系统故障E5";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "System failure E5";
            }
            else
            {
                return "System failure E5";
            }
        }

        //系统故障E6---主风机过热故障
        public String system_failure_E6()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "系统故障E6";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "System failure E6";
            }
            else
            {
                return "System failure E6";
            }
        }

        ////系统故障E7---散热器温度传感器故障(仅VUN-002)
        //public String system_failure_E7()
        //{
        //    if (m_language == LANGUAGE.CHINA)
        //    {
        //        return "系统故障E7";
        //    }
        //    else if (m_language == LANGUAGE.ENGLISH)
        //    {
        //        return "System failure E7";
        //    }
        //    else
        //    {
        //        return "";
        //    }
        //}


        //系统故障E7---温控开关开路
        public String system_failure_E7()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "系统故障E7";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "System failure E7";
            }
            else
            {
                return "System failure E7";
            }
        }

        //系统故障E8---发热盘开路
        public String system_failure_E8()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "系统故障E8";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "System failure E8";
            }
            else
            {
                return "System failure E8";
            }
        }


        public String oxy_concentration_sensor_fault()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "氧浓度传感器故障";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "Oxygen concentration sensor fault";
            }
            else
            {
                return "Oxygen concentration sensor fault";
            }
        }
        
        public String flow_sensor_fault()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "流量传感器故障";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "Flow sensor fault";
            }
            else
            {
                return "Flow sensor fault";
            }
        }
        
        public String enviroment_tmp_sensor_fault()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "环境温度传感器故障";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "Enviroment temperature fault";
            }
            else
            {
                return "Enviroment temperature fault";
            }
        }
        
        public String driverBoard_tmp_sensor_fault()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "驱动板温度传感器故障";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "Driving board temperature fault";
            }
            else
            {
                return "Driving board temperature fault";
            }
        }
        
        public String heating_plate_tmp_sensor_fault()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "加热盘温度传感器故障";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "Heating plate temperature fault";
            }
            else
            {
                return "Heating plate temperature fault";
            }
        }
        
        public String fan_fault()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "散热风扇故障";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "Fan fault";
            }
            else
            {
                return "Fan fault";
            }
        }
        
        public String EEPROM_verify_fail()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "EEPROM校验失败";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "EEPROM verification failed";
            }
            else
            {
                return "EEPROM verification failed";
            }
        }
        
        public String air_outlet_sensor_fault()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "出气口温度传感器故障";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "Air outlet sensor fault";
            }
            else
            {
                return "Air outlet sensor fault";
            }
        }
        
        public String patient_tmp_sensor_fault()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "患者端温度传感器故障";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "Patien temperature sensor fault";
            }
            else
            {
                return "Patien temperature sensor fault";
            }
        }
        
        public String unknow_err()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "未识别的错误";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "Unknow error";
            }
            else
            {
                return "Unknow error";
            }
        }
        public String adault()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "成人";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "adult";
            }
            else
            {
                return "adult";
            }
        }
        public String child()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "儿童";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "paediatric";
            }
            else
            {
                return "paediatric";
            }
        }
        public String top_page()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "首页";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "Top Page";
            }
            else
            {
                return "Top Page";
            }
        }
        public String end_page()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "尾页";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "End Page";
            }
            else
            {
                return "End Page";
            }
        }
        public String prev_page()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "上一页";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "Prev Page";
            }
            else
            {
                return "Prev Page";
            }
        }
        public String next_page()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "下一页";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "Next Page";
            }
            else
            {
                return "Next Page";
            }
        }

        public String jump_to()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "跳转至:";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "Jump to:";
            }
            else
            {
                return "Jump to:";
            }
        }
        public String charts()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "图表";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "Charts";
            }
            else
            {
                return "Charts";
            }
        }

        public string title_usageTime()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "使用时间：";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "Usage Time:";
            }
            else
            {
                return "Usage Time:";
            }
        }
        public String title_patient_tmp()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "病人温度";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "Patient Temperature:";
            }
            else
            {
                return "Patient Temperature:";
            }
        }
        
        public String title_air_outlet_tmp()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "出气口温度：";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "Air Outlet Temperature:";
            }
            else
            {
                return "Air Outlet Temperature:";
            }
        }
        public String title_flow()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "流量：";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "Flow:";
            }
            else
            {
                return "Flow:";
            }
        }
        public String title_oxy_concentration()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "氧浓度：";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "Oxygen Concentration:";
            }
            else
            {
                return "Oxygen Concentration:";
            }
        }

        public String title_dewpoint_tmp()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "露点温度：";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "Dewpoint Temperature:";
            }
            else
            {
                return "Dewpoint Temperature:";
            }
        }

        public String soft_ver_in_menu()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "软件版本";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "Soft version";
            }
            else
            {
                return "Soft version";
            }
        }
        public String app_name()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "O2FLO数据读取软件";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "O2FLO Data Reader";
            }
            else
            {
                return "O2FLO Data Reader";
            }
        }

        //"Lack of work information file!"
        public static String lack_of_work_file()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "缺少工作信息文件！";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "Lack of work information file!";
            }
            else
            {
                return "Lack of work information file!";
            }
        }

        public static String lack_of_alarm_file()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "缺少报警信息文件！";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "Lack of alarm information file!";
            }
            else
            {
                return "Lack of alarm information file!";
            }
        }
        //No alarm information in alarm file
        public static String no_data_info_in_alarm_file()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "报警信息文件中没有数据！";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "No data in alarm file!";
            }
            else
            {
                return "No data in alarm file!";
            }
        }

        public static String no_data_in_the_time_span()
        {
            if (m_language == LANGUAGE.CHINA)
            {
                return "该时段没有数据！";
            }
            else if (m_language == LANGUAGE.ENGLISH)
            {
                return "No data in the time span!";
            }
            else
            {
                return "No data in the time span!";
            }
        }
    }
}
