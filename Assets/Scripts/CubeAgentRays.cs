using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.MLAgents;
using Unity.MLAgents.Sensors;
using Unity.MLAgents.Actuators;

public class CubeAgentRays : Agent
{
    // private bool jump = true;
    // public Rigidbody rb;
    // public override void OnEpisodeBegin(){
    //     jump = true;

    //     this.transform.localPosition = new Vector3(0.17f,0.57f,3.79f);
    //     rb.transform.rotation = new Quaternion.Euler(0,-180,0);
    // }

    // public override void CollectObservations(VectorSensor sensor){
    //     sensor.AddObservation(this.transform.localPosition);
    // }

    // public override void OnActionReceived(ActionBuffers actionBuffers){
    //     if (actionBuffers.ContinuousAction[0] > 0 && jump){
    //         rb.AddForce(Vector3.up * 340, ForceMode.Acceleration);
    //         jump = false;
    //     }
    // }

    // public override void Heuristic(in ActionBuffers actionsOut){
    //     var continuousActionsOut = actionsOut.ContinuousActions;
    //     continuousActionsOut[0]=Input.GetAxis("Vertical");
    // }

    // private void OnCollisionStay(Collision collision){
    //     if (collision.gameObject.CompareTag("hit")){
    //         AddReward(-1f);
    //         Destroy(collision.gameObject);
    //         EndEpisode();
    //     }
    //     else if (collision.gameObject.CompareTag("point")){
    //         AddReward(1f);
    //         Destroy(collision.gameObject);
    //     }
    // }
}