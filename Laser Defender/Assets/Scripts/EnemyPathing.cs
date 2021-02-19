﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPathing : MonoBehaviour {

    WaveConfig waveConfig;
    List<Transform> wayPoints;
    int waypointIndex = 0;

    // Start is called before the first frame update
    void Start() {
        wayPoints = waveConfig.GetWaypoints();
        transform.position = wayPoints[waypointIndex].transform.position;
    }

    // Update is called once per frame
    void Update() {
        Move();
    }

    public void SetWaveConfig(WaveConfig waveConfig) {
        this.waveConfig = waveConfig;
    }

    private void Move() {
        if (waypointIndex <= wayPoints.Count - 1) {
            var targetPosition = wayPoints[waypointIndex].transform.position;
            var movementThisFrame = waveConfig.GetMoveSpeed() * Time.deltaTime;
            transform.position = Vector2.MoveTowards(transform.position, targetPosition, movementThisFrame);
            if (transform.position == targetPosition) {
                waypointIndex++;
            }
        } else {
            Destroy(gameObject);
        }
    }
}
