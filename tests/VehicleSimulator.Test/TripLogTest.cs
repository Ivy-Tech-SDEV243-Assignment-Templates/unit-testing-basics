namespace VehicleSimulator.Test;

public class TripLogTest
{
    [Fact]
    public void check_tests_are_working()
    {
        // We should see failing test output for this
        Assert.True(false);
    }

    [Fact]
    public void record_preserves_entry_order()
    {
        // TODO: Together
    }

    [Fact]
    public void print_output_formats_with_correct_precision()
    {
        // TODO: Together
    }

    [Fact]
    public void total_distance_is_zero_when_no_entries_exist()
    {
        // TODO: Together
    }

    [Fact]
    public void total_distance_is_zero_when_only_one_entry_exists()
    {
        // TODO: Together
    }

    [Fact]
    public void total_distance_correctly_calculates_horizontal_segment_length()
    {
        // TODO: Together
    }

    [Fact]
    public void total_distance_correctly_calculates_vertical_segment_length()
    {
        // Student will complete.

        // Should verify that when vehicle starts at origin and travels only
        // along y axis, the total distance is calculated correctly.
    }

    [Fact]
    public void total_distance_correctly_calculates_diagonal_segment_length()
    {
        // Student will complete.

        // Should verify that when vehicle starts at origin and travels
        // diagonally (to a point with positive x and y values), the total
        // distance is calculated correctly.

        // Hint: Use the point (3, 4) for the diagonal segment, so that length
        // is 5 and you don't have to worry about rounding errors.
    }

    [Fact]
    public void total_distance_correctly_calculates_when_negative_positions_values_are_used()
    {
        // Student will complete.

        // Should verify that when vehicle starts at origin and travels to a
        // negative position, the total distance is calculated correctly.

        // Hint: Use the point (-3, -4) for the negative position.
    }

    [Fact]
    public void total_distance_correct_when_more_than_two_positions_are_recorded()
    {
        // TODO: Together
    }
}
