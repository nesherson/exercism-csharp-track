using System.ComponentModel.Design;

public static class PlayAnalyzer
{
    public static string AnalyzeOnField(int shirtNum)
    {
        return shirtNum switch
        {
            1 => "goalie",
            2 => "left back",
            3 => "center back",
            4 => "center back",
            5 => "right back",
            6 => "midfielder",
            7 => "midfielder",
            8 => "midfielder",
            9 => "left wing",
            10 => "striker",
            11 => "right wing",
            _ => "UNKNOWN"
        };
    }

    public static string AnalyzeOffField(object report)
    {
        return report switch
        {
            int supporterNum => $"There are {supporterNum} supporters at the match.",
            string text => text,
            Injury injury => $"Oh no! {injury.GetDescription()} Medics are on the field.",
            Incident incident => incident.GetDescription(),
            Manager manager when string.IsNullOrEmpty(manager.Club) => manager.Name,
            Manager manager => $"{manager.Name} ({manager.Club})",
            _ => string.Empty
        };
    }
}
