const coordinatesReducer = (state = {}, action) => {
    switch(action.type) {
      case "input/setCoordinates":
        return action.payload
      default: 
        return state
    }
}

export const setCoordinates = (coordinates) => {
  return ({
    type: "input/setCoordinates",
    payload: coordinates
  })
}

export default coordinatesReducer