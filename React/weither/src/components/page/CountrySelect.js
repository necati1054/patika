import { FormControl, Select, MenuItem } from '@mui/material';
import React from 'react'
import { useWeather } from "../context/ContextApi";

const CountrySelect = () => {
    const { city, cities, setCity } = useWeather();
    const changeCity = (e) => {
        cities.filter((item) => {
            if (item.name === e.target.value) {
                setCity(item);
            }
            return item;
        });
    };
    return (
        <div>
            <FormControl>
                <Select
                    value={city.name}
                    onChange={changeCity}
                >
                    {cities.map((item, key) => {
                        return (
                            <MenuItem value={item.name} key={key}>
                                {item.name}
                            </MenuItem>
                        );
                    })}
                </Select>
            </FormControl>
        </div>
    )
}

export default CountrySelect