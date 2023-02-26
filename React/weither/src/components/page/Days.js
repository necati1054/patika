import React, { useEffect } from 'react'
import { useWeather } from "../context/ContextApi";
import axios from 'axios';
import { border, Container } from '@mui/system';
import { Grid } from '@mui/material';

const Days = () => {
    const { city, weather, setWeather, days } = useWeather();

    useEffect(() => {

        const api_key = "apikey 5go7B0XOsEqaASkrtuGOxS:1HSWtomx0KT2wAEouuGuTe";
        const getCity = async () => {
            axios.get(
                `https://api.collectapi.com/weather/getWeather?data.lang=tr&data.city=${city.name}`,
                {
                    headers: {
                        Authorization: api_key,
                    },
                }
            ).then((res) => {
                console.log(res)
                if (res.status === 200) {
                    setWeather(res.data.result)
                } else {
                    console.log("Error")
                }
            }).catch((err) => {
                console.log(err)
            }
            )
        };
        getCity();
    }, [city]);

    return (
        <Grid container>
            <Grid item xs={12}>
                <h1>{city.name}</h1>
            </Grid>

            {weather.map((item, key) => {
                return (
                    <Grid item xs={2} key={key} style={{ textAlign: "center" }} mt={1}>
                        <div className={key == 0 ? "today" : "other"}>
                            <img src={item.icon} width="40" height="40"></img>
                            <h2>{item.day}</h2>
                            <p>{item.description}</p>
                            <p>{item.min}°C / {item.max}°C</p>
                        </div>
                    </Grid>
                )
            }
            )}
        </Grid >
    )
}

export default Days