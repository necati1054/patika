import React from "react";

import { Grid } from "@mui/material";

function footer() {
    return (
        <Grid
            container
            spacing={0}
            direction="column"
            alignItems="center"
            justifyContent="center"
            style={{ backgroundColor: "#374151" }}
            minHeight="50px"
        >
            <Grid item
                style={{ color: "white" }}>
                by
                <a
                    style={{ color: "gray" }}
                    href="https://www.linkedin.com/in/necati-arman-4a8859228/"
                    target="_blank"
                    rel="noreferrer"
                >
                    {" "}
                    Necati Arman
                </a>{" "}
                •
                <a
                    style={{ color: "gray" }}
                    href="https://github.com/necati1054"
                    target="_blank"
                    rel="noreferrer"
                >
                    {" "}
                    github
                </a>
            </Grid>
        </Grid>
    );
}

export default footer;