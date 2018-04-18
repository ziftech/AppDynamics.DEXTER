﻿using CsvHelper.Configuration;

namespace AppDynamics.Dexter.DataObjects
{
    public class NodeEntityReportMap : ClassMap<EntityNode>
    {
        public NodeEntityReportMap()
        {
            int i = 0; 
            Map(m => m.Controller).Index(i); i++;
            Map(m => m.ApplicationName).Index(i); i++;
            Map(m => m.TierName).Index(i); i++;
            Map(m => m.NodeName).Index(i); i++;
            Map(m => m.AgentType).Index(i); i++;
            Map(m => m.AgentVersion).Index(i); i++;
            Map(m => m.AgentVersionRaw).Index(i); i++;
            Map(m => m.AgentPresent).Index(i); i++;
            Map(m => m.MachineName).Index(i); i++;
            Map(m => m.MachineAgentVersion).Index(i); i++;
            Map(m => m.MachineAgentVersionRaw).Index(i); i++;
            Map(m => m.MachineAgentPresent).Index(i); i++;
            Map(m => m.MachineOSType).Index(i); i++;
            Map(m => m.MachineType).Index(i); i++;

            Map(m => m.ApplicationID).Index(i); i++;
            Map(m => m.TierID).Index(i); i++;
            Map(m => m.NodeID).Index(i); i++;
            Map(m => m.MachineID).Index(i); i++;
            Map(m => m.DetailLink).Index(i); i++;
            Map(m => m.MetricGraphLink).Index(i); i++;
            Map(m => m.FlameGraphLink).Index(i); i++;
            Map(m => m.FlameChartLink).Index(i); i++;
            Map(m => m.ControllerLink).Index(i); i++;
            Map(m => m.ApplicationLink).Index(i); i++;
            Map(m => m.TierLink).Index(i); i++;
            Map(m => m.NodeLink).Index(i); i++;
        }
    }
}
