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
                    retMessage = isSuccess ? "Arm has picked the object." : "Pick request failed: Arm is already holding an object.";
                    break;
                case ActionType.Drop:
                    isSuccess = ArmSingletonInterface.Instance.DropObject();
                    retMessage = isSuccess ? "Arm has dropped the object." : "Drop request failed: The Arm is not holding any object at the moment.";
                    break;
                case ActionType.MoveLeft:
                    isSuccess = ArmSingletonInterface.Instance.MoveObject(3);
                    retMessage = isSuccess ? "Arm moved to the left." : "Move to Left request failed: The Arm is not holding any object at the moment.";
                    break;
                case ActionType.MoveRight:
                    isSuccess = ArmSingletonInterface.Instance.MoveObject(4);
                    retMessage = isSuccess ? "Arm moved to the right." : "Move to right request failed: The Arm is not holding any object at the moment.";
                    break;
                case ActionType.MoveUp:
                    isSuccess = ArmSingletonInterface.Instance.MoveObject(4);
                    retMessage = isSuccess ? "Arm moved one step forward." : "Move forward request failed: The Arm is not holding any object at the moment.";
                    break;
                case ActionType.MoveDown:
                    isSuccess = ArmSingletonInterface.Instance.MoveObject(4);
                    retMessage = isSuccess ? "Arm moved one step backwards." : "Move backward request failed: The Arm is not holding any object at the moment.";
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
