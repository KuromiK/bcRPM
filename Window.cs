﻿namespace WinFormsLibrary1;

public abstract class Window : Frame
{
    public void postEvent(Event ev) { }
    public abstract void processEvent(Event ev);
}
