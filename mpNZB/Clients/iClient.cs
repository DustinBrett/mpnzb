﻿using System.Timers;
using MediaPortal.GUI.Library;

namespace mpNZB.Clients
{
  interface iClient
  {
    bool InPlugin
    {
      get;
      set;
    }

    void Status();
    void Queue(GUIListControl _List, GUIWindow _GUI);
    void QueueItem(GUIListControl _List, GUIWindow _GUI);
    void Download(GUIListItem _Item);
    void Pause(bool _Pause);
    string Version();
  }
}