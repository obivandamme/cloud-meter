import React, { useEffect, useState } from 'react';
import {Line} from 'react-chartjs-2';

export const Chart = () => {
    const loadData = async () => {
        const result = await fetch("loadprofile?date=2020-07-02T22:00:00.000Z");
        return result.json();
    }
    
    useEffect(() => {
        loadData().then(result => {
            setDataset(result);
        });
    }, [])
    
    const [dataset, setDataset] = useState({})
    
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
        datasets: [dataset]
    };

    return (
        <Line data={data} options={options}/>
    );
}