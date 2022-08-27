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
                case ActionType.MoveRight:
                    //iNumber = sNumbers.GetSpecialSum();
                    //return Ok(new { result = iNumber, isPrime = iNumber.IsPrime() });
                    return Ok();
                case ActionType.MoveUp:
                    // TODO
                    //return Ok(new { isPrime = iNumber.IsPrime() });
                    return Ok();
              
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
                case ActionType.Pick:
                // TODO
                case ActionType.Drop:
                // TODO
                case ActionType.MoveLeft:
                // TODO
                case ActionType.MoveRight:
                // TODO
                case ActionType.MoveUp:
                // TODO
                case ActionType.MoveDown:
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
