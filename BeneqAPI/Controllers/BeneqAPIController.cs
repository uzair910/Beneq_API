using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

[Route("api/[controller]")]
[ApiController]
public class MyAPIController : ControllerBase
{
    // GET api/values
    //[EnableCors()]
    [HttpGet]
    public ActionResult Get(ActionType action, string sNumbers, int iNumber)
    {
        try
        {
            switch (action)
            {
                case ActionType.sumandcheck:
                    //iNumber = sNumbers.GetSpecialSum();
                    //return Ok(new { result = iNumber, isPrime = iNumber.IsPrime() });
                    return Ok();
                case ActionType.checkprime:
                    // TODO
                    //return Ok(new { isPrime = iNumber.IsPrime() });
                    return Ok();
                case ActionType.pick:
                // TODO
                case ActionType.drop:
                // TODO
                case ActionType.moveLeft:
                // TODO
                case ActionType.moveRight:
                // TODO
                case ActionType.moveForward:
                // TODO
                case ActionType.moveBackWard:
                    // TODO
                    break;
            }
        }
        catch (Exception ex)
        {
            return BadRequest(ex);
        }
        return BadRequest();
    }

    // GET api/values
    //[EnableCors()]
    [HttpGet]
    public ActionResult Get(ActionType action)
    {
        try
        {
            switch (action)
            {
                case ActionType.sumandcheck:
                    //iNumber = sNumbers.GetSpecialSum();
                    //return Ok(new { result = iNumber, isPrime = iNumber.IsPrime() });
                    return Ok();
                case ActionType.checkprime:
                    // TODO
                    //return Ok(new { isPrime = iNumber.IsPrime() });
                    return Ok();
                case ActionType.pick:
                // TODO
                case ActionType.drop:
                // TODO
                case ActionType.moveLeft:
                // TODO
                case ActionType.moveRight:
                // TODO
                case ActionType.moveForward:
                // TODO
                case ActionType.moveBackWard:
                    // TODO
                    break;
            }
        }
        catch (Exception ex)
        {
            return BadRequest(ex);
        }
        return BadRequest();
    }
}


public enum ActionType
{
    //sumandcheck,
    //checkprime,
    Pick,
    Drop,
    MoveDown,
    MoveUp,
    MoveRight,
    MoveLeft
}
