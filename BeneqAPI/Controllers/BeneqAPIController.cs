using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using ArmInterface;

[Route("api/[controller]")]
[ApiController]
public class MyAPIController : ControllerBase
{
    [HttpGet]
    public ActionResult Get(ActionType action)
    {
        try
        {
            bool isSuccess = false;
            string retMessage = String.Empty;
            switch (action)
            {
                case ActionType.Pick:
                    isSuccess = ArmSingletonInterface.Instance.PickObject();
                    retMessage = isSuccess ? API_Reply_Strings.Message_Pick_Success : API_Reply_Strings.Message_Pick_Fail;
                    break;
                case ActionType.Drop:
                    isSuccess = ArmSingletonInterface.Instance.DropObject();
                    retMessage = isSuccess ?  API_Reply_Strings.Message_Drop_Success : API_Reply_Strings.Message_Drop_Fail ;
                    break;
                case ActionType.MoveLeft:
                    isSuccess = ArmSingletonInterface.Instance.MoveObject(2);
                    retMessage = isSuccess ? API_Reply_Strings.Message_MoveLeft_Success : API_Reply_Strings.Message_MoveLeft_Fail ;
                    break;
                case ActionType.MoveRight:
                    isSuccess = ArmSingletonInterface.Instance.MoveObject(3);
                    retMessage = isSuccess ? API_Reply_Strings.Message_MoveRight_Success : API_Reply_Strings.Message_MoveRight_Fail;
                    break;
                case ActionType.MoveUp:
                    isSuccess = ArmSingletonInterface.Instance.MoveObject(0);
                    retMessage = isSuccess ? API_Reply_Strings.Message_MoveUp_Success : API_Reply_Strings.Message_MoveUp_Fail ;
                    break;
                case ActionType.MoveDown:
                    isSuccess = ArmSingletonInterface.Instance.MoveObject(1);
                    retMessage = isSuccess ? API_Reply_Strings.Message_MoveDown_Success : API_Reply_Strings.Message_MoveDown_Fail ;
                    break;
            }
            return Ok(new { result = retMessage, success = isSuccess });
        }
        catch (Exception ex)
        {
            return BadRequest(ex);
        }
    }
}
public enum ActionType
{
    Pick,
    Drop,
    MoveDown,
    MoveUp,
    MoveRight,
    MoveLeft
}
