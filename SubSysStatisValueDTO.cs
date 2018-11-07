/********************************************************************************

** Copyright(c) 2016 武汉虹信技术服务有限责任公司 All Rights Reserved. 

** auth： 王凤纯

** mail： wangfengchun@hxct.com 

** file： SubSysStatisValueDTO.cs 

** desc： 提供客户端主界面上各子系统统计值数据的接口结构
 
** date:  2016/3/14 星期一 下午 14:58:39

** Ver : V1.0.0 

*********************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace HXCT.IBMS.Dto.ModelDTO
{
    #region IBMS系统首页统计信息结构
    /// <summary>
    /// 周界防盗子系统统计值DTO
    /// </summary>
    [DataContract]
    public class AntitheftSysStatisValueDTO
    {
        [DataMember]
        public int AllDevCount
        {
            get;
            set;
        }
        [DataMember]
        public int DefendDevCount
        {
            get;
            set;
        }
        [DataMember]
        public int AlarmCount
        {
            get;
            set;
        }
    }

    /// <summary>
    /// 广播子系统统计值DTO
    /// </summary>
    [DataContract]
    public class BroadcastSysStatisValueDTO
    {
        [DataMember]
        public int AllDevNum
        {
            get;
            set;
        }

        [DataMember]
        public int WorkingDevNum
        {
            get;
            set;
        }

        [DataMember]
        public int IdleDevNum
        {
            get;
            set;
        }
    }

    /// <summary>
    /// 门禁子系统统计值DTO
    /// </summary>
    [DataContract]
    public class DoorSysStatisValueDTO
    {
        [DataMember]
        public int AllDoorNum
        {
            get;
            set;
        }

        [DataMember]
        public int OpenDoorNum
        {
            get;
            set;
        }

        [DataMember]
        public int CloseDoorNum
        {
            get;
            set;
        }
    }

    /// <summary>
    /// 变配电子系统统计值DTO
    /// </summary>
    [DataContract]
    public class ElectricSysStatisValueDTO
    {
        [DataMember]
        public int DCScreenChargCnt // 直流屏充电数量
        {
            get;
            set;
        }
        [DataMember]
        public int DCScreenDisChargCnt // 直流屏放电数量
        {
            get;
            set;
        }
        [DataMember]
        public int EPSUPSChargCnt // EPS/UPS充电数量
        {
            get;
            set;
        }
        [DataMember]
        public int EPSUPSDischargCnt // EPS/UPS放电数量
        {
            get;
            set;
        }
        [DataMember]
        public int TransformerCount  // 变压器数量
        {
            get;
            set;
        }
        [DataMember]
        public int PowerCompStatus  // 功率补偿状态
        {
            get;
            set;
        }
    }

    /// <summary>
    /// 梯控子系统统计值DTO
    /// </summary>
    [DataContract]
    public class ElevatorSysStatisValueDTO
    {
        [DataMember]
        public int AllElevatorCount
        {
            get;
            set;
        }
        [DataMember]
        public int StartElevatorCount
        {
            get;
            set;
        }
        [DataMember]
        public int FaultElevatorCount
        {
            get;
            set;
        }
        [DataMember]
        public int AllEscalatorCount
        {
            get;
            set;
        }
        [DataMember]
        public int StartEscalatorCount
        {
            get;
            set;
        }
        [DataMember]
        public int FaultEscalatorCount
        {
            get;
            set;
        }
    }

    /// <summary>
    /// 能耗子系统统计值DTO
    /// </summary>
    [DataContract]
    public class EnergySysStatisValueDTO
    {
        /// <summary>
        /// 今日总能耗
        /// </summary>
        [DataMember]
        public double TotalEnergyToday
        {
            get;
            set;
        }
        /// <summary>
        /// 历史总能耗
        /// </summary>
        [DataMember]
        public double TotalEnergy
        {
            get;
            set;
        }

        /// <summary>
        /// 今日小时用电详情
        /// key: 小时组成部分，表示为 0 和 23 之间的一个值
        /// value：小时内用电 kWh
        /// </summary>
        [DataMember]
        public Dictionary<int, decimal> TotalEnergyTodayDetail
        {
            get;
            set;
        }
    }

    /// <summary>
    /// 消防子系统统计值DTO
    /// </summary>
    [DataContract]
    public class FireSysStatisValueDTO
    {
        [DataMember]
        public int TempAlarmCount
        {
            get;
            set;
        }
        [DataMember]
        public int SmokeAlarmCount
        {
            get;
            set;
        }
        [DataMember]
        public int ManualAlarmCount
        {
            get;
            set;
        }
        [DataMember]
        public int OtherAlarmCount
        {
            get;
            set;
        }
    }

    /// <summary>
    /// 暖通空调子系统统计值DTO
    /// </summary>
    [DataContract]
    public class HAVCSysStatisValueDTO
    {
        /// <summary>
        /// Gets all cold count.
        /// </summary>
        /// <value>
        /// All cold count.
        /// </value>
        [DataMember]
        public int AllColdCount
        {
            get;
            set;
        }
        [DataMember]
        public int RunColdCount
        {
            get;
            set;
        }
        //吊顶式空调统计
        [DataMember]
        public int AllCeilingAirConCount
        {
            get;
            set;
        }
        [DataMember]
        public int RunCeilingAirConCount
        {
            get;
            set;
        }

        //组合式空调统计
        [DataMember]
        public int AllCombinedAirConCount
        {
            get;
            set;
        }
        [DataMember]
        public int RunCombinedAirConCount
        {
            get;
            set;
        }

        //新风机组统计
        [DataMember]
        public int AllFreAirCount
        {
            get;
            set;
        }
        [DataMember]
        public int RunFreAirCount
        {
            get;
            set;
        }
    }

    /// <summary>
    /// 信息发布子系统统计值DTO
    /// </summary>
    [DataContract]
    public class IDSSysStatisValueDTO
    {
        [DataMember]
        public int AllScrNum
        {
            get;
            set;
        }

        [DataMember]
        public int OpenSrcNum
        {
            get;
            set;
        }

        [DataMember]
        public int LargeScrBrightness
        {
            get;
            set;
        }

        [DataMember]
        public int LargeScrTemperature
        {
            get;
            set;
        }
    }

    /// <summary>
    /// 照明子系统统计值DTO
    /// </summary>
    [DataContract]
    public class LightSysStatisValueDTO
    {
        [DataMember]
        public int AllCircuitCount
        {
            get;
            set;
        }
        [DataMember]
        public int StartCircuitCount
        {
            get;
            set;
        }
    }

    /// <summary>
    /// 客流统计子系统统计值DTO
    /// </summary>
    [DataContract]
    public class PassStatSysStatisItemDTO
    {
        [DataMember]
        public DateTime StatTime
        {
            get;
            set;
        }
        [DataMember]
        public int Persons
        {
            get;
            set;
        }
    }

    [DataContract]
    public class PassStatSysStatisValueDTO
    {
        [DataMember]
        public int CurrentPersons
        {
            get;
            set;
        }
        [DataMember]
        public int TodayPersons
        {
            get;
            set;
        }

        public PassStatSysStatisValueDTO()
        {
            CurrentPersons = 0;
            TodayPersons = 0;
        }
    }

    /// <summary>
    /// 停车子系统统计值DTO
    /// </summary>
    [DataContract]
    public class ParkSysStatisValueDTO
    {
        [DataMember]
        public int AllSpaceCount
        {
            get;
            set;
        }
        [DataMember]
        public int EmptySpaceCount
        {
            get;
            set;
        }
    }

    /// <summary>
    /// 巡更子系统统计值DTO
    /// </summary>
    [DataContract]
    public class PatrolSysStatisValueDTO
    {
        [DataMember]
        public int AllTaskCount
        {
            get;
            set;
        }
        [DataMember]
        public int DoneTaskCount
        {
            get;
            set;
        }
        [DataMember]
        public int AllLineCount
        {
            get;
            set;
        }
    }

    /// <summary>
    /// 视频子系统统计值DTO
    /// </summary>
    [DataContract]
    public class VideoSysStatisItemDTO
    {
        [DataMember]
        public int ObjId
        {
            get;
            set;
        }
        [DataMember]
        public int ValidCount
        {
            get;
            set;
        }
        [DataMember]
        public int TotalCount
        {
            get;
            set;
        }
    }
    [DataContract]
    public class VideoSysStatisValueDTO
    {
        [DataMember]
        public List<VideoSysStatisItemDTO> ObjList
        {
            get;
            set;
        }
    }

    /// <summary>
    /// 给排水子系统统计值DTO
    /// </summary>
    [DataContract]
    public class WaterSysStatisValueDTO
    {

        //生活水泵统计
        [DataMember]
        public int AllLifePumpCount
        {
            get;
            set;
        }
        [DataMember]
        public int RunLifePumpCount
        {
            get;
            set;
        }
        //污水坑泵统计
        [DataMember]
        public int AllSumpPumpCount
        {
            get;
            set;
        }
        [DataMember]
        public int RunSumpPumpCount
        {
            get;
            set;
        }
        //冷却水补水水泵统计
        [DataMember]
        public int AllCoolingPumpCount
        {
            get;
            set;
        }
        [DataMember]
        public int RunCoolingPumpCount
        {
            get;
            set;
        }
        //雨水提升泵统计
        [DataMember]
        public int AllRainPumpCount
        {
            get;
            set;
        }
        [DataMember]
        public int RunRainPumpCount
        {
            get;
            set;
        }
    }

    [DataContract]
    public class IndoorEnvironmentDTO
    {
        //室内温度
        [DataMember]
        public string IndoorTemp
        {
            get;
            set;
        }

        //室内湿度
        [DataMember]
        public string IndoorHumidity
        {
            get;
            set;
        }

        public IndoorEnvironmentDTO(string temp, string humidity)
        {
            IndoorTemp = temp;
            IndoorHumidity = humidity;
        }
    }

    [DataContract]
    public class IntercomSysStatisValueDTO  //楼控对讲子系统统计值
    {
        [DataMember]
        public int AllDevNum
        {
            get;
            set;
        }

        [DataMember]
        public int StopRunningDevNum
        {
            get;
            set;
        }

        [DataMember]
        public int RunningDevNum
        {
            get;
            set;
        }
    }

    [DataContract]
    public class StreetlampSysStatisValueDTO        //智慧路灯统计
    {
        /// <summary>
        /// 路灯数量
        /// </summary>
        [DataMember]
        public int StreetlampCount
        {
            get;
            set;
        }
        /// <summary>
        /// 正常路灯数量
        /// </summary>
        [DataMember]
        public int NormalStreetlampCount
        {
            get;
            set;
        }
        /// <summary>
        /// 普通故障的路灯数量
        /// </summary>
        [DataMember]
        public int GeneralAlarmCount 
        {
            get;
            set;
        }
        /// <summary>
        /// 严重故障的路灯数量
        /// </summary>
        [DataMember]
        public int SeriousAlarmCount
        {
            get;
            set;
        }
        /// <summary>
        /// 紧急故障的路灯数量
        /// </summary>
        [DataMember]
        public int UrgentAlarmCount
        {
            get;
            set;
        }
    }

    [DataContract]
    public class ChargeSysStatisValueDTO    // 充电桩统计
    {
        /// <summary>
        /// 充电设备数量，“设备类型名称=充电桩”的设备数量
        /// </summary>
        [DataMember]
        public int ChargeDeviceCount
        {
            get;
            set;
        }
        /// <summary>
        ///    启用的充电设备数量，“设备类型名称=充电桩”并且“属性类型=启用的属性值=1”的设备数量
        /// </summary>
        [DataMember]
        public int UsingChargeDeviceCount
        {
            get;
            set;
        }
    }
    [DataContract]
    public class AlarmSysStatisValueDTO    // 一键报警统计
    {
        /// <summary>
        /// 报警主机设备数量，“设备类型名称=一键报警主机”的设备数量
        /// </summary>
        [DataMember]
        public int AlarmDeviceCount
        {
            get;
            set;
        }
        /// <summary>
        /// 报警数量，一键报警历史表（AkeyAlarm_log）中记录总数
        /// </summary>
        [DataMember]
        public int AllAlarmCount
        {
            get;
            set;
        }
        /// <summary>
        /// 未处理的报警数量，一键报警历史表（AkeyAlarm_log）中alarm_handle_status=0的记录总数
        /// </summary>
        [DataMember]
        public int NotHandledAlarmCount
        {
            get;
            set;
        }
    }
    [DataContract]
    public class WiFiSysStatisValueDTO    // wifi统计
    {
        /// <summary>
        /// 设备总数
        /// </summary>
        [DataMember]
        public int devCount
        {
            get;
            set;
        }

        /// <summary>
        /// 在线设备总数
        /// </summary>
        [DataMember]
        public int onlineDevCount
        {
            get;
            set;
        }
    }
    #endregion
   
    #region 智慧路灯系统首页统计信息结构
    [DataContract]
    public class StreetLampStatInfoBase
    {
        /// <summary>
        /// 模块类型
        /// </summary>
        [DataMember]
        public int moduleType
        {
            get;
            set;
        }
        /// <summary>
        /// 智慧路灯下某子系统中普通告警的数量
        /// </summary>
        [DataMember]
        public int generalAlarmCnt
        {
            get;
            set;
        }
        /// <summary>
        /// 智慧路灯下某子系统中严重告警的数量
        /// </summary>
        [DataMember]
        public int seriousAlarmCnt
        {
            get;
            set;
        }
        /// <summary>
        /// 智慧路灯下某子系统中紧急告警的数量
        /// </summary>
        [DataMember]
        public int urgentAlarmCnt
        {
            get;
            set;
        }
        /// <summary>
        /// 智慧路灯下某子系统的所有设备数量，如智慧路灯下WiFi设备的数量
        /// </summary>
        [DataMember]
        public int allDevCount  
        {
            get;
            set;
        }
        /// <summary>
        /// 智慧路灯下某子系统的正常设备数量，如智慧路灯下正常的WiFi设备的数量（既没有离线，也没有故障）
        /// </summary>
        [DataMember]
        public int normalDevCount   
        {
            get;
            set;
        }
        /// <summary>
        /// 智慧路灯下某子系统的在线设备数量，如智慧路灯下在线的WiFi设备的数量
        /// </summary>
        [DataMember]
        public int onLineDevCount
        {
            get;
            set;
        }
        /// <summary>
        /// 智慧路灯下某子系统的离线设备数量，如智慧路灯下离线的WiFi设备的数量
        /// </summary>
        [DataMember]
        public int offLineDevCount  
        {
            get;
            set;
        }
        /// <summary>
        /// 智慧路灯下某子系统的故障设备数量，如智慧路灯下发生故障的WiFi设备的数量（一个设备上有多个故障时，只统计一次）
        /// </summary>
        [DataMember]
        public int faultDevCount 
        {
            get;
            set;
        }
    }
    [DataContract]
    public class EnergyOfStreetLampStatInfo : StreetLampStatInfoBase
    {
        /// <summary>
        /// 今日总能耗
        /// </summary>
        [DataMember]
        public double TotalEnergyToday
        {
            get;
            set;
        }
        /// <summary>
        /// 历史总能耗
        /// </summary>
        [DataMember]
        public double TotalEnergy
        {
            get;
            set;
        }

        /// <summary>
        /// 今日小时用电详情
        /// key: 小时组成部分，表示为 0 和 23 之间的一个值
        /// value：小时内用电 kWh
        /// </summary>
        [DataMember]
        public Dictionary<int, decimal> TotalEnergyTodayDetail
        {
            get;
            set;
        }
    }
    #endregion
    
    [DataContract]
    [KnownType(typeof(AntitheftSysStatisValueDTO))]
    [KnownType(typeof(BroadcastSysStatisValueDTO))]
    [KnownType(typeof(DoorSysStatisValueDTO))]
    [KnownType(typeof(ElectricSysStatisValueDTO))]
    [KnownType(typeof(ElevatorSysStatisValueDTO))]
    [KnownType(typeof(EnergySysStatisValueDTO))]
    [KnownType(typeof(FireSysStatisValueDTO))]
    [KnownType(typeof(HAVCSysStatisValueDTO))]
    [KnownType(typeof(IDSSysStatisValueDTO))]
    [KnownType(typeof(LightSysStatisValueDTO))]
    [KnownType(typeof(PassStatSysStatisValueDTO))]
    [KnownType(typeof(ParkSysStatisValueDTO))]
    [KnownType(typeof(PatrolSysStatisValueDTO))]
    [KnownType(typeof(VideoSysStatisValueDTO))]
    [KnownType(typeof(WaterSysStatisValueDTO))]
    [KnownType(typeof(IndoorEnvironmentDTO))]
    [KnownType(typeof(IntercomSysStatisValueDTO))]
    [KnownType(typeof(StreetlampSysStatisValueDTO))]
    [KnownType(typeof(ChargeSysStatisValueDTO))]
    [KnownType(typeof(AlarmSysStatisValueDTO))]
    [KnownType(typeof(WiFiSysStatisValueDTO))]
    [KnownType(typeof(StreetLampStatInfoBase))]
    [KnownType(typeof(EnergyOfStreetLampStatInfo))]
    public class subSysStaBaseDto
    {
        [DataMember]
        public int type;
        [DataMember]
        public string name;
        [DataMember]
        public int subSystemId;
        [DataMember]
        public int levelOneAlarmCnt;
        [DataMember]
        public int levelTwoAlarmCnt;
        [DataMember]
        public int levelThreeAlarmCnt;
        [DataMember]
        public object data;
    }

    [DataContract]
    public class sysStatDTO
    {
        [DataMember]
        public subSysStaBaseDto Anti;

        [DataMember]
        public subSysStaBaseDto Broadcast;

        [DataMember]
        public subSysStaBaseDto Door;

        [DataMember]
        public subSysStaBaseDto Elec;

        [DataMember]
        public subSysStaBaseDto Elevator;

        [DataMember]
        public subSysStaBaseDto Energy;

        [DataMember]
        public subSysStaBaseDto Fire;

        [DataMember]
        public subSysStaBaseDto HVAC;

        [DataMember]
        public subSysStaBaseDto IDS;

        [DataMember]
        public subSysStaBaseDto Light;

        [DataMember]
        public subSysStaBaseDto PassStat;

        [DataMember]
        public subSysStaBaseDto Park;

        [DataMember]
        public subSysStaBaseDto Patrol;

        [DataMember]
        public subSysStaBaseDto Video;

        [DataMember]
        public subSysStaBaseDto Water;

        [DataMember]
        public subSysStaBaseDto Indoor;

        [DataMember]
        public subSysStaBaseDto Intercom;
    }
}
