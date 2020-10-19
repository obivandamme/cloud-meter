import React from 'react';
import {Line} from 'react-chartjs-2';
import moment from 'moment';

export const Chart = () => {
    const generateData = () => {
        const values = [
            0.6,0.6,0.6,0.6, // 0
            0.6,0.6,0.6,0.6, // 1
            0.6,0.6,0.6,0.6, // 2
            0.6,0.6,0.6,0.6, // 3
            0.6,0.6,0.6,0.6, // 4
            0.6,0.6,0.6,0.6, // 5
            0.6,0.6,0.6,0.6, // 6
            0.4,0.0,0.0,0.0, // 7
            0.0,0.0,0.0,0.0, // 8
            0.0,0.0,0.0,0.0, // 9
            0.0,0.0,0.0,0.0, // 10
            0.0,0.0,0.0,0.0, // 11
            0.0,0.0,0.0,0.0, // 12
            0.0,0.0,0.0,0.0, // 13
            0.0,0.0,0.0,0.0, // 14
            0.0,0.0,0.0,0.0, // 15
            0.0,0.0,0.0,0.0, // 16
            0.0,0.0,0.0,0.0, // 17
            0.0,0.0,0.0,0.0, // 18
            0.0,0.0,0.0,0.0, // 19
            0.2,0.6,0.6,0.6, // 20
            0.6,0.6,0.6,0.6, // 21
            0.6,0.6,0.6,0.6, // 22
            0.6,0.6,0.6,0.6, // 23
        ]
        const data = [];
        for(let i = 0; i<96; i+=1){
            data[i] = {
                y: values[i],
                x: moment("2020-07-02T22:00:00.000Z").add(i * 15, 'm')
            }
        }
        return data;
    }
    
    const options = {
        scales: {
            xAxes: [{
                type: 'time',
            }],
            yAxes: [{
                ticks: {
                    min: 0
                }
            }]
        }
    };
    const data = {
        datasets: [{
            label: 'Stromverbrauch in kWh',
            data: generateData(),
            pointStyle: 'none'
        }]
    };

    return (
        <Line data={data} options={options}/>
    );
}