const convertTZ = (tzString, date) =>
  new Date(
    (typeof date === "string" ? new Date(date) : date).toLocaleString("en-US", {
      timeZone: tzString,
    })
  );

  module.exports = {convertTZ}