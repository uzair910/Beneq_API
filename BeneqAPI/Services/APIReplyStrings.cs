public static class API_Reply_Strings
{
    private static string sActionPick_Success = "Arm has picked the object.";
    private static string sActionPick_Fail = "Pick request failed: Arm is already holding an object.";

    private static string sActionDrop_Success = "Arm has dropped the object.";
    private static string sActionDrop_Fail = "Drop request failed: The Arm is not holding any object at the moment.";

    private static string sActionMoveUp_Success = "Arm moved one step forward.";
    private static string sActionMoveUp_Fail = "Move forward request failed: The Arm is not holding any object at the moment.";

    private static string sActionMoveDown_Success = "Arm moved one step backwards.";
    private static string sActionMoveDown_Fail = "Move backward request failed: The Arm is not holding any object at the moment.";

    private static string sActionMoveLeft_Success = "Arm moved to the left.";
    private static string sActionMoveLeft_Fail = "Move to Left request failed: The Arm is not holding any object at the moment.";

    private static string sActionMoveRight_Success = "Arm moved to the right.";
    private static string sActionMoveRight_Fail = "Move to right request failed: The Arm is not holding any object at the moment.";


    #region Accessors
    public static string Message_MoveRight_Fail
    {
        get
        {
            return sActionMoveRight_Fail;
        }
    }
    public static string Message_MoveRight_Success
    {
        get
        {
            return sActionMoveRight_Success;
        }
    }
    public static string Message_MoveLeft_Fail
    {
        get
        {
            return sActionMoveLeft_Fail;
        }
    }
    public static string Message_MoveLeft_Success
    {
        get
        {
            return sActionMoveLeft_Success;
        }
    }
    public static string Message_MoveDown_Fail
    {
        get
        {
            return sActionMoveDown_Fail;
        }
    }
    public static string Message_MoveDown_Success
    {
        get
        {
            return sActionMoveDown_Success;
        }
    }
    public static string Message_MoveUp_Fail
    {
        get
        {
            return sActionMoveUp_Fail;
        }
    }
    public static string Message_MoveUp_Success
    {
        get
        {
            return sActionMoveUp_Success;
        }
    }
    public static string Message_Drop_Fail
    {
        get
        {
            return sActionDrop_Fail;
        }
    }
    public static string Message_Drop_Success
    {
        get
        {
            return sActionDrop_Success;
        }
    }

    public static string Message_Pick_Fail
    {
        get
        {
            return sActionPick_Fail;
        }
    }
    public static string Message_Pick_Success
    {
        get
        {
            return sActionPick_Success;
        }
    }
    #endregion
}
