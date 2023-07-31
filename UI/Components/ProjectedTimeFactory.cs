using LiveSplit.Model;
using System;

namespace LiveSplit.UI.Components
{
    public class ProjectedTimeFactory : IComponentFactory
    {
        // The displayed name of the component in the Layout Editor.
        public string ComponentName => "Projected Time";

        public string Description => "Displays the estimated final time of the run, based on the time gained and lost so far.";

        // The sub-menu this component will appear under when adding the component to the layout.
        public ComponentCategory Category => ComponentCategory.Information;

        public IComponent Create(LiveSplitState state) => new ProjectedTimeComponent(state);

        public string UpdateName => ComponentName;

        // Fill in this empty string with the URL of the repository where your component is hosted.
        // This should be the raw content version of the repository. If you're not uploading this
        // to GitHub or somewhere, you can ignore this.
        public string UpdateURL => "https://raw.githubusercontent.com/TheSoundDefense/LiveSplit.ProjectedTime/main/";

        // Fill in this empty string with the path of the XML file containing update information.
        // Check other LiveSplit components for examples of this. If you're not uploading this to
        // GitHub or somewhere, you can ignore this.
        public string XMLURL => UpdateURL + "Components/update.LiveSplit.ProjectedTime.xml";

        public Version Version => Version.Parse("1.1.0");
    }
}
